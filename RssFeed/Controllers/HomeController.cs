using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RssFeed.Models;

namespace RssFeed.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var model = new RssFeedViewModel();

            model.Search = "";

            if (_db.RssFeed.Any())
            {
                model.Items = _db.RssFeed.ToList();
            }

            var userData = _db.UserData.FirstOrDefault(x => x.Description == "RssFeed");

            if (userData != null)
            {
                model.Url = userData.Value;
            }

            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Index(RssFeedViewModel model, string btnSearch)
        {
            try
            {
                IEnumerable<Domain.RssFeed> items = null;

                if (string.IsNullOrEmpty(btnSearch))
                {
                    items = await GetExternalRssList(model);
                    model.Search = string.Empty;
                }
                else
                {
                    if (model.Search == null)
                        model.Search = "";

                    items = _db.RssFeed.Where(x => x.Description.Contains(model.Search) ||
                    x.Author.Contains(model.Search) ||
                    x.Title.Contains(model.Search)).ToList();
                }

                model.Items = items.ToList();

                return View(model);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(model);
            }
        }

        private async Task<IEnumerable<Domain.RssFeed>> GetExternalRssList(RssFeedViewModel model)
        {
            using (var client = new HttpClient())
            {
                var RssData = await client.GetStringAsync(model.Url);

                XDocument xml = XDocument.Parse(RssData);
                var items = (from x in xml.Descendants("item")
                             select new Domain.RssFeed
                             {
                                 Title = (x.Element("title") != null ? (string)x.Element("title") : null),
                                 Link = (x.Element("link") != null ? (string)x.Element("link") : null),
                                 Description = (x.Element("description") != null ? (string)x.Element("description") : null),
                                 DatePublish = (x.Element("pubDate") != null ? (string)x.Element("pubDate") : null),
                                 Author = (x.Element("author") != null ? (string)x.Element("author") : null)
                             });

                _db.RssFeed.RemoveRange(_db.RssFeed);
                await _db.RssFeed.AddRangeAsync(items);

                if (_db.UserData.Any())
                {
                    var userData = await _db.UserData.FirstOrDefaultAsync(x => x.Description == "RssFeed");

                    if (userData != null)
                    {
                        userData.Value = model.Url;
                        _db.UserData.Update(userData);
                    }
                }
                else
                {
                    await _db.UserData.AddAsync(new UserData { Description = "RssFeed", Value = model.Url });
                }

                await _db.SaveChangesAsync();

                return items;
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

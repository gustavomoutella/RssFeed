using Domain;
using Microsoft.AspNetCore.Authentication;
using System.Collections.Generic;

namespace RssFeed.Models
{
    public class RssFeedViewModel
    {
        public RssFeedViewModel()
        {
            Items = new List<Domain.RssFeed>();
        }

        public string Url { get; set; }
        public string Search { get; set; }
        public List<Domain.RssFeed> Items { get; set; }
    }
}

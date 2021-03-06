#pragma checksum "C:\Users\GustavoMoutella\source\repos\RssFeed\RssFeed\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d0cc8418ee292719c6198947d91cfed71de74ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\GustavoMoutella\source\repos\RssFeed\RssFeed\Views\_ViewImports.cshtml"
using RssFeed;

#line default
#line hidden
#line 2 "C:\Users\GustavoMoutella\source\repos\RssFeed\RssFeed\Views\_ViewImports.cshtml"
using RssFeed.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d0cc8418ee292719c6198947d91cfed71de74ce", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67850974e79094de3b2fae74f93c239881383e60", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RssFeed.Models.RssFeedViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\GustavoMoutella\source\repos\RssFeed\RssFeed\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(79, 12, true);
            WriteLiteral("\r\n<br />\r\n\r\n");
            EndContext();
#line 9 "C:\Users\GustavoMoutella\source\repos\RssFeed\RssFeed\Views\Home\Index.cshtml"
 using (Html.BeginForm())
{


#line default
#line hidden
            BeginContext(123, 361, true);
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-md-7"">
            <h2>RSS Feed Reader</h2>
        </div>
        <div class=""col-md-4"">
            <div class=""form-group"">
                <label for=""search"" style=""font-weight: bold;"">Text:</label>
                <input type=""text"" name=""Search"" placeholder=""Search in the RSS..."" class=""form-control""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 484, "\"", 505, 1);
#line 19 "C:\Users\GustavoMoutella\source\repos\RssFeed\RssFeed\Views\Home\Index.cshtml"
WriteAttributeValue("", 492, Model.Search, 492, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(506, 287, true);
            WriteLiteral(@"
                       style=""min-width:100%"" />
            </div>
        </div>
        <div class=""col-md-1"">
            <input type=""submit"" class=""btn btn-danger"" style=""margin-top: 1.9em;"" value=""Search""
                   name=""btnSearch"" />
        </div>
    </div>
");
            EndContext();
            BeginContext(795, 12, true);
            WriteLiteral("    <hr />\r\n");
            EndContext();
            BeginContext(809, 279, true);
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-md-11"">
            <div class=""form-group"">
                <label for=""url"" style=""font-weight: bold;"">Feed Url:</label>
                <input type=""URL"" name=""Url"" placeholder=""Enter RSS Feed URL Here..."" class=""form-control""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1088, "\"", 1106, 1);
#line 35 "C:\Users\GustavoMoutella\source\repos\RssFeed\RssFeed\Views\Home\Index.cshtml"
WriteAttributeValue("", 1096, Model.Url, 1096, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1107, 400, true);
            WriteLiteral(@"
                       style=""min-width:100%"" />
            </div>

        </div>
        <div class=""col-md-1"">
            <div class=""form-group"">
                <input type=""submit"" class=""btn btn-info"" style=""margin-top: 1.98em;"" value=""Submit"" onclick=""if (Url.value == '') { alert('Please, fill the url field.'); return false; }"" />
            </div>
        </div>
    </div>
");
            EndContext();
#line 46 "C:\Users\GustavoMoutella\source\repos\RssFeed\RssFeed\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1510, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 48 "C:\Users\GustavoMoutella\source\repos\RssFeed\RssFeed\Views\Home\Index.cshtml"
 if (ViewBag.Error == null)
{


#line default
#line hidden
            BeginContext(1546, 301, true);
            WriteLiteral(@"    <table class=""table table-hover"">
        <thead>
            <tr>
                <th>Title</th>
                <th>Link</th>
                <th>Description</th>
                <th>Author</th>
                <th>Publish Date</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 62 "C:\Users\GustavoMoutella\source\repos\RssFeed\RssFeed\Views\Home\Index.cshtml"
             if (Model.Items != null && Model.Items.Any())
            {
                foreach (var item in Model.Items)
                {

#line default
#line hidden
            BeginContext(1992, 50, true);
            WriteLiteral("            <tr>\r\n                <td width=\"20%\">");
            EndContext();
            BeginContext(2043, 10, false);
#line 67 "C:\Users\GustavoMoutella\source\repos\RssFeed\RssFeed\Views\Home\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2053, 41, true);
            WriteLiteral("</td>\r\n                <td width=\"20%\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2094, "\"", 2111, 1);
#line 68 "C:\Users\GustavoMoutella\source\repos\RssFeed\RssFeed\Views\Home\Index.cshtml"
WriteAttributeValue("", 2101, item.Link, 2101, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2112, 17, true);
            WriteLiteral(" target=\"_blank\">");
            EndContext();
            BeginContext(2130, 9, false);
#line 68 "C:\Users\GustavoMoutella\source\repos\RssFeed\RssFeed\Views\Home\Index.cshtml"
                                                                Write(item.Link);

#line default
#line hidden
            EndContext();
            BeginContext(2139, 43, true);
            WriteLiteral("</a></td>\r\n                <td width=\"30%\">");
            EndContext();
            BeginContext(2183, 16, false);
#line 69 "C:\Users\GustavoMoutella\source\repos\RssFeed\RssFeed\Views\Home\Index.cshtml"
                           Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2199, 39, true);
            WriteLiteral("</td>\r\n                <td width=\"20%\">");
            EndContext();
            BeginContext(2239, 11, false);
#line 70 "C:\Users\GustavoMoutella\source\repos\RssFeed\RssFeed\Views\Home\Index.cshtml"
                           Write(item.Author);

#line default
#line hidden
            EndContext();
            BeginContext(2250, 39, true);
            WriteLiteral("</td>\r\n                <td width=\"10%\">");
            EndContext();
            BeginContext(2290, 16, false);
#line 71 "C:\Users\GustavoMoutella\source\repos\RssFeed\RssFeed\Views\Home\Index.cshtml"
                           Write(item.DatePublish);

#line default
#line hidden
            EndContext();
            BeginContext(2306, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 73 "C:\Users\GustavoMoutella\source\repos\RssFeed\RssFeed\Views\Home\Index.cshtml"

                }
            }

#line default
#line hidden
            BeginContext(2368, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 79 "C:\Users\GustavoMoutella\source\repos\RssFeed\RssFeed\Views\Home\Index.cshtml"
     if (Model.Items == null || !Model.Items.Any())
    {

#line default
#line hidden
            BeginContext(2462, 59, true);
            WriteLiteral("        <span style=\"color: gray;\">No items found.</span>\r\n");
            EndContext();
#line 82 "C:\Users\GustavoMoutella\source\repos\RssFeed\RssFeed\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#line 82 "C:\Users\GustavoMoutella\source\repos\RssFeed\RssFeed\Views\Home\Index.cshtml"
     

}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RssFeed.Models.RssFeedViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

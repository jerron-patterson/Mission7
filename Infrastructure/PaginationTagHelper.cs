using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Mission7.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "pg-mdl")]
    public class PaginationTagHelper : TagHelper
    {
        private IUrlHelperFactory uhf;
        public PaginationTagHelper (IUrlHelperFactory temp)
        {
            uhf = temp;
        }
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext vc { get; set; }
        public PageInfo PgMdl { get; set; }
        public string PageAction { get; set; }
        public override void Process (TagHelperContext THC, TagHelperOutput THO)
        {
            IUrlHelper uh = uhf.GetUrlHelper(vc);
            TagBuilder final = new TagBuilder("div");
            for (int counter = 1; counter < (PgMdl.TtlPgs + 1); counter++)
            {
                TagBuilder tb = new TagBuilder("a");
                tb.Attributes["href"] = uh.Action(PageAction, new { pageNum = counter });
                tb.InnerHtml.Append(counter.ToString()+ " ");
                final.InnerHtml.AppendHtml(tb);
            }
            THO.Content.AppendHtml(final.InnerHtml);
        }
    }
}

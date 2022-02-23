using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "pg-mdl")]
    public class PaginationTagHelper : TagHelper
    {
    }
}

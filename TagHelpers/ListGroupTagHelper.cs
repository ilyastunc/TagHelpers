using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelpers.TagHelpers
{
    [HtmlTargetElement("ul", Attributes = "items")]
    public class ListGroupTagHelper : TagHelper
    {
        public List<string> Items { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", "list-group");

            foreach (var item in Items)
            {
                TagBuilder li = new TagBuilder("li");

                li.Attributes["class"] = "list-group-item";
                li.InnerHtml.AppendHtml(item);

                output.PreContent.AppendHtml(li);
            }
        }
    }
}
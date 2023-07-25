using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelpers.TagHelpers
{
    [HtmlTargetElement("button", Attributes = "bs-button-color", ParentTag = "form")] //sadece form içindeki button'larda geçerli olacak, baştaki "button"u silsek formdaki tüm elemanlar için geçerli olacak.
    public class ButtonTagHelper : TagHelper
    {
        public string BsButtonColor { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class",$"btn btn-{BsButtonColor}");
        }
    }
}
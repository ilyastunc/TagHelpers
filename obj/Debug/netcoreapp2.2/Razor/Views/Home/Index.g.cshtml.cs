#pragma checksum "/Users/tunc/Documents/C#/TagHelpers/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ef0daefdd6c7a57c57c619f1cea15fe544f8d5a"
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
#line 1 "/Users/tunc/Documents/C#/TagHelpers/Views/_ViewImports.cshtml"
using TagHelpers.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ef0daefdd6c7a57c57c619f1cea15fe544f8d5a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bb9e80c927341c27f676897dcb8f9341a4983be", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "submit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("bg-color", "danger", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "reset", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::TagHelpers.TagHelpers.ListGroupTagHelper __TagHelpers_TagHelpers_ListGroupTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::TagHelpers.TagHelpers.FormButtonTagHelper __TagHelpers_TagHelpers_FormButtonTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/tunc/Documents/C#/TagHelpers/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Index";
    List<string> liste = new List<string>() {"Telefon", "Tablet", "Bilgisayar"};

#line default
#line hidden
            BeginContext(147, 310, true);
            WriteLiteral(@"
<div class=""m-1 p-1 bg-primary"">
    <div class=""row text-white"">
        <div class=""col-7"">
            <h4>Products</h4>
        </div>
        <div class=""col-5 text-right"">
            
        </div>
    </div>
</div>

<div class=""m-1 p-1"">
    <div class=""row"">
        <div class=""col-3"">
            ");
            EndContext();
            BeginContext(457, 24, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ul", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ef0daefdd6c7a57c57c619f1cea15fe544f8d5a5897", async() => {
            }
            );
            __TagHelpers_TagHelpers_ListGroupTagHelper = CreateTagHelper<global::TagHelpers.TagHelpers.ListGroupTagHelper>();
            __tagHelperExecutionContext.Add(__TagHelpers_TagHelpers_ListGroupTagHelper);
#line 21 "/Users/tunc/Documents/C#/TagHelpers/Views/Home/Index.cshtml"
__TagHelpers_TagHelpers_ListGroupTagHelper.Items = liste;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("items", __TagHelpers_TagHelpers_ListGroupTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(481, 374, true);
            WriteLiteral(@"
        </div>
        <div class=""col-9"">
            <table class=""table table-bordered table-striped table-sm"">
                <thead>
                    <tr>
                    <th >#</th>
                    <th >Name</th>
                    <th >Price</th>
                    <th ></th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 34 "/Users/tunc/Documents/C#/TagHelpers/Views/Home/Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(926, 61, true);
            WriteLiteral("                        <tr>\n                            <th>");
            EndContext();
            BeginContext(988, 14, false);
#line 37 "/Users/tunc/Documents/C#/TagHelpers/Views/Home/Index.cshtml"
                           Write(item.ProductId);

#line default
#line hidden
            EndContext();
            BeginContext(1002, 38, true);
            WriteLiteral("</th>\n                            <td>");
            EndContext();
            BeginContext(1041, 16, false);
#line 38 "/Users/tunc/Documents/C#/TagHelpers/Views/Home/Index.cshtml"
                           Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1057, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1096, 10, false);
#line 39 "/Users/tunc/Documents/C#/TagHelpers/Views/Home/Index.cshtml"
                           Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1106, 77, true);
            WriteLiteral("</td>\n                            <td></td>\n                        </tr>   \n");
            EndContext();
#line 42 "/Users/tunc/Documents/C#/TagHelpers/Views/Home/Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1205, 58, true);
            WriteLiteral("                </tbody>\n            </table>\n            ");
            EndContext();
            BeginContext(1263, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ef0daefdd6c7a57c57c619f1cea15fe544f8d5a9350", async() => {
                BeginContext(1346, 6, true);
                WriteLiteral("Create");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1356, 13, true);
            WriteLiteral("\n            ");
            EndContext();
            BeginContext(1369, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("formbutton", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ef0daefdd6c7a57c57c619f1cea15fe544f8d5a11079", async() => {
            }
            );
            __TagHelpers_TagHelpers_FormButtonTagHelper = CreateTagHelper<global::TagHelpers.TagHelpers.FormButtonTagHelper>();
            __tagHelperExecutionContext.Add(__TagHelpers_TagHelpers_FormButtonTagHelper);
            __TagHelpers_TagHelpers_FormButtonTagHelper.Type = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __TagHelpers_TagHelpers_FormButtonTagHelper.BgColor = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1426, 13, true);
            WriteLiteral("\n            ");
            EndContext();
            BeginContext(1439, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("formbutton", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ef0daefdd6c7a57c57c619f1cea15fe544f8d5a12484", async() => {
            }
            );
            __TagHelpers_TagHelpers_FormButtonTagHelper = CreateTagHelper<global::TagHelpers.TagHelpers.FormButtonTagHelper>();
            __tagHelperExecutionContext.Add(__TagHelpers_TagHelpers_FormButtonTagHelper);
            __TagHelpers_TagHelpers_FormButtonTagHelper.Type = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1477, 39, true);
            WriteLiteral("\n        </div>\n    </div>\n    \n</div>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
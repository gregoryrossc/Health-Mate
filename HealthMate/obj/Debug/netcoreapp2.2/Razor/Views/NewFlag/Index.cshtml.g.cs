#pragma checksum "C:\Users\Gregory\Desktop\Health_Mate\HealthMate-master\HealthMate\HealthMate\Views\NewFlag\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2befcc0f450c6ca724a03e8d2b50d63dfa8a6ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NewFlag_Index), @"mvc.1.0.view", @"/Views/NewFlag/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NewFlag/Index.cshtml", typeof(AspNetCore.Views_NewFlag_Index))]
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
#line 1 "C:\Users\Gregory\Desktop\Health_Mate\HealthMate-master\HealthMate\HealthMate\Views\_ViewImports.cshtml"
using HealthMate;

#line default
#line hidden
#line 2 "C:\Users\Gregory\Desktop\Health_Mate\HealthMate-master\HealthMate\HealthMate\Views\_ViewImports.cshtml"
using HealthMate.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2befcc0f450c6ca724a03e8d2b50d63dfa8a6ab", @"/Views/NewFlag/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14b4275c7b0f2dfaf71c324c35e7afccf202171a", @"/Views/_ViewImports.cshtml")]
    public class Views_NewFlag_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HealthMate.Models.Meals>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Chart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Gregory\Desktop\Health_Mate\HealthMate-master\HealthMate\HealthMate\Views\NewFlag\Index.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
            BeginContext(89, 132, true);
            WriteLiteral("\r\n\r\n<h4>Meals To Flag</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <p>Search database for food by name</p>\r\n");
            EndContext();
#line 13 "C:\Users\Gregory\Desktop\Health_Mate\HealthMate-master\HealthMate\HealthMate\Views\NewFlag\Index.cshtml"
         using (Html.BeginForm("Index", "NewFlag", FormMethod.Get))
        {
            

#line default
#line hidden
            BeginContext(314, 25, false);
#line 15 "C:\Users\Gregory\Desktop\Health_Mate\HealthMate-master\HealthMate\HealthMate\Views\NewFlag\Index.cshtml"
       Write(Html.TextBox("searching"));

#line default
#line hidden
            EndContext();
            BeginContext(339, 40, true);
            WriteLiteral("<input type=\"submit\" value=\"Search\" />\r\n");
            EndContext();
#line 16 "C:\Users\Gregory\Desktop\Health_Mate\HealthMate-master\HealthMate\HealthMate\Views\NewFlag\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(390, 296, true);
            WriteLiteral(@"        <br />
        <div style=""height: 200px; overflow: auto;"">
            <table class=""table table-striped"">
                <thead>
                    <tr>
                        <th>Meal Name</th>
                    </tr>

                </thead>
                <tbody>

");
            EndContext();
#line 28 "C:\Users\Gregory\Desktop\Health_Mate\HealthMate-master\HealthMate\HealthMate\Views\NewFlag\Index.cshtml"
                     if (Model.Count() == 0)
                    {

#line default
#line hidden
            BeginContext(755, 202, true);
            WriteLiteral("                        <tr>\r\n                            <td colspan=\"3\" style=\"color:red\">\r\n                                No Match\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 35 "C:\Users\Gregory\Desktop\Health_Mate\HealthMate-master\HealthMate\HealthMate\Views\NewFlag\Index.cshtml"
                    }
                    else
                    {

                        foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1111, 72, true);
            WriteLiteral("                            <tr>\r\n\r\n                                <td>");
            EndContext();
            BeginContext(1184, 13, false);
#line 43 "C:\Users\Gregory\Desktop\Health_Mate\HealthMate-master\HealthMate\HealthMate\Views\NewFlag\Index.cshtml"
                               Write(item.MealName);

#line default
#line hidden
            EndContext();
            BeginContext(1197, 47, true);
            WriteLiteral("</td>\r\n\r\n                                <td>\r\n");
            EndContext();
#line 46 "C:\Users\Gregory\Desktop\Health_Mate\HealthMate-master\HealthMate\HealthMate\Views\NewFlag\Index.cshtml"
                                     using (Html.BeginForm("someOtherFormSubmit2", "NewFlag"))
                                    {

#line default
#line hidden
            BeginContext(1379, 61, true);
            WriteLiteral("                                        <input name=\"newMeal\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 1440, "", 1459, 1);
#line 48 "C:\Users\Gregory\Desktop\Health_Mate\HealthMate-master\HealthMate\HealthMate\Views\NewFlag\Index.cshtml"
WriteAttributeValue("", 1447, item.MealId, 1447, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1459, 25, true);
            WriteLiteral(" input type=\"hidden\" />\r\n");
            EndContext();
            BeginContext(1490, 93, true);
            WriteLiteral("                                        <button type=\"submit\">Add New Flagged Meal</button>\r\n");
            EndContext();
#line 53 "C:\Users\Gregory\Desktop\Health_Mate\HealthMate-master\HealthMate\HealthMate\Views\NewFlag\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(1622, 74, true);
            WriteLiteral("                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 56 "C:\Users\Gregory\Desktop\Health_Mate\HealthMate-master\HealthMate\HealthMate\Views\NewFlag\Index.cshtml"

                        }
                    }

#line default
#line hidden
            BeginContext(1748, 113, true);
            WriteLiteral("\r\n\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n\r\n    </div>\r\n</div>\r\n<br />\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1861, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2befcc0f450c6ca724a03e8d2b50d63dfa8a6ab8862", async() => {
                BeginContext(1906, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1922, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1952, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 75 "C:\Users\Gregory\Desktop\Health_Mate\HealthMate-master\HealthMate\HealthMate\Views\NewFlag\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HealthMate.Models.Meals>> Html { get; private set; }
    }
}
#pragma warning restore 1591

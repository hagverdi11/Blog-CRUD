#pragma checksum "C:\Users\HP\Desktop\last hv\Fiorello-backend\EntityFrameworkProject\Views\Shared\_ProductsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e39d51117cd4f3fd62596803ab2d397f8d0f4a2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductsPartial), @"mvc.1.0.view", @"/Views/Shared/_ProductsPartial.cshtml")]
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
#nullable restore
#line 1 "C:\Users\HP\Desktop\last hv\Fiorello-backend\EntityFrameworkProject\Views\_ViewImports.cshtml"
using EntityFrameworkProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\last hv\Fiorello-backend\EntityFrameworkProject\Views\_ViewImports.cshtml"
using EntityFrameworkProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\last hv\Fiorello-backend\EntityFrameworkProject\Views\_ViewImports.cshtml"
using EntityFrameworkProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e39d51117cd4f3fd62596803ab2d397f8d0f4a2b", @"/Views/Shared/_ProductsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49e17352f318fecc95cd7741e7086c6f2ff47e52", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\Desktop\last hv\Fiorello-backend\EntityFrameworkProject\Views\Shared\_ProductsPartial.cshtml"
 foreach (var product in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-sm-6 col-md-4 col-lg-3 mt-3\">\r\n        <div class=\"product-item text-center\" data-id=\"");
#nullable restore
#line 6 "C:\Users\HP\Desktop\last hv\Fiorello-backend\EntityFrameworkProject\Views\Shared\_ProductsPartial.cshtml"
                                                  Write(product.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n            <input type=\"hidden\" class=\"product-id\"");
            BeginWriteAttribute("value", " value=\"", 247, "\"", 266, 1);
#nullable restore
#line 7 "C:\Users\HP\Desktop\last hv\Fiorello-backend\EntityFrameworkProject\Views\Shared\_ProductsPartial.cshtml"
WriteAttributeValue("", 255, product.Id, 255, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <div class=\"img\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 321, "\"", 328, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e39d51117cd4f3fd62596803ab2d397f8d0f4a2b5462", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 362, "~/img/", 362, 6, true);
#nullable restore
#line 10 "C:\Users\HP\Desktop\last hv\Fiorello-backend\EntityFrameworkProject\Views\Shared\_ProductsPartial.cshtml"
AddHtmlAttributeValue("", 368, product.ProductImages.FirstOrDefault(m=>m.IsMain)?.Image, 368, 57, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </a>\r\n            </div>\r\n            <div class=\"title mt-3\">\r\n                <h6>");
#nullable restore
#line 14 "C:\Users\HP\Desktop\last hv\Fiorello-backend\EntityFrameworkProject\Views\Shared\_ProductsPartial.cshtml"
               Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
            </div>
            <div class=""price"">
                <span class=""text-black-50"">
                        <button type=""submit"" class=""btn btn-primary add-to-cart"">add to cart</button>
                </span>
                <span class=""text-black-50"">$");
#nullable restore
#line 20 "C:\Users\HP\Desktop\last hv\Fiorello-backend\EntityFrameworkProject\Views\Shared\_ProductsPartial.cshtml"
                                        Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 24 "C:\Users\HP\Desktop\last hv\Fiorello-backend\EntityFrameworkProject\Views\Shared\_ProductsPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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

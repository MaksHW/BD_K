#pragma checksum "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "972f7066fb099d8fec5eee26f0012af1383d09ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Catalog), @"mvc.1.0.view", @"/Views/Home/Catalog.cshtml")]
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
#line 1 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\_ViewImports.cshtml"
using BD_Kyrsach;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\_ViewImports.cshtml"
using BD_Kyrsach.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"972f7066fb099d8fec5eee26f0012af1383d09ab", @"/Views/Home/Catalog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9c950ad5cf5a314f8fbf9d0ccb390d5565220b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Catalog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Img/catalogimg.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Catalog of our beautiful furniture</h2>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
  var i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"text-center mb-4\">\r\n");
#nullable restore
#line 6 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
      var item = @Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
      for (i = 0; i < @Model.Count; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row wow fadeIn\">\r\n            <div class=\"col-lg-3 col-md-6 mb-4\">\r\n                Number: ");
#nullable restore
#line 11 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
                   Write(item[i].FurnitureId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Name: ");
#nullable restore
#line 12 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
                 Write(item[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Price: ");
#nullable restore
#line 13 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
                  Write(item[i].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
                   if (User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "972f7066fb099d8fec5eee26f0012af1383d09ab6241", async() => {
                WriteLiteral("Order");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-value", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
                                                                       WriteLiteral(item[i].FurnitureId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["value"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-value", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["value"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 15 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
                                                                                                                  }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<strong>To order - sing in or register</strong>");
#nullable restore
#line 17 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
                                                                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 20 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
              i++;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
             if (i == Model.Count) { break; }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-lg-3 col-md-6 mb-4\">\r\n            Number: ");
#nullable restore
#line 23 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
               Write(item[i].FurnitureId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            Name: ");
#nullable restore
#line 24 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
             Write(item[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            Price: ");
#nullable restore
#line 25 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
              Write(item[i].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
               if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "972f7066fb099d8fec5eee26f0012af1383d09ab10768", async() => {
                WriteLiteral("Order");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-value", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
                                                                   WriteLiteral(item[i].FurnitureId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["value"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-value", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["value"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 27 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
                                                                                                              }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<strong>To order - sing in or register</strong>");
#nullable restore
#line 29 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
                                                                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 32 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
              i++;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
             if (i == Model.Count) { break; }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-lg-3 col-md-6 mb-4\">\r\n            Number: ");
#nullable restore
#line 35 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
               Write(item[i].FurnitureId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            Name: ");
#nullable restore
#line 36 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
             Write(item[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            Price: ");
#nullable restore
#line 37 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
              Write(item[i].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
               if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "972f7066fb099d8fec5eee26f0012af1383d09ab15268", async() => {
                WriteLiteral("Order");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-value", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
                                                                   WriteLiteral(item[i].FurnitureId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["value"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-value", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["value"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 39 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
                                                                                                              }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<strong>To order - sing in or register</strong>");
#nullable restore
#line 41 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
                                                                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 44 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
              i++;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
             if (i == Model.Count) { break; }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-lg-3 col-md-6 mb-4\">\r\n            Number: ");
#nullable restore
#line 47 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
               Write(item[i].FurnitureId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            Name: ");
#nullable restore
#line 48 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
             Write(item[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            Price: ");
#nullable restore
#line 49 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
              Write(item[i].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
               if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "972f7066fb099d8fec5eee26f0012af1383d09ab19768", async() => {
                WriteLiteral("Order");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-value", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
                                                                   WriteLiteral(item[i].FurnitureId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["value"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-value", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["value"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 51 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
                                                                                                              }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<strong>To order - sing in or register</strong>");
#nullable restore
#line 53 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
                                                                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        </div>");
#nullable restore
#line 56 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Home\Catalog.cshtml"
              };
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n<div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "972f7066fb099d8fec5eee26f0012af1383d09ab23065", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
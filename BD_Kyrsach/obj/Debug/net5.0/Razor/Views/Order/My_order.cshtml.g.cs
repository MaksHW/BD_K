#pragma checksum "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4257e815982fe2b7614ee71cbc848a4658e4cb58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_My_order), @"mvc.1.0.view", @"/Views/Order/My_order.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4257e815982fe2b7614ee71cbc848a4658e4cb58", @"/Views/Order/My_order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9c950ad5cf5a314f8fbf9d0ccb390d5565220b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_My_order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete_order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Img/myorder.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("1200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("1000"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h2>Your orders of our beautiful furniture</h2>\r\n");
#nullable restore
#line 2 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
  var i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"text-center mb-4\">\r\n");
#nullable restore
#line 4 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
      var item4 = @Model.Item1;
        var item5 = Model.Item2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
      for (i = 0; i < @Model.Item1.Count; i++)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row wow fadeIn\">\r\n                    <div class=\"col-lg-3 col-md-6 mb-4\">\r\n                        FurnitureId: ");
#nullable restore
#line 11 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                                Write(item4[i].FurnitureId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        Date: ");
#nullable restore
#line 12 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                         Write(item4[i].Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        Number: ");
#nullable restore
#line 13 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                           Write(item5[i].FurnitureId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        Name: ");
#nullable restore
#line 14 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                         Write(item5[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        Price: ");
#nullable restore
#line 15 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                          Write(item5[i].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4257e815982fe2b7614ee71cbc848a4658e4cb587196", async() => {
                WriteLiteral("Delete");
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
#line 16 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                                                                                 WriteLiteral(item4[i].OrderId);

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
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 18 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                  i++;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                 if (i == Model.Item1.Count) { break; }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-3 col-md-6 mb-4\">\r\n                FurnitureId: ");
#nullable restore
#line 21 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                        Write(item4[i].FurnitureId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Date: ");
#nullable restore
#line 22 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                 Write(item4[i].Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Number: ");
#nullable restore
#line 23 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                   Write(item5[i].FurnitureId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Name: ");
#nullable restore
#line 24 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                 Write(item5[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Price: ");
#nullable restore
#line 25 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                  Write(item5[i].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4257e815982fe2b7614ee71cbc848a4658e4cb5811473", async() => {
                WriteLiteral("Delete");
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
#line 26 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                                                                         WriteLiteral(item4[i].OrderId);

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
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 28 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                  i++;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                 if (i == Model.Item1.Count) { break; }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-3 col-md-6 mb-4\">\r\n                FurnitureId: ");
#nullable restore
#line 31 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                        Write(item4[i].FurnitureId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Date: ");
#nullable restore
#line 32 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                 Write(item4[i].Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Number: ");
#nullable restore
#line 33 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                   Write(item5[i].FurnitureId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Name: ");
#nullable restore
#line 34 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                 Write(item5[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Price: ");
#nullable restore
#line 35 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                  Write(item5[i].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4257e815982fe2b7614ee71cbc848a4658e4cb5815735", async() => {
                WriteLiteral("Delete");
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
#line 36 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                                                                         WriteLiteral(item4[i].OrderId);

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
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 38 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                  i++;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                 if (i == Model.Item1.Count) { break; }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-3 col-md-6 mb-4\">\r\n                FurnitureId: ");
#nullable restore
#line 41 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                        Write(item4[i].FurnitureId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Date: ");
#nullable restore
#line 42 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                 Write(item4[i].Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Number: ");
#nullable restore
#line 43 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                   Write(item5[i].FurnitureId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Name: ");
#nullable restore
#line 44 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                 Write(item5[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Price: ");
#nullable restore
#line 45 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                  Write(item5[i].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4257e815982fe2b7614ee71cbc848a4658e4cb5819997", async() => {
                WriteLiteral("Delete");
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
#line 46 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                                                                         WriteLiteral(item4[i].OrderId);

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
            WriteLiteral("\r\n            </div>\r\n            </div>");
#nullable restore
#line 48 "C:\Users\Максим\Desktop\Учёба\Курс2\BD_K\BD_Kyrsach\Views\Order\My_order.cshtml"
                  };
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n<div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4257e815982fe2b7614ee71cbc848a4658e4cb5822687", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>");
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
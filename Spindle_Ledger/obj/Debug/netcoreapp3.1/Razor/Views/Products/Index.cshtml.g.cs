#pragma checksum "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3de7cda9565e405300dd8307c8b5589d52ef05f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#line 1 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\_ViewImports.cshtml"
using Spindle_Ledger;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\_ViewImports.cshtml"
using Spindle_Ledger.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3de7cda9565e405300dd8307c8b5589d52ef05f", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd6c114e9a60e2297ee0ecd148352eadbcb155c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Spindle_Ledger.Models.Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3de7cda9565e405300dd8307c8b5589d52ef05f4627", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Product_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Product_Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Product_Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Product_Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 32 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Seller_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Seller_Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Seller_Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 43 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TransportFromSeller_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TransportFromSeller_Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TransportFromSeller_Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TransportFromSeller_Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 55 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TransportFromSeller_Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 60 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WareHouse_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 63 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WareHouse_Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 66 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WareHouse_Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 69 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WareHouse_Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 75 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TransportToCustomer_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 78 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TransportToCustomer_Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 81 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TransportToCustomer_Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 84 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TransportToCustomer_Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 87 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TransportToCustomer_Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 92 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 95 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer_Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 98 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer_Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 106 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 109 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 112 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product_Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 115 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product_Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 118 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product_Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n\r\n\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 125 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Seller_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 128 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Seller_Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 131 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Seller_Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 136 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TransportFromSeller_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 139 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TransportFromSeller_Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 142 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TransportFromSeller_Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 145 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TransportFromSeller_Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 148 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TransportFromSeller_Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 154 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.WareHouse_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 157 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.WareHouse_Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 160 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.WareHouse_Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 163 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.WareHouse_Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n\r\n\r\n\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 171 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TransportToCustomer_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 174 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TransportToCustomer_Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 177 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TransportToCustomer_Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 180 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TransportToCustomer_Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 183 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TransportToCustomer_Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 188 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Customer_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 191 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Customer_Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 194 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Customer_Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3de7cda9565e405300dd8307c8b5589d52ef05f22042", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 199 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
                                       WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3de7cda9565e405300dd8307c8b5589d52ef05f24207", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 200 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
                                          WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3de7cda9565e405300dd8307c8b5589d52ef05f26378", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 201 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
                                         WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 204 "D:\Spindle\Projects\Spindle_Ledger\Spindle_Ledger\Views\Products\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Spindle_Ledger.Models.Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591

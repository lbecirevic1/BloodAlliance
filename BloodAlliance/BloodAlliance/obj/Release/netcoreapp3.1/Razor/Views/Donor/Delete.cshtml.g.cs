#pragma checksum "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "599ef42a0844a2d706396de8faa225176c48f8bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Donor_Delete), @"mvc.1.0.view", @"/Views/Donor/Delete.cshtml")]
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
#line 1 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\_ViewImports.cshtml"
using BloodAlliance;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\_ViewImports.cshtml"
using BloodAlliance.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"599ef42a0844a2d706396de8faa225176c48f8bb", @"/Views/Donor/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71870e98f9b212fc4a792387575e6bb8c7365aec", @"/Views/_ViewImports.cshtml")]
    public class Views_Donor_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BloodAlliance.Models.Donor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Donor</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Prezime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Prezime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BrojTelefona));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BrojTelefona));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Jmbg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Jmbg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.KrvnaGrupa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayFor(model => model.KrvnaGrupa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RhFaktor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RhFaktor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BrojDarivanja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BrojDarivanja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TjelesnaTezina));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TjelesnaTezina));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MjestoDarivanja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MjestoDarivanja));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DatumPosljednjeDonacije));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DatumPosljednjeDonacije));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Hemoglobin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Hemoglobin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.KrvniPritisak));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayFor(model => model.KrvniPritisak));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StatusDonora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StatusDonora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n       \r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "599ef42a0844a2d706396de8faa225176c48f8bb16730", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "599ef42a0844a2d706396de8faa225176c48f8bb16997", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 120 "C:\Users\Fahira\Source\Repos\Grupa7-BloodAlliance\BloodAlliance\BloodAlliance\Views\Donor\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DonorId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "599ef42a0844a2d706396de8faa225176c48f8bb18814", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BloodAlliance.Models.Donor> Html { get; private set; }
    }
}
#pragma warning restore 1591
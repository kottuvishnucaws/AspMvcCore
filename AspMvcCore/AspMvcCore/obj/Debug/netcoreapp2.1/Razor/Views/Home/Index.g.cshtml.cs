#pragma checksum "C:\Users\Lenovo\source\repos\AspMvcCore\AspMvcCore\AspMvcCore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a330b6c2115310dc16c7999407e8daf9119d3ebe"
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
#line 1 "C:\Users\Lenovo\source\repos\AspMvcCore\AspMvcCore\AspMvcCore\Views\_ViewImports.cshtml"
using AspMvcCore;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\source\repos\AspMvcCore\AspMvcCore\AspMvcCore\Views\_ViewImports.cshtml"
using AspMvcCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a330b6c2115310dc16c7999407e8daf9119d3ebe", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"147f2b3206072f351cf8b7b14b73a816406aa11e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Student_Info>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Lenovo\source\repos\AspMvcCore\AspMvcCore\AspMvcCore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 377, true);
            WriteLiteral(@"<style type=""text/css"">
    .bs-example {
        height: 220px;
    }

    .centerlook {
        padding-left: 400px;
        font-weight: bold;
        width: 1000px;
    }

    .error {
        padding-left: 400px;
        font-weight: bold;
        width: 1000px;
        color: red;
    }

    .loginbtn {
        padding-left: 500px;
    }
</style>
");
            EndContext();
#line 27 "C:\Users\Lenovo\source\repos\AspMvcCore\AspMvcCore\AspMvcCore\Views\Home\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(473, 198, true);
            WriteLiteral("<div class=\"bs-example\" style=\"border:2px solid gray;\">\r\n\r\n    <div class=\"form-group centerlook\">\r\n    </div>\r\n    <div class=\"form-group centerlook\">\r\n        <label>Student ID: </label>\r\n        ");
            EndContext();
            BeginContext(672, 41, false);
#line 35 "C:\Users\Lenovo\source\repos\AspMvcCore\AspMvcCore\AspMvcCore\Views\Home\Index.cshtml"
   Write(Html.EditorFor(model => model.Student_ID));

#line default
#line hidden
            EndContext();
            BeginContext(713, 105, true);
            WriteLiteral("*\r\n\r\n    </div>\r\n    <div class=\"form-group centerlook\">\r\n        <label>Student Name: </label>\r\n        ");
            EndContext();
            BeginContext(819, 35, false);
#line 40 "C:\Users\Lenovo\source\repos\AspMvcCore\AspMvcCore\AspMvcCore\Views\Home\Index.cshtml"
   Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(854, 97, true);
            WriteLiteral("*\r\n\r\n    </div>\r\n    <div class=\"form-group centerlook\">\r\n        <label>Branch</label>\r\n        ");
            EndContext();
            BeginContext(952, 37, false);
#line 45 "C:\Users\Lenovo\source\repos\AspMvcCore\AspMvcCore\AspMvcCore\Views\Home\Index.cshtml"
   Write(Html.EditorFor(model => model.Branch));

#line default
#line hidden
            EndContext();
            BeginContext(989, 52, true);
            WriteLiteral(" *\r\n    </div>\r\n    <div class=\"form-group error\">\r\n");
            EndContext();
#line 48 "C:\Users\Lenovo\source\repos\AspMvcCore\AspMvcCore\AspMvcCore\Views\Home\Index.cshtml"
         if (@ViewBag.Success != null)
        {


#line default
#line hidden
            BeginContext(1094, 20, true);
            WriteLiteral("            <label> ");
            EndContext();
            BeginContext(1115, 15, false);
#line 51 "C:\Users\Lenovo\source\repos\AspMvcCore\AspMvcCore\AspMvcCore\Views\Home\Index.cshtml"
               Write(ViewBag.Success);

#line default
#line hidden
            EndContext();
            BeginContext(1130, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
#line 52 "C:\Users\Lenovo\source\repos\AspMvcCore\AspMvcCore\AspMvcCore\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1151, 52, true);
            WriteLiteral("    </div>\r\n\r\n    <div class=\"loginbtn\">\r\n\r\n        ");
            EndContext();
            BeginContext(1203, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8b66f5fefa3242ed854c4776a2eca1bf", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1318, 26, true);
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n</div>\r\n");
            EndContext();
#line 62 "C:\Users\Lenovo\source\repos\AspMvcCore\AspMvcCore\AspMvcCore\Views\Home\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Student_Info> Html { get; private set; }
    }
}
#pragma warning restore 1591

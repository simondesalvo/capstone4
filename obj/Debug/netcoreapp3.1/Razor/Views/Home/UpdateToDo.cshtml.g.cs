#pragma checksum "/Users/simon/Documents/GrandCircus/capstone4/capstone4/Views/Home/UpdateToDo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "154ccf2cfcd70325ab930055e94888e2aabceb08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UpdateToDo), @"mvc.1.0.view", @"/Views/Home/UpdateToDo.cshtml")]
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
#line 1 "/Users/simon/Documents/GrandCircus/capstone4/capstone4/Views/_ViewImports.cshtml"
using capstone4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/simon/Documents/GrandCircus/capstone4/capstone4/Views/_ViewImports.cshtml"
using capstone4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"154ccf2cfcd70325ab930055e94888e2aabceb08", @"/Views/Home/UpdateToDo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"942b765f2a24fd7f19b2abd8c100c76991857e06", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UpdateToDo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("../Home/SaveChanges"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/simon/Documents/GrandCircus/capstone4/capstone4/Views/Home/UpdateToDo.cshtml"
  
    ViewData["Title"] = "Update ToDo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Update ToDo Item</h1>\n");
            WriteLiteral("\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "154ccf2cfcd70325ab930055e94888e2aabceb084094", async() => {
                WriteLiteral("\n    <input type=\"text\" name=\"ToDoId\"");
                BeginWriteAttribute("value", " value=\"", 176, "\"", 197, 1);
#nullable restore
#line 11 "/Users/simon/Documents/GrandCircus/capstone4/capstone4/Views/Home/UpdateToDo.cshtml"
WriteAttributeValue("", 184, Model.ToDoId, 184, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden />\n    <input type=\"text\" name=\"ToDoDesc\"");
                BeginWriteAttribute("value", " value=\"", 247, "\"", 270, 1);
#nullable restore
#line 12 "/Users/simon/Documents/GrandCircus/capstone4/capstone4/Views/Home/UpdateToDo.cshtml"
WriteAttributeValue("", 255, Model.ToDoDesc, 255, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 271, "\"", 300, 1);
#nullable restore
#line 12 "/Users/simon/Documents/GrandCircus/capstone4/capstone4/Views/Home/UpdateToDo.cshtml"
WriteAttributeValue("", 285, Model.ToDoDesc, 285, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n    <input type=\"datetime\" name=\"ToDoDue\"");
                BeginWriteAttribute("value", " value=\"", 346, "\"", 368, 1);
#nullable restore
#line 13 "/Users/simon/Documents/GrandCircus/capstone4/capstone4/Views/Home/UpdateToDo.cshtml"
WriteAttributeValue("", 354, Model.ToDoDue, 354, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 369, "\"", 398, 2);
                WriteAttributeValue("", 383, "=", 383, 1, true);
#nullable restore
#line 13 "/Users/simon/Documents/GrandCircus/capstone4/capstone4/Views/Home/UpdateToDo.cshtml"
WriteAttributeValue("", 384, Model.ToDoDue, 384, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n");
#nullable restore
#line 14 "/Users/simon/Documents/GrandCircus/capstone4/capstone4/Views/Home/UpdateToDo.cshtml"
     if (Model.ToDoComplete == true)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"checkbox\" name=\"ToDoComplete\" value=\"true\" checked />\n        <input type=\"checkbox\" name=\"ToDoComplete\" value=\"false\" hidden />\n");
#nullable restore
#line 18 "/Users/simon/Documents/GrandCircus/capstone4/capstone4/Views/Home/UpdateToDo.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"checkbox\" name=\"ToDoComplete\" value=\"true\" />\n        <input type=\"checkbox\" name=\"ToDoComplete\" value=\"false\" hidden />\n");
#nullable restore
#line 23 "/Users/simon/Documents/GrandCircus/capstone4/capstone4/Views/Home/UpdateToDo.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <input type=\"submit\" value=\"Save Changes!\" />\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoList> Html { get; private set; }
    }
}
#pragma warning restore 1591

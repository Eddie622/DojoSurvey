#pragma checksum "C:\Users\Admin\Desktop\CodingDojo\C#Stack\MVCI\DojoSurvey\Views\Survey\results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbbb7c0304266f5107e70dab09acceab8ee5d103"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Survey_results), @"mvc.1.0.view", @"/Views/Survey/results.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Survey/results.cshtml", typeof(AspNetCore.Views_Survey_results))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbbb7c0304266f5107e70dab09acceab8ee5d103", @"/Views/Survey/results.cshtml")]
    public class Views_Survey_results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DojoSurvey.Models.SurvMod>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(71, 147, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbbb7c0304266f5107e70dab09acceab8ee5d1032954", async() => {
                BeginContext(77, 134, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Results</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(218, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(220, 184, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbbb7c0304266f5107e70dab09acceab8ee5d1034280", async() => {
                BeginContext(226, 42, true);
                WriteLiteral("\r\n    <h1>Results Page</h1>\r\n    <p>Name: ");
                EndContext();
                BeginContext(269, 10, false);
#line 12 "C:\Users\Admin\Desktop\CodingDojo\C#Stack\MVCI\DojoSurvey\Views\Survey\results.cshtml"
        Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(279, 23, true);
                WriteLiteral("</p>\r\n    <p>Location: ");
                EndContext();
                BeginContext(303, 14, false);
#line 13 "C:\Users\Admin\Desktop\CodingDojo\C#Stack\MVCI\DojoSurvey\Views\Survey\results.cshtml"
            Write(Model.Location);

#line default
#line hidden
                EndContext();
                BeginContext(317, 23, true);
                WriteLiteral("</p>\r\n    <p>Language: ");
                EndContext();
                BeginContext(341, 14, false);
#line 14 "C:\Users\Admin\Desktop\CodingDojo\C#Stack\MVCI\DojoSurvey\Views\Survey\results.cshtml"
            Write(Model.Language);

#line default
#line hidden
                EndContext();
                BeginContext(355, 22, true);
                WriteLiteral("</p>\r\n    <p>Comment: ");
                EndContext();
                BeginContext(378, 13, false);
#line 15 "C:\Users\Admin\Desktop\CodingDojo\C#Stack\MVCI\DojoSurvey\Views\Survey\results.cshtml"
           Write(Model.Comment);

#line default
#line hidden
                EndContext();
                BeginContext(391, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(404, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DojoSurvey.Models.SurvMod> Html { get; private set; }
    }
}
#pragma warning restore 1591

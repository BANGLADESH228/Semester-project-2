#pragma checksum "C:\Users\BANGLADESH\Desktop\Semester-project-2\Back\SemestreWork\Pages\Shared\_UsersList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fd5135fef646854b202b867069121bf3b610f50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SemestreWork.Pages.Shared.Pages_Shared__UsersList), @"mvc.1.0.view", @"/Pages/Shared/_UsersList.cshtml")]
namespace SemestreWork.Pages.Shared
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
#line 1 "C:\Users\BANGLADESH\Desktop\Semester-project-2\Back\SemestreWork\Pages\_ViewImports.cshtml"
using SemestreWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\BANGLADESH\Desktop\Semester-project-2\Back\SemestreWork\Pages\Shared\_UsersList.cshtml"
using SemestreWork.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fd5135fef646854b202b867069121bf3b610f50", @"/Pages/Shared/_UsersList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6e147ffc024147d0beca7da6bbbf4341cc41784", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__UsersList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RegisterModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/noavatar.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\BANGLADESH\Desktop\Semester-project-2\Back\SemestreWork\Pages\Shared\_UsersList.cshtml"
     foreach (var Users in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"timeline-header\">\n        <span class=\"userimage\">\n");
#nullable restore
#line 8 "C:\Users\BANGLADESH\Desktop\Semester-project-2\Back\SemestreWork\Pages\Shared\_UsersList.cshtml"
             if (@Users.Image == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3fd5135fef646854b202b867069121bf3b610f504156", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 11 "C:\Users\BANGLADESH\Desktop\Semester-project-2\Back\SemestreWork\Pages\Shared\_UsersList.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=\"", 328, "\"", 346, 1);
#nullable restore
#line 14 "C:\Users\BANGLADESH\Desktop\Semester-project-2\Back\SemestreWork\Pages\Shared\_UsersList.cshtml"
WriteAttributeValue("", 334, Users.Image, 334, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 15 "C:\Users\BANGLADESH\Desktop\Semester-project-2\Back\SemestreWork\Pages\Shared\_UsersList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </span>\n        <span class=\"username\">\n            <a");
            BeginWriteAttribute("href", " href=\"", 425, "\"", 450, 2);
            WriteAttributeValue("", 432, "/Profile/", 432, 9, true);
#nullable restore
#line 18 "C:\Users\BANGLADESH\Desktop\Semester-project-2\Back\SemestreWork\Pages\Shared\_UsersList.cshtml"
WriteAttributeValue("", 441, Users.Id, 441, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "C:\Users\BANGLADESH\Desktop\Semester-project-2\Back\SemestreWork\Pages\Shared\_UsersList.cshtml"
                                    Write(Users.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> <!-- Ну тут никнейм (псевдоним) от айдишника -->\n            <small></small>\n        </span>\n    </div>\n");
#nullable restore
#line 22 "C:\Users\BANGLADESH\Desktop\Semester-project-2\Back\SemestreWork\Pages\Shared\_UsersList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RegisterModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

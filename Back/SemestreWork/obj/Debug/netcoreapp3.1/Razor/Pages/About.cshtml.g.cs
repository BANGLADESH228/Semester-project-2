#pragma checksum "C:\Users\BANGLADESH\Desktop\Semester-project-2\Back\SemestreWork\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d444a3e456b835079bba16d5615a297dade693b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SemestreWork.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
namespace SemestreWork.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d444a3e456b835079bba16d5615a297dade693b2", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6e147ffc024147d0beca7da6bbbf4341cc41784", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\BANGLADESH\Desktop\Semester-project-2\Back\SemestreWork\Pages\About.cshtml"
   ViewData["Title"] = "О нас"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main align-self-center"">
    <div class=""container"">
        <div class=""row"">

            <div class=""col-2""></div>

            <div class=""col-8"" style=""margin-top:30px;"">
                <h2 align=""middle"">О проекте</h2>
                <hr>
                <div class=""card"">
                    <img src=""http://evolution-ru.ru/wp-content/uploads/2016/08/SHkola-Almetevsk3.jpg"" alt=""DU"" width=""100%"">
                    <div class=""card-body"">
                        <h4>Что такое CampusControl?</h4>
                        <p>
                            Это место, в котором могут объединится студенты из разных общежитий города Казань.
                            Здесь вы можете оставить отзывы об общежитиях, пообщаться в чатах, завести друзей и получать самую актуальную новостную информацию.

                        </p>

                        <h4>Общежития</h4>
                        <p>
                            На домашней странице нашего сайта вы можете выбрать одну из нескольких ");
            WriteLiteral(@"общажных домов и узнать информацию о преимуществах проживания в данном общежитии.
                        </p>

                        <h4>Мероприятия</h4>
                        <p>
                            Раздел мероприятий содержит всю самую актуальную информацию о мероприятиях, проводимых в общежитии.
                        </p>

                        <h4>Чат</h4>
                        <p>
                            В данном разделе вы можете познакомиться с людьми, непосредственно проживающими в выбранном общежитии.
                        </p>
                    </div>
                </div>
            </div>

            <div class=""col-2""></div>

        </div>
    </div>
</main>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SemestreWork.Pages.AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SemestreWork.Pages.AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SemestreWork.Pages.AboutModel>)PageContext?.ViewData;
        public SemestreWork.Pages.AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

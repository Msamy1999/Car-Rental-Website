#pragma checksum "D:\z Backup\repos\Car Website\Car Website\Views\Car\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "767fa03a6b5e653ee5d660ff9053fcc367f8267f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Contact), @"mvc.1.0.view", @"/Views/Car/Contact.cshtml")]
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
#line 1 "D:\z Backup\repos\Car Website\Car Website\Views\_ViewImports.cshtml"
using Car_Website;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\z Backup\repos\Car Website\Car Website\Views\_ViewImports.cshtml"
using Car_Website.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"767fa03a6b5e653ee5d660ff9053fcc367f8267f", @"/Views/Car/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf6f351f08b125939b10d197a0853087ec26b6a5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Car_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\z Backup\repos\Car Website\Car Website\Views\Car\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""hero inner-page"" style=""background-image: url('/images/hero_1_a.jpg');"">

    <div class=""container"">
        <div class=""row align-items-end "">
            <div class=""col-lg-5"">

                <div class=""intro"">
                    <h1><strong>About</strong></h1>
                    <div class=""custom-breadcrumbs""><a href=""index.html"">Home</a> <span class=""mx-2"">/</span> <strong>About</strong></div>
                </div>

            </div>
        </div>
    </div>
</div>



<div class=""site-section bg-light"" id=""contact-section"">
    <div class=""container"">
        <div class=""row justify-content-center text-center"">
            <div class=""col-7 text-center mb-5"">
                <h2>Contact Us Or Use This Form To Rent A Car</h2>
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Nemo assumenda, dolorum necessitatibus eius earum voluptates sed!</p>
            </div>
        </div>
        <div class=""row"">
            <div class=");
            WriteLiteral("\"col-lg-8 mb-5\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "767fa03a6b5e653ee5d660ff9053fcc367f8267f5207", async() => {
                WriteLiteral(@"
                    <div class=""form-group row"">
                        <div class=""col-md-6 mb-4 mb-lg-0"">
                            <input type=""text"" class=""form-control"" placeholder=""First name"">
                        </div>
                        <div class=""col-md-6"">
                            <input type=""text"" class=""form-control"" placeholder=""First name"">
                        </div>
                    </div>

                    <div class=""form-group row"">
                        <div class=""col-md-12"">
                            <input type=""text"" class=""form-control"" placeholder=""Email address"">
                        </div>
                    </div>

                    <div class=""form-group row"">
                        <div class=""col-md-12"">
                            <textarea");
                BeginWriteAttribute("name", " name=\"", 1974, "\"", 1981, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1982, "\"", 1987, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" placeholder=""Write your message."" cols=""30"" rows=""10""></textarea>
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <div class=""col-md-6 mr-auto"">
                            <input type=""submit"" class=""btn btn-block btn-primary text-white py-3 px-5"" value=""Send Message"">
                        </div>
                    </div>
                ");
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
            WriteLiteral(@"
            </div>
            <div class=""col-lg-4 ml-auto"">
                <div class=""bg-white p-3 p-md-5"">
                    <h3 class=""text-black mb-4"">Contact Info</h3>
                    <ul class=""list-unstyled footer-link"">
                        <li class=""d-block mb-3"">
                            <span class=""d-block text-black"">Address:</span>
                            <span>34 Street Name, City Name Here, United States</span>
                        </li>
                        <li class=""d-block mb-3""><span class=""d-block text-black"">Phone:</span><span>+1 242 4942 290</span></li>
                        <li class=""d-block mb-3""><span class=""d-block text-black"">Email:</span><span>info@yourdomain.com</span></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>


");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
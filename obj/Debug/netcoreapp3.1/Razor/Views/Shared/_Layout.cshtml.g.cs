#pragma checksum "/home/mhm/Project/tbsmobtakeran.ir/tbs/Views/Shared/_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7db34463cdf6f84b3ac6330587888896a71b7383"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "/home/mhm/Project/tbsmobtakeran.ir/tbs/Views/_ViewImports.cshtml"
using tbs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/mhm/Project/tbsmobtakeran.ir/tbs/Views/_ViewImports.cshtml"
using tbs.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7db34463cdf6f84b3ac6330587888896a71b7383", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6763f764b418ee6d8e9300dacfe5f9399ceb74c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"fa_IR\">\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7db34463cdf6f84b3ac6330587888896a71b73833434", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>مبتکران : ");
#nullable restore
#line 8 "/home/mhm/Project/tbsmobtakeran.ir/tbs/Views/Shared/_Layout.cshtml"
                Write(ViewData["ViewDataName"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <!-- Favicon -->
    <link rel=""shortcut icon"" type=""/image/icon"" href=""assets/images/favicon.ico""/>
    <!-- Font Awesome -->
    <link href=""/assets/css/font-awesome.css"" rel=""stylesheet"">
    <!-- Bootstrap -->
    <link href=""/assets/css/bootstrap.css"" rel=""stylesheet"">    
    <!-- Slick slider -->
    <link rel=""stylesheet"" type=""text/css"" href=""/assets/css/slick.css""/> 
    <!-- Fancybox slider -->
    <link rel=""stylesheet"" href=""/assets/css/jquery.fancybox.css"" type=""text/css"" media=""screen"" /> 
    <!-- Animate css -->
    <link rel=""stylesheet"" type=""text/css"" href=""/assets/css/animate.css""/> 
    <!-- Progress bar  -->
    <link rel=""stylesheet"" type=""text/css"" href=""/assets/css/bootstrap-progressbar-3.3.4.css""/> 
     <!-- Theme color -->
    <link id=""switcher"" href=""/assets/css/theme-color/default-theme.css"" rel=""stylesheet"">

    <!-- Main Style -->
    <link href=""/style.css"" rel=""stylesheet"">

    <!-- Fonts -->
    <link rel=""/stylesheet"" type=""text/css"" h");
                WriteLiteral(@"ref=""/font.css""/> 
	
    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src=""https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js""></script>
      <script src=""https://oss.maxcdn.com/respond/1.4.2/respond.min.js""></script>
    <![endif]-->
  ");
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
            WriteLiteral("\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7db34463cdf6f84b3ac6330587888896a71b73836450", async() => {
                WriteLiteral(@"
  
  <!-- BEGAIN PRELOADER -->
  <div id=""preloader"">
    <div id=""status"">&nbsp;</div>
  </div>
  <!-- END PRELOADER -->

  <!-- SCROLL TOP BUTTON -->
  <a class=""scrollToTop"" href=""#""><i class=""fa fa-angle-up""></i></a>
  <!-- END SCROLL TOP BUTTON -->

  <!-- Start header -->
  <header id=""header"">
    
    <!-- header bottom -->
    <div class=""header-bottom"">
      <div class=""container"">
        <div class=""row"">
          <div class=""col-md-6 col-sm-6 col-xs-6"">
            <div class=""header-contact"">
              <ul>
                <li>
                  <div class=""phone"">
                    <i class=""fa fa-phone""></i>
                    987132331389
                  </div>
                </li>
                <li>
                  <div class=""mail"">
                    <i class=""fa fa-envelope""></i>
                    info@tbsmobtakeran.ir
                  </div>
                </li>
              </ul>
            </div>
          </div>
          <d");
                WriteLiteral("iv class=\"col-md-6 col-sm-6 col-xs-6\">\r\n            ");
#nullable restore
#line 77 "/home/mhm/Project/tbsmobtakeran.ir/tbs/Views/Shared/_Layout.cshtml"
       Write(Html.Partial("_LoginPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
          </div>
        </div>
      </div>
    </div>
  </header>
  <!-- End header -->
  
  <!-- Start login modal window -->
  <div aria-hidden=""false"" role=""dialog"" tabindex=""-1"" id=""login-form"" class=""modal leread-modal fade in"">
    <div class=""modal-dialog"">
      <!-- Start login section -->
      <div id=""login-content"" class=""modal-content"">
        <div class=""modal-header"">
          <button aria-label=""Close"" data-dismiss=""modal"" class=""close"" type=""button""><span aria-hidden=""true"">×</span></button>
          <h4 class=""modal-title""><i class=""fa fa-unlock-alt""></i>ورود</h4>
        </div>
        <div class=""modal-body"">
          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7db34463cdf6f84b3ac6330587888896a71b73838795", async() => {
                    WriteLiteral(@"
            <div class=""form-group"">
              <input type=""text"" placeholder=""نام کاربری"" class=""form-control"">
            </div>
            <div class=""form-group"">
              <input type=""password"" placeholder=""رمز عبور"" class=""form-control"">
            </div>
             <div class=""loginbox"">
              <label><input type=""checkbox""><span>بخاطر بسپار</span></label>
              <button class=""btn signin-btn"" type=""button"">وارد شو</button>
            </div>                    
          ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </div>
        <div class=""modal-footer footer-box"">
          <a href=""#"">رمز عبور را فراموش کردید؟</a>
          <span>حساب ندارید؟ <a id=""signup-btn"" href=""#"">عضو شوید.</a></span>            
        </div>
      </div>
      <!-- Start signup section -->
      <div id=""signup-content"" class=""modal-content"">
        <div class=""modal-header"">
          <button aria-label=""Close"" data-dismiss=""modal"" class=""close"" type=""button""><span aria-hidden=""true"">×</span></button>
          <h4 class=""modal-title""><i class=""fa fa-lock""></i>عضویت</h4>
        </div>
        <div class=""modal-body"">
          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7db34463cdf6f84b3ac6330587888896a71b738311275", async() => {
                    WriteLiteral(@"
            <div class=""form-group"">
              <input placeholder=""نام"" class=""form-control"">
            </div>
            <div class=""form-group"">
              <input placeholder=""نام کاربری"" class=""form-control"">
            </div>
            <div class=""form-group"">
              <input placeholder=""ایمیل"" class=""form-control"">
            </div>
            <div class=""form-group"">
              <input type=""password"" placeholder=""رمز عبور"" class=""form-control"">
            </div>
            <div class=""signupbox"">
              <span>حساب دارید؟ <a id=""login-btn"" href=""#"">وارد شوید.</a></span>
            </div>
            <div class=""loginbox"">
              <label><input type=""checkbox""><span>بخاطر بسپار</span><i class=""fa""></i></label>
              <button class=""btn signin-btn"" type=""button"">عضویت</button>
            </div>
          ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </div>
      </div>
    </div>
  </div>
  <!-- End login modal window -->

  <!-- BEGIN MENU -->
  <section id=""menu-area"">      
    <nav class=""navbar navbar-default"" role=""navigation"">  
      <div class=""container"">
        <div class=""navbar-header"">
          <!-- FOR MOBILE VIEW COLLAPSED BUTTON -->
          <button type=""button"" class=""navbar-toggle collapsed"" data-toggle=""collapse"" data-target=""#navbar"" aria-expanded=""false"" aria-controls=""navbar"">
            <span class=""sr-only"">تغییر وضعیت</span>
            <span class=""icon-bar""></span>
            <span class=""icon-bar""></span>
            <span class=""icon-bar""></span>
          </button>
          <!-- LOGO -->              
          <!-- TEXT BASED LOGO -->
          <a class=""navbar-brand"" href=""/"">توسعه بهینه سازی مبتکران</a>              
          <!-- IMG BASED LOGO  -->
           <!-- <a class=""navbar-brand"" href=""index.html""><img src=""assets/images/logo.png"" alt=""logo""></a> -->
        </div>
    ");
                WriteLiteral(@"    <div id=""navbar"" class=""navbar-collapse collapse"">
          <ul id=""top-menu"" class=""nav navbar-nav navbar-right main-nav"">
            <li class=""active""><a href=""/"">خانه</a></li>
            <li><a href=""#service"">خدمات ما</a></li>
            <li><a href="".wow"">خبرنامه</a></li>
          </ul>                     
        </div><!--/.nav-collapse -->
       
      </div>     
    </nav>
  </section>
  <!-- END MENU --> 
    <div class=""container"">
        <main role=""main"" class=""pb-3"">
            ");
#nullable restore
#line 180 "/home/mhm/Project/tbsmobtakeran.ir/tbs/Views/Shared/_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </main>
    </div>

     <!-- Start footer -->
  <footer id=""footer"">
    <div class=""container"">
      <div class=""row"">
        <div class=""col-md-6 col-sm-6"">
          <div class=""footer-left"">
          </div>
        </div>
        <div class=""col-md-6 col-sm-6"">
          <div class=""footer-right"">
            <a href=""index.html""><i class=""fa fa-facebook""></i></a>
            <a href=""#""><i class=""fa fa-twitter""></i></a>
            <a href=""#""><i class=""fa fa-google-plus""></i></a>
            <a href=""#""><i class=""fa fa-linkedin""></i></a>
            <a href=""#""><i class=""fa fa-pinterest""></i></a>
            
          </div>
        </div>
      </div>
    </div>
  </footer>
  <!-- End footer -->

  <!-- jQuery library -->
  <script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js""></script>    
  <!-- Include all compiled plugins (below), or include individual files as needed -->
  <!-- Bootstrap -->
  <script src=""/assets/js/bootstrap.");
                WriteLiteral(@"js""></script>
  <!-- Slick Slider -->
  <script type=""text/javascript"" src=""/assets/js/slick.js""></script>    
  <!-- mixit slider -->
  <script type=""text/javascript"" src=""/assets/js/jquery.mixitup.js""></script>
  <!-- Add fancyBox -->        
  <script type=""text/javascript"" src=""/assets/js/jquery.fancybox.pack.js""></script>
 <!-- counter -->
  <script src=""/assets/js/waypoints.js""></script>
  <script src=""/assets/js/jquery.counterup.js""></script>
  <!-- Wow animation -->
  <script type=""text/javascript"" src=""/assets/js/wow.js""></script> 
  <!-- progress bar   -->
  <script type=""text/javascript"" src=""/assets/js/bootstrap-progressbar.js""></script>  
  
 
  <!-- Custom js -->
  <script type=""text/javascript"" src=""/assets/js/custom.js""></script>
  ");
#nullable restore
#line 229 "/home/mhm/Project/tbsmobtakeran.ir/tbs/Views/Shared/_Layout.cshtml"
Write(RenderSection("scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n  \r\n  ");
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
            WriteLiteral("\r\n</html>\r\n");
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

#pragma checksum "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "add3ac259714101e0714d4f21827fdd0a71689ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"add3ac259714101e0714d4f21827fdd0a71689ce", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- main wrapper start -->
<main>
    <!-- hero slider section start -->
    <section class=""hero-slider"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""hero-slider-active slick-arrow-style slick-arrow-style_hero slick-dot-style"">
                        <!-- single slider item start -->


");
#nullable restore
#line 18 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"
                         foreach (var slide in Model.Slides)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"hero-single-slide\">\r\n                                <div class=\"hero-slider-item bg-img\"\r\n                                     data-bg=\"assets/img/");
#nullable restore
#line 22 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"
                                                    Write(slide.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                    <div class=\"hero-slider-content slide-1\">\r\n                                        <h5 class=\"slide-subtitle\">");
#nullable restore
#line 24 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"
                                                              Write(slide.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        <h2 class=\"slide-title\">");
#nullable restore
#line 25 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"
                                                           Write(slide.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                        <p class=\"slide-desc\">\r\n                                            ");
#nullable restore
#line 27 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"
                                       Write(slide.ISummary);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </p>
                                        <a href=""shop.html"" class=""btn btn-hero"">SHOP NOW</a>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 33 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- hero slider section end -->
    <!-- service features start -->
    <section class=""service-policy-area"">
        <div class=""container"">
            <div class=""row"">

");
#nullable restore
#line 46 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"
                 foreach (var future in Model.Futures)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- single policy item start -->\r\n                    <div class=\"col-lg-4\">\r\n                        <div class=\"service-policy-item mt-30 bg-1\">\r\n                            <div class=\"policy-icon\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1991, "\"", 2020, 2);
            WriteAttributeValue("", 1997, "assets/img/", 1997, 11, true);
#nullable restore
#line 51 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"
WriteAttributeValue("", 2008, future.Logo, 2008, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"policy icon\" />\r\n                            </div>\r\n                            <div class=\"policy-content\">\r\n                                <h5 class=\"policy-title\">");
#nullable restore
#line 54 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"
                                                    Write(future.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p class=\"policy-desc\">");
#nullable restore
#line 55 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"
                                                  Write(future.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <!-- single policy item start -->\r\n");
#nullable restore
#line 60 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </section>
    <!-- service features end -->
    <!-- our product area start -->
    <section class=""our-product section-padding"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""section-title text-center"">
                        <h2 class=""title"">Our Product</h2>
                        <p class=""sub-title"">
                            Lorem ipsum dolor sit amet consectetur adipisicing
                        </p>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""product-carousel-4 mbn-50 slick-row-15 slick-arrow-style"">
                        <!-- product single item start -->

");
#nullable restore
#line 84 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"
                         foreach (var product in Model.Products)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"product-item mb-50\">\r\n                                <div class=\"product-thumb\">\r\n                                    <a href=\"product-details.html\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "add3ac259714101e0714d4f21827fdd0a71689ce9738", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3652, "~/assets/img/", 3652, 13, true);
#nullable restore
#line 89 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3665, product.Image, 3665, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </a>
                                </div>
                                <div class=""product-content"">
                                    <h5 class=""product-name"">
                                        <a href=""product-details.html"">");
#nullable restore
#line 94 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"
                                                                  Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </h5>\r\n                                    <div class=\"price-box\">\r\n                                        <span class=\"price-regular\">$");
#nullable restore
#line 97 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"
                                                                Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                      
                                    </div>
                                    <div class=""product-action-link"">
                                        <a href=""#"" data-toggle=""tooltip"" title=""Wishlist"">
                                            <i class=""ion-android-favorite-outline""></i>
                                        </a>
                                        <a href=""#"" data-toggle=""tooltip"" title=""Add To Cart"">
                                            <i class=""ion-bag""></i>
                                        </a>
                                        <a href=""#"" data-toggle=""modal"" data-target=""#quick_view"">
                                            <span data-toggle=""tooltip"" title=""Quick View"">
                                                <i class=""ion-ios-eye-outline""></i>
                                            </span>
                                        </a>
                                    </div>");
            WriteLiteral("\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 115 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- our product area end -->
    <!-- banner statistic area start -->
    <div class=""banner-statistics"">
        <div class=""container"">
            <div class=""row no-gutters mtn-30"">
                <div class=""col-md-6"">
                    <div class=""img-container mt-30"">
                        <a href=""product-details.html"">
                            <img src=""assets/img/banner/banner-1.jpg""
                                 alt=""banner-image"" />
                        </a>
                        <div class=""banner-text"">
                            <h5 class=""banner-subtitle"">sports shoes</h5>
                            <h3 class=""banner-title"">20% Off<br />For Sports men</h3>
                        </div>
                    </div>
                </div>
                <div class=""col-md-6"">
                    <div class=""img-container mt-30"">
                     ");
            WriteLiteral(@"   <a href=""product-details.html"">
                            <img src=""assets/img/banner/banner-2.jpg""
                                 alt=""banner-image"" />
                        </a>
                        <div class=""banner-text"">
                            <h5 class=""banner-subtitle"">sports shoes</h5>
                            <h3 class=""banner-title"">20% Off<br />For Sports men</h3>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- banner statistic area end -->
    <!-- new products area start -->
    <section class=""top-seller-area section-padding"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""section-title text-center"">
                        <h2 class=""title"">New Products</h2>
                        <p class=""sub-title"">
                            Lorem ipsum dolor sit amet consectetur adipisicing
  ");
            WriteLiteral(@"                      </p>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-xl-4 col-lg-5 col-md-5"">
                    <div class=""product-banner"">
                        <a href=""#"">
                            <img src=""assets/img/banner/banner-3.jpg""
                                 alt=""product banner"" />
                        </a>
                    </div>
                </div>
                <div class=""col-xl-8 col-lg-7 col-md-7"">
                    <div class=""top-seller-carousel slick-row-15 mtn-30"">
                        <!-- product item start -->

");
#nullable restore
#line 182 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"
                         foreach (var newproduct in Model.NewProducts)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""slide-item"">
                                <div class=""pro-item-small mt-30"">
                                    <div class=""product-thumb"">
                                        <a href=""product-details.html"">
                                            <img");
            BeginWriteAttribute("src", " src=\"", 8408, "\"", 8442, 2);
            WriteAttributeValue("", 8414, "assets/img/", 8414, 11, true);
#nullable restore
#line 187 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"
WriteAttributeValue("", 8425, newproduct.Image, 8425, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 8443, "\"", 8449, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                        </a>
                                    </div>
                                    <div class=""pro-small-content"">
                                        <h6 class=""product-name"">
                                            <a href=""product-details.html"">");
#nullable restore
#line 192 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"
                                                                      Write(newproduct.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </h6>\r\n                                        <div class=\"price-box\">\r\n                                            <span class=\"price-regular\">$");
#nullable restore
#line 195 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"
                                                                    Write(newproduct.NewPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            <span class=\"price-old\"><del>$");
#nullable restore
#line 196 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"
                                                                     Write(newproduct.OldPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</del></span>
                                        </div>
                                        <div class=""ratings"">
                                            <span><i class=""ion-android-star""></i></span>
                                            <span><i class=""ion-android-star""></i></span>
                                            <span><i class=""ion-android-star""></i></span>
                                            <span><i class=""ion-android-star""></i></span>
                                            <span><i class=""ion-android-star""></i></span>
                                        </div>
                                        <div class=""product-link-2"">
                                            <a href=""#"" data-toggle=""tooltip"" title=""Wishlist"">
                                                <i class=""ion-android-favorite-outline""></i>
                                            </a>
                                            <a href=""#"" data-toggle=""tooltip"" title=");
            WriteLiteral(@"""Add To Cart"">
                                                <i class=""ion-bag""></i>
                                            </a>
                                            <a href=""#""
                                               data-toggle=""modal""
                                               data-target=""#quick_view"">
                                                <span data-toggle=""tooltip"" title=""Quick View"">
                                                    <i class=""ion-ios-eye-outline""></i>
                                                </span>
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 223 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <!-- product item start -->
                        <!-- product item start -->

                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- new products area end -->
    <!-- latest blog area start -->
    <section class=""latest-blog-area"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""section-title text-center"">
                        <h2 class=""title"">our blog</h2>
                        <p class=""sub-title"">
                            Lorem ipsum dolor sit amet consectetur adipisicing
                        </p>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""blog-carousel-active slick-row-15"">

");
#nullable restore
#line 251 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"
                         foreach (var blog in Model.OurBlogs)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <!-- blog single item start -->
                            <div class=""blog-post-item"">
                                <div class=""blog-thumb"">
                                    <a href=""blog-details.html"">
                                        <img");
            BeginWriteAttribute("src", " src=\"", 12231, "\"", 12259, 2);
            WriteAttributeValue("", 12237, "assets/img/", 12237, 11, true);
#nullable restore
#line 257 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"
WriteAttributeValue("", 12248, blog.Image, 12248, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""blog thumb"" />
                                    </a>
                                </div>
                                <div class=""blog-content"">
                                    <h5 class=""blog-title"">
                                        <a href=""blog-details.html"">
                                          ");
#nullable restore
#line 263 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"
                                     Write(blog.Summary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </h5>\r\n                                    <ul class=\"blog-meta\">\r\n                                        <li><span>By: </span>");
#nullable restore
#line 266 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"
                                                        Write(blog.SharedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        <li><span>On: </span>");
#nullable restore
#line 267 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"
                                                        Write(blog.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                    </ul>
                                    <a href=""blog-details.html"" class=""read-more"">Read More...</a>
                                </div>
                            </div>
                            <!-- blog single item start -->
                            <!-- blog single item start -->
");
#nullable restore
#line 274 "C:\Users\mac\Desktop\Juan-project\JuanProject\Juan\Juan\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- latest blog area end -->
    <!-- brand area start -->
    <div class=""brand-area section-padding"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""brand-active-carousel"">
                        <div class=""brand-item"">
                            <a href=""#"">
                                <img src=""assets/img/brand/br1.png"" alt=""brand image"" />
                            </a>
                        </div>
                        <div class=""brand-item"">
                            <a href=""#"">
                                <img src=""assets/img/brand/br2.png"" alt=""brand image"" />
                            </a>
                        </div>
                        <div class=""brand-item"">
                            <a href=""#"">
                                <img src=""assets/img/brand/br");
            WriteLiteral(@"3.png"" alt=""brand image"" />
                            </a>
                        </div>
                        <div class=""brand-item"">
                            <a href=""#"">
                                <img src=""assets/img/brand/br4.png"" alt=""brand image"" />
                            </a>
                        </div>
                        <div class=""brand-item"">
                            <a href=""#"">
                                <img src=""assets/img/brand/br5.png"" alt=""brand image"" />
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- brand area end -->
</main>
<!-- main wrapper end -->
<!-- Quick view modal start -->
<div class=""modal"" id=""quick_view"">
    <div class=""modal-dialog modal-lg modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-d");
            WriteLiteral(@"ismiss=""modal"">
                    &times;
                </button>
            </div>
            <div class=""modal-body"">
                <!-- product details inner end -->
                <div class=""product-details-inner"">
                    <div class=""row"">
                        <div class=""col-lg-5"">
                            <div class=""product-large-slider mb-20"">
                                <div class=""pro-large-img img-zoom"">
                                    <img src=""assets/img/product/product-details-img1.jpg""
                                         alt=""product thumb"" />
                                </div>
                                <div class=""pro-large-img img-zoom"">
                                    <img src=""assets/img/product/product-details-img2.jpg""
                                         alt=""product thumb"" />
                                </div>
                                <div class=""pro-large-img img-zoom"">
                           ");
            WriteLiteral(@"         <img src=""assets/img/product/product-details-img3.jpg""
                                         alt=""product thumb"" />
                                </div>
                                <div class=""pro-large-img img-zoom"">
                                    <img src=""assets/img/product/product-details-img4.jpg""
                                         alt=""product thumb"" />
                                </div>
                            </div>
                            <div class=""pro-nav slick-row-5"">
                                <div class=""pro-nav-thumb"">
                                    <img src=""assets/img/product/product-details-img1.jpg""");
            BeginWriteAttribute("alt", "\r\n                                         alt=\"", 17006, "\"", 17054, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                </div>\r\n                                <div class=\"pro-nav-thumb\">\r\n                                    <img src=\"assets/img/product/product-details-img2.jpg\"");
            BeginWriteAttribute("alt", "\r\n                                         alt=\"", 17251, "\"", 17299, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                </div>\r\n                                <div class=\"pro-nav-thumb\">\r\n                                    <img src=\"assets/img/product/product-details-img3.jpg\"");
            BeginWriteAttribute("alt", "\r\n                                         alt=\"", 17496, "\"", 17544, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                </div>\r\n                                <div class=\"pro-nav-thumb\">\r\n                                    <img src=\"assets/img/product/product-details-img4.jpg\"");
            BeginWriteAttribute("alt", "\r\n                                         alt=\"", 17741, "\"", 17789, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-7"">
                            <div class=""product-details-des"">
                                <h3 class=""pro-det-title"">Primitive Mens Premium Shoes</h3>
                                <div class=""pro-review"">
                                    <span><a href=""#"">1 Review(s)</a></span>
                                </div>
                                <div class=""price-box"">
                                    <span class=""regular-price"">$70.00</span>
                                    <span class=""old-price""><del>$80.00</del></span>
                                </div>
                                <p>
                                    Lorem ipsum dolor sit amet, consetetur sadipscing elitr,
                                    sed diam nonumy eirmod tempor invidunt ut labore et dolore
                                    magna ");
            WriteLiteral(@"aliquyam erat, sed diam voluptua.
                                </p>
                                <div class=""quantity-cart-box d-flex align-items-center mb-20"">
                                    <div class=""quantity"">
                                        <div class=""pro-qty"">
                                            <input type=""text"" value=""1"" />
                                        </div>
                                    </div>
                                    <a href=""cart.html"" class=""btn btn-default"">Add To Cart</a>
                                </div>
                                <div class=""availability mb-20"">
                                    <h5 class=""cat-title"">Availability:</h5>
                                    <span>In Stock</span>
                                </div>
                                <div class=""share-icon"">
                                    <h5 class=""cat-title"">Share:</h5>
                                    <a href=""#""><i cl");
            WriteLiteral(@"ass=""fa fa-facebook""></i></a>
                                    <a href=""#""><i class=""fa fa-twitter""></i></a>
                                    <a href=""#""><i class=""fa fa-pinterest""></i></a>
                                    <a href=""#""><i class=""fa fa-google-plus""></i></a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- product details inner end -->
            </div>
        </div>
    </div>
</div>
<!-- Quick view modal end -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

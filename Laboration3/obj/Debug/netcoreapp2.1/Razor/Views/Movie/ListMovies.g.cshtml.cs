#pragma checksum "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "124569bd3bef9987dd28145e4b822409b8c959fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_ListMovies), @"mvc.1.0.view", @"/Views/Movie/ListMovies.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/ListMovies.cshtml", typeof(AspNetCore.Views_Movie_ListMovies))]
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
#line 1 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\_ViewImports.cshtml"
using Laboration3;

#line default
#line hidden
#line 2 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\_ViewImports.cshtml"
using Laboration3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"124569bd3bef9987dd28145e4b822409b8c959fe", @"/Views/Movie/ListMovies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19ddee5f10f90f35adeeb029d0519e436d8fdd58", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_ListMovies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Laboration3.Models.MovieDetail>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchMovie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditMovie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteMovie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "InsertMovieForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
  
    ViewData["Title"] = "ListMovies";

#line default
#line hidden
            BeginContext(100, 106, true);
            WriteLiteral("\r\n<h2>Filmer</h2>\r\n\r\n<h3>Sök film</h3>\r\n<div class=\"row\">\r\n    <div class=\"form-group col-md-4\">\r\n        ");
            EndContext();
            BeginContext(206, 325, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86841edd4d4b497db3f1513bc0cc4c09", async() => {
                BeginContext(237, 287, true);
                WriteLiteral(@"
            <div class=""form-group"">
                <input type=""text"" class=""form-control"" id=""Query"" name=""Query"" />
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Sök"" class=""btn btn-default"" />
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(531, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
#line 23 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(579, 84, true);
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n");
            EndContext();
#line 29 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                     if (ViewBag.NameOrder == "Asc")
                    {

#line default
#line hidden
            BeginContext(740, 58, true);
            WriteLiteral("                        <a href=\"ListMovies?sort=NameDes\">");
            EndContext();
            BeginContext(799, 40, false);
#line 31 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(839, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 32 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(917, 55, true);
            WriteLiteral("                        <a href=\"ListMovies?sort=Name\">");
            EndContext();
            BeginContext(973, 40, false);
#line 35 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                                                  Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1013, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 36 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                    }

#line default
#line hidden
            BeginContext(1042, 47, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n");
            EndContext();
#line 40 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                     if (ViewBag.GenreOrder == "Asc")
                    {

#line default
#line hidden
            BeginContext(1167, 59, true);
            WriteLiteral("                        <a href=\"ListMovies?sort=GenreDes\">");
            EndContext();
            BeginContext(1227, 41, false);
#line 42 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                                                      Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(1268, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 43 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1346, 56, true);
            WriteLiteral("                        <a href=\"ListMovies?sort=Genre\">");
            EndContext();
            BeginContext(1403, 41, false);
#line 46 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(1444, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 47 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                    }

#line default
#line hidden
            BeginContext(1473, 45, true);
            WriteLiteral("                </th>\r\n                <th>\r\n");
            EndContext();
#line 50 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                     if (ViewBag.PlaytimeOrder == "Asc")
                    {

#line default
#line hidden
            BeginContext(1599, 62, true);
            WriteLiteral("                        <a href=\"ListMovies?sort=PlaytimeDes\">");
            EndContext();
            BeginContext(1662, 44, false);
#line 52 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                                                         Write(Html.DisplayNameFor(model => model.Playtime));

#line default
#line hidden
            EndContext();
            BeginContext(1706, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 53 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1784, 59, true);
            WriteLiteral("                        <a href=\"ListMovies?sort=Playtime\">");
            EndContext();
            BeginContext(1844, 44, false);
#line 56 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                                                      Write(Html.DisplayNameFor(model => model.Playtime));

#line default
#line hidden
            EndContext();
            BeginContext(1888, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 57 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                    }

#line default
#line hidden
            BeginContext(1917, 45, true);
            WriteLiteral("                </th>\r\n                <th>\r\n");
            EndContext();
#line 60 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                     if (ViewBag.YearOrder == "Asc")
                    {

#line default
#line hidden
            BeginContext(2039, 58, true);
            WriteLiteral("                        <a href=\"ListMovies?sort=YearDes\">");
            EndContext();
            BeginContext(2098, 40, false);
#line 62 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(2138, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 63 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2216, 55, true);
            WriteLiteral("                        <a href=\"ListMovies?sort=Year\">");
            EndContext();
            BeginContext(2272, 40, false);
#line 66 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                                                  Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(2312, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 67 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                    }

#line default
#line hidden
            BeginContext(2341, 45, true);
            WriteLiteral("                </th>\r\n                <th>\r\n");
            EndContext();
#line 70 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                     if (ViewBag.IMDBScoreOrder == "Asc")
                    {

#line default
#line hidden
            BeginContext(2468, 63, true);
            WriteLiteral("                        <a href=\"ListMovies?sort=IMDBScoreDes\">");
            EndContext();
            BeginContext(2532, 45, false);
#line 72 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                                                          Write(Html.DisplayNameFor(model => model.IMDBScore));

#line default
#line hidden
            EndContext();
            BeginContext(2577, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 73 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2655, 60, true);
            WriteLiteral("                        <a href=\"ListMovies?sort=IMDBScore\">");
            EndContext();
            BeginContext(2716, 45, false);
#line 76 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                                                       Write(Html.DisplayNameFor(model => model.IMDBScore));

#line default
#line hidden
            EndContext();
            BeginContext(2761, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 77 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                    }

#line default
#line hidden
            BeginContext(2790, 45, true);
            WriteLiteral("                </th>\r\n                <th>\r\n");
            EndContext();
#line 80 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                     if (ViewBag.DirectorOrder == "Asc")
                    {

#line default
#line hidden
            BeginContext(2916, 62, true);
            WriteLiteral("                        <a href=\"ListMovies?sort=DirectorDes\">");
            EndContext();
            BeginContext(2979, 44, false);
#line 82 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                                                         Write(Html.DisplayNameFor(model => model.Director));

#line default
#line hidden
            EndContext();
            BeginContext(3023, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 83 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3101, 59, true);
            WriteLiteral("                        <a href=\"ListMovies?sort=Director\">");
            EndContext();
            BeginContext(3161, 44, false);
#line 86 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                                                      Write(Html.DisplayNameFor(model => model.Director));

#line default
#line hidden
            EndContext();
            BeginContext(3205, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 87 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                    }

#line default
#line hidden
            BeginContext(3234, 104, true);
            WriteLiteral("                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 93 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(3379, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3440, 39, false);
#line 97 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3479, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3547, 40, false);
#line 100 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
               Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(3587, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3655, 43, false);
#line 103 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
               Write(Html.DisplayFor(modelItem => item.Playtime));

#line default
#line hidden
            EndContext();
            BeginContext(3698, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3766, 39, false);
#line 106 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
               Write(Html.DisplayFor(modelItem => item.Year));

#line default
#line hidden
            EndContext();
            BeginContext(3805, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3873, 44, false);
#line 109 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
               Write(Html.DisplayFor(modelItem => item.IMDBScore));

#line default
#line hidden
            EndContext();
            BeginContext(3917, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3985, 43, false);
#line 112 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
               Write(Html.DisplayFor(modelItem => item.Director));

#line default
#line hidden
            EndContext();
            BeginContext(4028, 87, true);
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-center\">\r\n                    ");
            EndContext();
            BeginContext(4115, 370, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf06e19e19de4dba8fa8b900ca78cdac", async() => {
                BeginContext(4160, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(4186, 95, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50654a3d155f42fbbf6ea5103adad0cf", async() => {
                    BeginContext(4272, 5, true);
                    WriteLiteral("Ändra");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-movieId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 116 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                                                                                        WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-movieId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4281, 61, true);
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"movieId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4342, "\"", 4358, 1);
#line 117 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
WriteAttributeValue("", 4350, item.Id, 4350, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4359, 119, true);
                WriteLiteral(" />\r\n                        <button type=\"submit\" class=\"btn btn-danger btn-sm\">Ta bort</button>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4485, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 122 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
    }

#line default
#line hidden
            BeginContext(4536, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 125 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(4580, 30, true);
            WriteLiteral("    <p>Inget sökresultat</p>\r\n");
            EndContext();
#line 129 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
}

#line default
#line hidden
            BeginContext(4613, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4615, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d8b4a395b894045ab8c8865c394c9c4", async() => {
                BeginContext(4647, 14, true);
                WriteLiteral("Lägg till film");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4665, 33, true);
            WriteLiteral("\r\n\r\n<p>Eventuellt felmeddelande: ");
            EndContext();
            BeginContext(4699, 13, false);
#line 133 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                        Write(ViewBag.error);

#line default
#line hidden
            EndContext();
            BeginContext(4712, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(4714, 17, false);
#line 133 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                                       Write(ViewBag.editError);

#line default
#line hidden
            EndContext();
            BeginContext(4731, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(4733, 19, false);
#line 133 "C:\Users\admin\source\repos\Laboration3\Laboration3\Views\Movie\ListMovies.cshtml"
                                                          Write(ViewBag.deleteError);

#line default
#line hidden
            EndContext();
            BeginContext(4752, 6, true);
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Laboration3.Models.MovieDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
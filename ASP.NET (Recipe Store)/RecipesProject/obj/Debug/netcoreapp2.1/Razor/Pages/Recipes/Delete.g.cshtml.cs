#pragma checksum "C:\Users\LuizSato\OneDrive - Centennial College\Attachments\3rd_Semester\COMP229-001\Project\Assignment_03-Final\RecipesProject\RecipesProject\Pages\Recipes\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "576499a377d97f3b3f40fb155631fb5dfd436b8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RecipesProject.Pages.Recipes.Pages_Recipes_Delete), @"mvc.1.0.razor-page", @"/Pages/Recipes/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Recipes/Delete.cshtml", typeof(RecipesProject.Pages.Recipes.Pages_Recipes_Delete), null)]
namespace RecipesProject.Pages.Recipes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\LuizSato\OneDrive - Centennial College\Attachments\3rd_Semester\COMP229-001\Project\Assignment_03-Final\RecipesProject\RecipesProject\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\LuizSato\OneDrive - Centennial College\Attachments\3rd_Semester\COMP229-001\Project\Assignment_03-Final\RecipesProject\RecipesProject\Pages\_ViewImports.cshtml"
using RecipesProject;

#line default
#line hidden
#line 3 "C:\Users\LuizSato\OneDrive - Centennial College\Attachments\3rd_Semester\COMP229-001\Project\Assignment_03-Final\RecipesProject\RecipesProject\Pages\_ViewImports.cshtml"
using RecipesProject.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"576499a377d97f3b3f40fb155631fb5dfd436b8b", @"/Pages/Recipes/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06cd2a5337523fdda21b18e9701fc5d8bdab10f2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Recipes_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\LuizSato\OneDrive - Centennial College\Attachments\3rd_Semester\COMP229-001\Project\Assignment_03-Final\RecipesProject\RecipesProject\Pages\Recipes\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(98, 236, true);
            WriteLiteral("\r\n<h3>Are you sure you want to delete this recipe?</h3>\r\n\r\n<div class=\"recipe-detail\">\r\n    <div class=\"container\">\r\n        <div class=\"row justify-content-center\">\r\n            <div class=\"col-lg-12 text-center\">\r\n                <h1>");
            EndContext();
            BeginContext(335, 49, false);
#line 14 "C:\Users\LuizSato\OneDrive - Centennial College\Attachments\3rd_Semester\COMP229-001\Project\Assignment_03-Final\RecipesProject\RecipesProject\Pages\Recipes\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Recipe.RecipeName));

#line default
#line hidden
            EndContext();
            BeginContext(384, 367, true);
            WriteLiteral(@"</h1>
            </div>
            <br />
            <div class=""col-lg-8"">
                <div class=""justify-content-center text-center border border-dark rounded"">
                    <div class=""row"">
                        <div class=""col-lg-4 col-sm-4 border border-light"">
                            <p>Serves:</p>
                            <p>");
            EndContext();
            BeginContext(752, 44, false);
#line 22 "C:\Users\LuizSato\OneDrive - Centennial College\Attachments\3rd_Semester\COMP229-001\Project\Assignment_03-Final\RecipesProject\RecipesProject\Pages\Recipes\Delete.cshtml"
                          Write(Html.DisplayFor(model => model.Recipe.Yield));

#line default
#line hidden
            EndContext();
            BeginContext(796, 193, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"col-lg-4 col-sm-4 border border-light\">\r\n                            <p>Prep Time:</p>\r\n                            <p>");
            EndContext();
            BeginContext(990, 54, false);
#line 26 "C:\Users\LuizSato\OneDrive - Centennial College\Attachments\3rd_Semester\COMP229-001\Project\Assignment_03-Final\RecipesProject\RecipesProject\Pages\Recipes\Delete.cshtml"
                          Write(Html.DisplayFor(model => model.Recipe.PreparationTime));

#line default
#line hidden
            EndContext();
            BeginContext(1044, 191, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"col-lg-4 col-sm-4 border border-light\">\r\n                            <p>Cooking:</p>\r\n                            <p>");
            EndContext();
            BeginContext(1236, 50, false);
#line 30 "C:\Users\LuizSato\OneDrive - Centennial College\Attachments\3rd_Semester\COMP229-001\Project\Assignment_03-Final\RecipesProject\RecipesProject\Pages\Recipes\Delete.cshtml"
                          Write(Html.DisplayFor(model => model.Recipe.CookingTime));

#line default
#line hidden
            EndContext();
            BeginContext(1286, 137, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div>\r\n                    <h3>");
            EndContext();
            BeginContext(1424, 51, false);
#line 35 "C:\Users\LuizSato\OneDrive - Centennial College\Attachments\3rd_Semester\COMP229-001\Project\Assignment_03-Final\RecipesProject\RecipesProject\Pages\Recipes\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Recipe.Category));

#line default
#line hidden
            EndContext();
            BeginContext(1475, 8, true);
            WriteLiteral(": <span>");
            EndContext();
            BeginContext(1484, 47, false);
#line 35 "C:\Users\LuizSato\OneDrive - Centennial College\Attachments\3rd_Semester\COMP229-001\Project\Assignment_03-Final\RecipesProject\RecipesProject\Pages\Recipes\Delete.cshtml"
                                                                               Write(Html.DisplayFor(model => model.Recipe.Category));

#line default
#line hidden
            EndContext();
            BeginContext(1531, 105, true);
            WriteLiteral("</span></h3>\r\n                </div>\r\n                <div>\r\n                    <h3 class=\"description\">");
            EndContext();
            BeginContext(1637, 54, false);
#line 38 "C:\Users\LuizSato\OneDrive - Centennial College\Attachments\3rd_Semester\COMP229-001\Project\Assignment_03-Final\RecipesProject\RecipesProject\Pages\Recipes\Delete.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Recipe.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1691, 34, true);
            WriteLiteral(":</h3>\r\n                    <span>");
            EndContext();
            BeginContext(1726, 50, false);
#line 39 "C:\Users\LuizSato\OneDrive - Centennial College\Attachments\3rd_Semester\COMP229-001\Project\Assignment_03-Final\RecipesProject\RecipesProject\Pages\Recipes\Delete.cshtml"
                     Write(Html.DisplayFor(model => model.Recipe.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1776, 100, true);
            WriteLiteral("</span>\r\n                </div>\r\n                <div>\r\n                    <h3 class=\"description\">");
            EndContext();
            BeginContext(1877, 53, false);
#line 42 "C:\Users\LuizSato\OneDrive - Centennial College\Attachments\3rd_Semester\COMP229-001\Project\Assignment_03-Final\RecipesProject\RecipesProject\Pages\Recipes\Delete.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Recipe.Directions));

#line default
#line hidden
            EndContext();
            BeginContext(1930, 34, true);
            WriteLiteral(":</h3>\r\n                    <span>");
            EndContext();
            BeginContext(1965, 49, false);
#line 43 "C:\Users\LuizSato\OneDrive - Centennial College\Attachments\3rd_Semester\COMP229-001\Project\Assignment_03-Final\RecipesProject\RecipesProject\Pages\Recipes\Delete.cshtml"
                     Write(Html.DisplayFor(model => model.Recipe.Directions));

#line default
#line hidden
            EndContext();
            BeginContext(2014, 158, true);
            WriteLiteral("</span>\r\n                </div>\r\n                <br />\r\n                <div class=\"description\">\r\n                    <div>\r\n                        <div>\r\n");
            EndContext();
            BeginContext(2665, 136, true);
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(2801, 231, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32e6eb266efa4b128ad86ec1d9f17440", async() => {
                BeginContext(2821, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2831, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9f274d9e68db4332ab6aebe94618d2a1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 66 "C:\Users\LuizSato\OneDrive - Centennial College\Attachments\3rd_Semester\COMP229-001\Project\Assignment_03-Final\RecipesProject\RecipesProject\Pages\Recipes\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Recipe.RecipeID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2880, 80, true);
                WriteLiteral("\r\n        <input class=\"btn btn-dark\" type=\"submit\" value=\"Delete\" /> \r\n        ");
                EndContext();
                BeginContext(2960, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f44daecf998e44c793e96350a8850549", async() => {
                    BeginContext(3003, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3019, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3032, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipesProject.Controllers.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecipesProject.Controllers.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RecipesProject.Controllers.DeleteModel>)PageContext?.ViewData;
        public RecipesProject.Controllers.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\OrdainedBychrist\source\repos\CollegeApp\Views\Student\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e86ad2a5cd757b5ccce7b001a17a10041c204ed0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Details), @"mvc.1.0.view", @"/Views/Student/Details.cshtml")]
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
#line 1 "C:\Users\OrdainedBychrist\source\repos\CollegeApp\Views\_ViewImports.cshtml"
using CollegeApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\OrdainedBychrist\source\repos\CollegeApp\Views\_ViewImports.cshtml"
using CollegeApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e86ad2a5cd757b5ccce7b001a17a10041c204ed0", @"/Views/Student/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9a5e2817378d1a5ddca21448ed15c5723a8346b", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CollegeApp.ViewModel.StudentVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\OrdainedBychrist\source\repos\CollegeApp\Views\Student\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details of ");
#nullable restore
#line 7 "C:\Users\OrdainedBychrist\source\repos\CollegeApp\Views\Student\Details.cshtml"
          Write(Model.StudentName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
<hr />

<div class=""row"">
    <div class=""col-md-6 mx-auto box-shadow"" style=""padding:20px;"">

        <div class=""card "" style=""padding:20px;"">
            <div class=""mx-auto"" style=""background:#ccc;padding:20px;"">
                <i class="" fa fa-user"" style=""font-size:200px;""></i>
            </div>
          <div class=""card-body mx-auto"">
              <center><h4 class=""card-title"">");
#nullable restore
#line 18 "C:\Users\OrdainedBychrist\source\repos\CollegeApp\Views\Student\Details.cshtml"
                                        Write(Model.StudentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></center>\r\n              <p class=\"card-text\"><strong>Registration Number</strong></p>\r\n              <p class=\"card-text text-center\">");
#nullable restore
#line 20 "C:\Users\OrdainedBychrist\source\repos\CollegeApp\Views\Student\Details.cshtml"
                                          Write(Model.RegistrationNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            
          </div>
        </div>

        <div style=""padding:20px;"">
            <table class=""table table-striped"">
                <tr>
                    <th colspan=""2""><center><strong>List of Courses Offered</strong></center></th>
                    
                </tr>
                <tr>
                    <th>
                        Course Name
                    </th>
                    <th>Course Code</th>
                </tr>
");
#nullable restore
#line 37 "C:\Users\OrdainedBychrist\source\repos\CollegeApp\Views\Student\Details.cshtml"
                 foreach(var course in Model.Courses )
                { 
                     
                   

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                               ");
#nullable restore
#line 43 "C:\Users\OrdainedBychrist\source\repos\CollegeApp\Views\Student\Details.cshtml"
                          Write(course.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                               ");
#nullable restore
#line 46 "C:\Users\OrdainedBychrist\source\repos\CollegeApp\Views\Student\Details.cshtml"
                          Write(course.CourseCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 49 "C:\Users\OrdainedBychrist\source\repos\CollegeApp\Views\Student\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </table>\r\n        </div>\r\n\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CollegeApp.ViewModel.StudentVM> Html { get; private set; }
    }
}
#pragma warning restore 1591

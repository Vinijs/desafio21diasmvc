#pragma checksum "C:\Users\Vinicius\source\repos\WebMVCRazor\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ab879cf6095321a9842f2ceed4e6b100b09ac417ce0e1e1c7914452ab8d4d703"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Vinicius\source\repos\WebMVCRazor\Views\_ViewImports.cshtml"
using WebMVCRazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vinicius\source\repos\WebMVCRazor\Views\_ViewImports.cshtml"
using WebMVCRazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Vinicius\source\repos\WebMVCRazor\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ab879cf6095321a9842f2ceed4e6b100b09ac417ce0e1e1c7914452ab8d4d703", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e9393153c203d9cdbe6d14fdca86e3e317209f057a69e09288f614e3ddd32613", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Vinicius\source\repos\WebMVCRazor\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    List<Cliente> clientes = ViewBag.clientes;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Clientes Disponíveis</h1>
    <table class=""table"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Nome</th>
                <th>Telefone</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 17 "C:\Users\Vinicius\source\repos\WebMVCRazor\Views\Home\Index.cshtml"
             foreach(Cliente cliente in clientes){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\Vinicius\source\repos\WebMVCRazor\Views\Home\Index.cshtml"
               Write(cliente.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\Vinicius\source\repos\WebMVCRazor\Views\Home\Index.cshtml"
               Write(cliente.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\Vinicius\source\repos\WebMVCRazor\Views\Home\Index.cshtml"
               Write(cliente.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 23 "C:\Users\Vinicius\source\repos\WebMVCRazor\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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

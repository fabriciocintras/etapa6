#pragma checksum "C:\Users\Fabrício\Documents\repositorio local git\ProjetoFullStack\Views\Usuario\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79b94a7b5324ce3d89554a169d6de821293d7cf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Listar), @"mvc.1.0.view", @"/Views/Usuario/Listar.cshtml")]
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
#line 1 "C:\Users\Fabrício\Documents\repositorio local git\ProjetoFullStack\Views\_ViewImports.cshtml"
using ProjetoFullStack;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fabrício\Documents\repositorio local git\ProjetoFullStack\Views\_ViewImports.cshtml"
using ProjetoFullStack.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79b94a7b5324ce3d89554a169d6de821293d7cf8", @"/Views/Usuario/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e205d2ad9382e2623c0b489ebfa07a5ff7275c", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Fabrício\Documents\repositorio local git\ProjetoFullStack\Views\Usuario\Listar.cshtml"
       ViewData["Title"] = "Listagem de Usuário"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n        <div class=\"box\">\r\n          <h2>Listar Usuario</h2>\r\n\r\n            <div class=\"grade\">\r\n");
#nullable restore
#line 9 "C:\Users\Fabrício\Documents\repositorio local git\ProjetoFullStack\Views\Usuario\Listar.cshtml"
                 foreach (Usuario u in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"conteudo\">\r\n                    <div class=\"imagemUsuario\">\r\n                        \r\n                    </div>\r\n                    <div class=\"idUsuario\">\r\n                        ");
#nullable restore
#line 16 "C:\Users\Fabrício\Documents\repositorio local git\ProjetoFullStack\Views\Usuario\Listar.cshtml"
                   Write(u.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"nomeUsuario\">\r\n                        ");
#nullable restore
#line 19 "C:\Users\Fabrício\Documents\repositorio local git\ProjetoFullStack\Views\Usuario\Listar.cshtml"
                   Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"loginUsuario\">\r\n                        ");
#nullable restore
#line 22 "C:\Users\Fabrício\Documents\repositorio local git\ProjetoFullStack\Views\Usuario\Listar.cshtml"
                   Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"senhaUsuario\">\r\n                        ");
#nullable restore
#line 25 "C:\Users\Fabrício\Documents\repositorio local git\ProjetoFullStack\Views\Usuario\Listar.cshtml"
                   Write(u.Senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"tipoUsuario\">\r\n                        ");
#nullable restore
#line 28 "C:\Users\Fabrício\Documents\repositorio local git\ProjetoFullStack\Views\Usuario\Listar.cshtml"
                   Write(u.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div>\r\n                         <td>\r\n                   <a");
            BeginWriteAttribute("href", " href=\"", 1035, "\"", 1066, 2);
            WriteAttributeValue("", 1042, "/Usuario/Editar?Id=", 1042, 19, true);
#nullable restore
#line 32 "C:\Users\Fabrício\Documents\repositorio local git\ProjetoFullStack\Views\Usuario\Listar.cshtml"
WriteAttributeValue("", 1061, u.Id, 1061, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">editar</a>\r\n                   <span> | </span>\r\n                   <a");
            BeginWriteAttribute("href", " href=\"", 1138, "\"", 1170, 2);
            WriteAttributeValue("", 1145, "/Usuario/Remover?Id=", 1145, 20, true);
#nullable restore
#line 34 "C:\Users\Fabrício\Documents\repositorio local git\ProjetoFullStack\Views\Usuario\Listar.cshtml"
WriteAttributeValue("", 1165, u.Id, 1165, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">remover</a>\r\n               </td>\r\n                    </div>\r\n                   \r\n                </div>\r\n");
#nullable restore
#line 39 "C:\Users\Fabrício\Documents\repositorio local git\ProjetoFullStack\Views\Usuario\Listar.cshtml"
                    
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </div>\r\n        </div>\r\n       \r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\jefri\Documents\Visual Studio 2019\Projects\ExamenT1\ExamenT1\Views\Persona\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1c254cdd15ecca5cf71f4e26c1bb85532415601"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persona_Index), @"mvc.1.0.view", @"/Views/Persona/Index.cshtml")]
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
#line 1 "C:\Users\jefri\Documents\Visual Studio 2019\Projects\ExamenT1\ExamenT1\Views\_ViewImports.cshtml"
using ExamenT1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jefri\Documents\Visual Studio 2019\Projects\ExamenT1\ExamenT1\Views\_ViewImports.cshtml"
using ExamenT1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1c254cdd15ecca5cf71f4e26c1bb85532415601", @"/Views/Persona/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"546f099c33a0eb988feac79ffc0d3e806691b068", @"/Views/_ViewImports.cshtml")]
    public class Views_Persona_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>Lista de personas</h1>
<a href=""/persona/create"">Crear persona</a>
<table class=""table"">
    <thead>
        <tr>

            <th>Nombre</th>
            <th>Apellido</th>
            <th>Fecha_Nacimiento</th>
            <th>DNI</th>
            <th>Genero</th>
            <th>Ciudad</th>
            <th>Direccion</th>
            <th>Correo</th>
            <th>Username</th>
            <th>Contraseña</th>
            <th>opciones</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 21 "C:\Users\jefri\Documents\Visual Studio 2019\Projects\ExamenT1\ExamenT1\Views\Persona\Index.cshtml"
          
            var personas = ((List<Personas>)ViewBag.personas);
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\jefri\Documents\Visual Studio 2019\Projects\ExamenT1\ExamenT1\Views\Persona\Index.cshtml"
         for (var i = 0; i < personas.Count; i++)
        {
            var item = personas[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\jefri\Documents\Visual Studio 2019\Projects\ExamenT1\ExamenT1\Views\Persona\Index.cshtml"
           Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\jefri\Documents\Visual Studio 2019\Projects\ExamenT1\ExamenT1\Views\Persona\Index.cshtml"
           Write(item.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\jefri\Documents\Visual Studio 2019\Projects\ExamenT1\ExamenT1\Views\Persona\Index.cshtml"
           Write(item.Fecha_nacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\jefri\Documents\Visual Studio 2019\Projects\ExamenT1\ExamenT1\Views\Persona\Index.cshtml"
           Write(item.DNI);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\jefri\Documents\Visual Studio 2019\Projects\ExamenT1\ExamenT1\Views\Persona\Index.cshtml"
           Write(item.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\jefri\Documents\Visual Studio 2019\Projects\ExamenT1\ExamenT1\Views\Persona\Index.cshtml"
           Write(item.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\jefri\Documents\Visual Studio 2019\Projects\ExamenT1\ExamenT1\Views\Persona\Index.cshtml"
           Write(item.direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\jefri\Documents\Visual Studio 2019\Projects\ExamenT1\ExamenT1\Views\Persona\Index.cshtml"
           Write(item.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\jefri\Documents\Visual Studio 2019\Projects\ExamenT1\ExamenT1\Views\Persona\Index.cshtml"
           Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\jefri\Documents\Visual Studio 2019\Projects\ExamenT1\ExamenT1\Views\Persona\Index.cshtml"
           Write(item.Contraseña);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1094, "\"", 1134, 2);
            WriteAttributeValue("", 1101, "/persona/Edit?id=", 1101, 17, true);
#nullable restore
#line 39 "C:\Users\jefri\Documents\Visual Studio 2019\Projects\ExamenT1\ExamenT1\Views\Persona\Index.cshtml"
WriteAttributeValue("", 1118, item.Id_persona, 1118, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1171, "\"", 1213, 2);
            WriteAttributeValue("", 1178, "/persona/delate?id=", 1178, 19, true);
#nullable restore
#line 40 "C:\Users\jefri\Documents\Visual Studio 2019\Projects\ExamenT1\ExamenT1\Views\Persona\Index.cshtml"
WriteAttributeValue("", 1197, item.Id_persona, 1197, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Eliminar</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 42 "C:\Users\jefri\Documents\Visual Studio 2019\Projects\ExamenT1\ExamenT1\Views\Persona\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
#pragma checksum "C:\Users\john f villalba l\Desktop\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Avion\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30d3e3a971d991bd096657ca8f8876f80bb92a39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoCiclo3.App.Frontend.Pages.Avion.Pages_Avion_Details), @"mvc.1.0.razor-page", @"/Pages/Avion/Details.cshtml")]
namespace ProyectoCiclo3.App.Frontend.Pages.Avion
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
#line 1 "C:\Users\john f villalba l\Desktop\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\_ViewImports.cshtml"
using ProyectoCiclo3.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30d3e3a971d991bd096657ca8f8876f80bb92a39", @"/Pages/Avion/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fac2ae24fef211f78e08fb554a390914631813e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Avion_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\john f villalba l\Desktop\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Avion\Details.cshtml"
  
    var Avion = Model.Avion;

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n<ul class=\"list-group list-group-flush\">\r\n  <li class=\"list-group-item\"> <b>id: </b> ");
#nullable restore
#line 8 "C:\Users\john f villalba l\Desktop\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Avion\Details.cshtml"
                                      Write(Avion.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"> <b>Marca : </b> ");
#nullable restore
#line 9 "C:\Users\john f villalba l\Desktop\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Avion\Details.cshtml"
                                          Write(Avion.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"> <b>Modelo: </b> ");
#nullable restore
#line 10 "C:\Users\john f villalba l\Desktop\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Avion\Details.cshtml"
                                          Write(Avion.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"><b>NumeroAsiento: </b> ");
#nullable restore
#line 11 "C:\Users\john f villalba l\Desktop\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Avion\Details.cshtml"
                                                Write(Avion.NumeroAsiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"><b>NumeroBanos : </b> ");
#nullable restore
#line 12 "C:\Users\john f villalba l\Desktop\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Avion\Details.cshtml"
                                               Write(Avion.NumeroBanos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"><b>CapacidadMax : </b> ");
#nullable restore
#line 13 "C:\Users\john f villalba l\Desktop\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Avion\Details.cshtml"
                                                Write(Avion.CapacidadMax);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n\r\n</ul>\t\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoCiclo3.App.Frontend.Pages.DetailsAvionModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoCiclo3.App.Frontend.Pages.DetailsAvionModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoCiclo3.App.Frontend.Pages.DetailsAvionModel>)PageContext?.ViewData;
        public ProyectoCiclo3.App.Frontend.Pages.DetailsAvionModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

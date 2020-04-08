#pragma checksum "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\FileInput.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0063a111fa68d0651affa77de7d39cc9d551110"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorDemoUI.Pages.MyPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using BlazorDemoUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using BlazorDemoUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\FileInput.razor"
using BlazorDemoUI.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\FileInput.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\FileInput.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fileinput")]
    public partial class FileInput : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\Franco Bester\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\FileInput.razor"
       
    IFileListEntry file;

    async Task HandelFileSelected(IFileListEntry[] files)
    {
        file = files.FirstOrDefault();
        if (file != null)
        {
            await fileUpload.UploadAsync(file);
            UploadImageDb(files);
        }

    }

    void UploadImageDb(IFileListEntry[] files)
    {
        file = files.FirstOrDefault();

        byte[] bImageByte = null;
        bImageByte = fileUpload.UploadAsync2(file);

        Books b = new Books
        {
            SalesNumber = 2,
            UserID = 2,
            BookTitle = "TestImage",
            BookEdition = 2,
            BookPrice = 14.23,
            LocationID = 2,
            ModuleCode = "CMPg 213",
            BooksInstitute = "NWu",
            DatePosted = DateTime.Today.Date,
            BookImage = bImageByte



        };
        fileUpload.InsertImage(b);

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload fileUpload { get; set; }
    }
}
#pragma warning restore 1591

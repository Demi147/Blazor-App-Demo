#pragma checksum "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\User.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0d3f3ffa7916ed285e45ff298532753a6136fec"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDemoUI.Pages.MyPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using BlazorDemoUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using BlazorDemoUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\User.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\User.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\User.razor"
using BlazorDemoUI.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Data/User")]
    public partial class User : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>User Page</h3>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, "<h4>Search user</h4>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 25 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\User.razor"
                  newUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(8);
                __builder2.AddAttribute(9, "id", "userSearch");
                __builder2.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\User.razor"
                                                                          SearchUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\User.razor"
                                            newUser.UserEmail

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newUser.UserEmail = __value, newUser.UserEmail))));
                __builder2.AddAttribute(13, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newUser.UserEmail));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n\r\n    ");
                __builder2.OpenElement(15, "button");
                __builder2.AddAttribute(16, "type", "reset");
                __builder2.AddAttribute(17, "class", "btn btn-primary");
                __builder2.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\User.razor"
                                                            SearchUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(19, "Search");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n\r\n");
            __builder.AddMarkupContent(22, "<h4> Remove user </h4>\r\n");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "type", "reset");
            __builder.AddAttribute(25, "class", "btn btn-primary");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\User.razor"
                                                        RemoveUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Remove");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n");
            __builder.AddMarkupContent(29, "<h4>Current user</h4>\r\n");
#nullable restore
#line 38 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\User.razor"
 if (_user is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "    ");
            __builder.AddMarkupContent(31, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 41 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\User.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "    ");
            __builder.OpenElement(33, "table");
            __builder.AddAttribute(34, "class", "table table-striped");
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.AddMarkupContent(36, "<thead>\r\n            <tr>\r\n                <th>User name</th>\r\n                <th>User ID</th>\r\n                <th>User email</th>\r\n                <th>User Password</th>\r\n                <th>Is admin</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(37, "tbody");
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 55 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\User.razor"
             foreach (var user in _user)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(39, "                ");
            __builder.OpenElement(40, "tr");
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 58 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\User.razor"
                         user.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 59 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\User.razor"
                         user.UserID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 60 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\User.razor"
                         user.UserEmail

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
#nullable restore
#line 61 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\User.razor"
                         user.UserPassword

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.OpenElement(54, "td");
            __builder.AddContent(55, 
#nullable restore
#line 62 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\User.razor"
                         user.IsAdmin

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 64 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\User.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n");
#nullable restore
#line 67 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\User.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\carel\Desktop\Blazor-App-Demo\BlazorDemoUI\Pages\MyPages\User.razor"
       
    private List<Users> _user;
    private DisplayUserModel newUser = new DisplayUserModel();

    protected override async Task OnInitializedAsync()//Working search all user function
    {
        _user = await _db.Get_AllUsers();
    }

    private async Task SearchUser()//Working searc user accordign to user email(input line 25-32)
    {
        try
        {
            int stest = newUser.UserID;
            _user = await _db.Get_SingleUser(stest);
        }
        catch (Exception ex)
        {
            string stest = ex.ToString();
        }
    }

    private async Task InsertUser()
    {
        try
        {
            Users u = new Users
            {
                UserID = 2,
                UserName = newUser.UserName,
                UserEmail = newUser.UserEmail,
                UserPassword = newUser.UserPassword,
                IsAdmin = false
            };
            await _db.InsertUser(u);

            _user.Add(u);//or _user = await _db.GetUsers();

            newUser = new DisplayUserModel();
        }
        catch (Exception ex)
        {
            string stest = ex.ToString();
        }

    }

    private async Task RemoveUser()
    {
        try
        {
            Users u = new Users
            {
                UserID = 2,
                UserName = newUser.UserName,
                UserEmail = newUser.UserEmail,
                UserPassword = newUser.UserPassword,
                IsAdmin = false
            };
            await _db.RemoveUser(u);

            _user.Remove(u);

            newUser = new DisplayUserModel();
        }
        catch (Exception ex)
        {
            string stest = ex.ToString();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserData _db { get; set; }
    }
}
#pragma warning restore 1591

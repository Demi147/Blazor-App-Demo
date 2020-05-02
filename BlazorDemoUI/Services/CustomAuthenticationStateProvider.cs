using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Blazored.SessionStorage;
using DataAccessLibrary.Models;

namespace BlazorDemoUI.Services
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private ISessionStorageService _sessionStorageService;

        public CustomAuthenticationStateProvider(ISessionStorageService _sessionStorage)
        {
            _sessionStorageService = _sessionStorage;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            //get identitiy

            var email = await _sessionStorageService.GetItemAsync<string>("emailAddress");

            ClaimsIdentity identity;

            if (email!=null)
            {
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name,email),
                }
                    , "apiauth_type");
            }
            else
            {
                identity = new ClaimsIdentity();
            }

            
            var user = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(user));
        }

        public void MarkUserAsAuthenticated(Users _user)
        {
            //get identitiy
            var identity = GetClaimsIdentity(_user);
            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        public void MarkUserAsLoggedOut()
        {
            _sessionStorageService.RemoveItemAsync("emailAddress");

            var identity = new ClaimsIdentity();
            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        public ClaimsIdentity GetClaimsIdentity(Users _user)
        {
            ClaimsIdentity identity;


            if (_user.IsAdmin)
            {
                identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name,_user.UserEmail),
                new Claim(ClaimTypes.Role,"admin")
            }, "apiauth_type");
            }
            else
            {
                identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name,_user.UserEmail),
            }, "apiauth_type");
            }

            return identity;
        }

    }
}

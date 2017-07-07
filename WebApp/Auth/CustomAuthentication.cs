using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Filters;

namespace WebApp.Auth
{
    public class CustomAuthentication : Attribute,IAuthenticationFilter
    {
        public bool AllowMultiple
        {
            get { return false; }
        }

        public async Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
        {
            HttpRequestMessage request = context.Request;
            AuthenticationHeaderValue authorization = request.Headers.Authorization;

            if(authorization == null)
            {
                return;
            }

            if(authorization.Scheme != "Basic")
            {
                return;
            }

            if (String.IsNullOrWhiteSpace(authorization.Parameter))
            {
                context.ErrorResult = new AuthenticationFailureResult("Missing Credentials", request);
                return;
            }

            Tuple<string, string> userNameAndPassword = ExtractUsernameAndPassword(authorization.Parameter);
            if(userNameAndPassword == null)
            {
                context.ErrorResult = new AuthenticationFailureResult("Invalid Credentials", request);
                return;
            }

            string username = userNameAndPassword.Item1;
            string password = userNameAndPassword.Item2;

            IPrincipal principal = await AuthenticateAsync(username, password,cancellationToken);

            if(principal == null)
            {
                context.ErrorResult = new AuthenticationFailureResult("Invalid credentials", request);
            }
            else
            {
                context.Principal = principal;
            }
        }

        private Tuple<string,string> ExtractUsernameAndPassword(string paramter)
        {

            return Tuple.Create<string, string>("billa", "meo");
        }

        private async Task<IPrincipal> AuthenticateAsync(string username,string password,CancellationToken cancellationToken )
        {
            return await Task.Run (() => {

                var identity = new GenericIdentity(username);
                IPrincipal principal = new GenericPrincipal(identity,null);

                return principal;
            });
        }

        public Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken)
        {
            var challenge = new AuthenticationHeaderValue("Basic");
            context.Result = new AddChallengeOnUnAuthorizedResult(challenge, context.Result);
            return Task.FromResult(0);
        }


    }
}
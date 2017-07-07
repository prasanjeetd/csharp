using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace WebApp.Auth
{
    public class AddChallengeOnUnAuthorizedResult : IHttpActionResult
    {
        public AddChallengeOnUnAuthorizedResult(AuthenticationHeaderValue challange, IHttpActionResult innerResult)
        {

            Challenge = challange;
            InnerResult = innerResult;
        }

        public AuthenticationHeaderValue Challenge { get; set; }

        public IHttpActionResult InnerResult { get; set; }

        public async Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            HttpResponseMessage respone = await InnerResult.ExecuteAsync(cancellationToken);

            if(respone.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                //if(respone.Headers.WwwAuthenticate.Any(x=> x.Scheme == Challenge.Scheme))
                {
                    respone.Headers.WwwAuthenticate.Add(Challenge);
                }
            }

            return respone;

        }
    }
}
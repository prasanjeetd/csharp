using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace WebApp.Auth
{
    public class AuthenticationFailureResult : IHttpActionResult
    {
        public string ReasonPhrase { get; private set; }
        public HttpRequestMessage Request { get; private set; }

        public AuthenticationFailureResult(string reassonPhrase, HttpRequestMessage request)
        {
            ReasonPhrase = reassonPhrase;
            Request = request;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(Execute());
        }

        private HttpResponseMessage Execute() {

            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
            response.ReasonPhrase = ReasonPhrase;
            response.RequestMessage = Request;

            return response;
        }

    }
}
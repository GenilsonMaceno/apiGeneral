using source.App_Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using System.Web;
using source.Models.Google;
using source.Interfarce.Services;

namespace source.Controllers
{
    public class GoogleController : ApiController
    {

        private readonly IGoogleServices _googleServices;
        private GoogleOutput _output;

        public GoogleController(IGoogleServices googleServices)
        {
            _googleServices = googleServices;
            _output = new GoogleOutput();
        }


        // GET: api/google/authorize
        [HttpGet]
        [ActionName("authorize")] // Nomeando uma action
        public async Task<HttpResponseMessage> UrlAuthorize()
        {

            _output.Google = await _googleServices.GetURIAthorize();
            _output.Status = "Sucesso";
            _output.Message = "Sucesso na requisição";

            return Request.CreateResponse(HttpStatusCode.OK, _output);
        }

    }
}
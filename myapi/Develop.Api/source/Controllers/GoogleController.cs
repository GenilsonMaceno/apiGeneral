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
    [RoutePrefix("Api/{version}/google")]
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
        //[ActionName("authorize")] // Nomeando uma action
        [Route("authorize" , Name = "UrlAllow")]
        public async Task<HttpResponseMessage> UrlAuthorize()
        {

            try
            {
                _output.Google = await _googleServices.GetURIAthorize();
                _output.Status = "Sucesso";
                _output.Message = "Sucesso na requisição";

                /* PARA CRIAR UM LINK A PARTIR DO NOME DADO
                var response = Request.CreateResponse(HttpStatusCode.Created);
                string uri = Url.Link("UrlAllow", new { Url = "google" });
                response.Headers.Location = new Uri(uri);
                */

                return Request.CreateResponse(HttpStatusCode.OK, _output);
            }
            catch (Exception ex)
            {

                throw ex;
            }           
        }

    }
}
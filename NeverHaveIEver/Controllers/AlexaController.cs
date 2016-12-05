using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NeverHaveIEver.Controllers
{
	public class AlexaController : ApiController
	{
		[Route("")]
		[HttpGet]
		[HttpHead]
		public IHttpActionResult root()
		{
			return this.Ok($"Yo, {Items.ItemsList.Count} items");
		}
		[Route("")]
		[HttpPost]
		public HttpResponseMessage Post()
		{
			return new AlexaResponse().GetResponse(this.Request);
		}
		[Route("excuse")]
		[HttpGet]
		public string GetExcuse()
		{
			return AlexaResponse.GetExcuse();
		}
	}
}

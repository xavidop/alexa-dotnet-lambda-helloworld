using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Alexa.NET.Request;
using Alexa.NET.Response;
using Amazon.Lambda.AspNetCoreServer;
using Amazon.Lambda.Core;
using alexa_dotnet_lambda_helloworld.BusinessLogic;

namespace alexa_dotnet_lambda_helloworld.Controllers
{
    [Produces("application/json")]
    [Route("api/alexa")]
    public class AlexaController : Controller
    {


        [HttpPost]
        public async Task<ActionResult> ProcessAlexaRequest([FromBody] SkillRequest request)
        {
            var context = (ILambdaContext)Request.HttpContext.Items[APIGatewayProxyFunction.LAMBDA_CONTEXT];

            AlexaRequestProcessor alexaRequestProcessor = new AlexaRequestProcessor();
            SkillResponse resp = await alexaRequestProcessor.ProcessAsync(request);


            return Ok(resp);


        }

    }

}

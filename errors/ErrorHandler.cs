using Alexa.NET;
using Alexa.NET.Request;
using Alexa.NET.RequestHandlers;
using Alexa.NET.RequestHandlers.Handlers;
using Alexa.NET.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alexa_dotnet_lambda_helloworld.errors
{
    public class ErrorHandler : SynchronousErrorHandler
    {
        public override bool CanHandle(AlexaRequestInformation<SkillRequest> information, Exception exception)
        {
            return true;
        }

        public override SkillResponse HandleSyncRequest(AlexaRequestInformation<SkillRequest> information, Exception exception)
        {
            Session session = information.SkillRequest.Session;
            String speech = "Error";//localizer.Get(currentLocale, "ERROR");
            Reprompt rp = new Reprompt(speech);
            return ResponseBuilder.Ask(speech, rp, session);
        }
    }
}

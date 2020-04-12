using Alexa.NET.Response;
using Alexa.NET.RequestHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alexa.NET.RequestHandlers.Handlers;
using Alexa.NET.Request;
using Alexa.NET;
using Alexa.NET.Request.Type;

namespace alexa_dotnet_lambda_helloworld.intents
{
    public class SessionEndedRequestIntentHandler : SynchronousRequestHandler
    {
        public override bool CanHandle(AlexaRequestInformation<SkillRequest> information)
        {
            return information.SkillRequest.GetRequestType() == typeof(SessionEndedRequest);
        }

        public override SkillResponse HandleSyncRequest(AlexaRequestInformation<SkillRequest> information)
        {
            Session session = information.SkillRequest.Session;
            String speech = "Bye";//localizer.Get(currentLocale, "GOODBYE_MSG");
            return ResponseBuilder.Tell(speech);
        }
    }
}
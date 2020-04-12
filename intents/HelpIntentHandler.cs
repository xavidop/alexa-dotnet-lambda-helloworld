using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alexa.NET.RequestHandlers.Handlers;
using Alexa.NET.Request;
using Alexa.NET;
using Alexa.NET.Request.Type;
using Alexa.NET.RequestHandlers;
using Alexa.NET.Response;

namespace alexa_dotnet_lambda_helloworld.intents
{
    public class HelpIntentHandler : SynchronousRequestHandler
    {
        public override bool CanHandle(AlexaRequestInformation<SkillRequest> information)
        {
            var intentRequest = (IntentRequest)information.SkillRequest.Request;
            return intentRequest.Intent.Name == "AMAZON.HelpIntent";
        }

        public override SkillResponse HandleSyncRequest(AlexaRequestInformation<SkillRequest> information)
        {
            Session session = information.SkillRequest.Session;
            String speech = "help";//localizer.Get(currentLocale, "HELP_MSG");
            Reprompt rp = new Reprompt(speech);
            return ResponseBuilder.Ask(speech, rp, session);
        }
    }
}
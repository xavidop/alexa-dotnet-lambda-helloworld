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
    public class HelloWorldIntentHandler : SynchronousRequestHandler
    {
        public override bool CanHandle(AlexaRequestInformation<SkillRequest> information)
        {
            var intentRequest = (IntentRequest)information.SkillRequest.Request;
            return intentRequest.Intent.Name == "HelloWorldIntent";
        }

        public override SkillResponse HandleSyncRequest(AlexaRequestInformation<SkillRequest> information)
        {
            Session session = information.SkillRequest.Session;
            String speech = "hola";//localizer.Get(currentLocale, "HELLO_MSG");
            Reprompt rp = new Reprompt(speech);
            return ResponseBuilder.Ask(speech, rp, session);
        }
    }
}
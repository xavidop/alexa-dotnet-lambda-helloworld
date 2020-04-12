using Alexa.NET.Response;
using Alexa.NET.RequestHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alexa.NET.RequestHandlers.Handlers;
using Alexa.NET.Request;
using Alexa.NET;
using alexa_dotnet_lambda_helloworld.utils;

namespace alexa_dotnet_lambda_helloworld.intents
{
    public class LaunchRequestIntentHandler : LaunchSynchronousRequestHandler
    {

        public override SkillResponse HandleSyncRequest(AlexaRequestInformation<SkillRequest> information)
        {
            Session session = information.SkillRequest.Session;
            String speech = LocalizationManager.Translate("WELCOME_MESSAGE");
            Reprompt rp = new Reprompt(speech);
            return ResponseBuilder.Ask(speech, rp, session);
        }
    }
}
 
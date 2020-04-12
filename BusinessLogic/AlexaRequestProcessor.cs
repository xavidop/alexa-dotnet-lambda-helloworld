using System;
using System.Threading.Tasks;
using Alexa.NET.Request;
using Alexa.NET.RequestHandlers;
using Alexa.NET.Response;
using alexa_dotnet_lambda_helloworld.errors;
using alexa_dotnet_lambda_helloworld.intents;
using alexa_dotnet_lambda_helloworld.utils;

namespace alexa_dotnet_lambda_helloworld.BusinessLogic
{
    public class AlexaRequestProcessor
    {
        public async Task<SkillResponse> ProcessAsync(SkillRequest input)
        {

            String currentLocale = input.Request.Locale.Split('-')[0];
            LocalizationManager.Init(currentLocale);
            var request = new AlexaRequestPipeline();
            request.RequestHandlers.Add(new LaunchRequestIntentHandler());
            request.RequestHandlers.Add(new SessionEndedRequestIntentHandler());
            request.RequestHandlers.Add(new CancelIntentHandler());
            request.RequestHandlers.Add(new HelpIntentHandler());
            request.RequestHandlers.Add(new HelloWorldIntentHandler());
            request.ErrorHandlers.Add(new ErrorHandler());
            return await request.Process(input);

        }
    }
}

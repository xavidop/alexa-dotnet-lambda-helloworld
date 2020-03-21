using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Alexa.NET.Response;
using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using Newtonsoft.Json;
using Alexa.NET;
using Amazon.Lambda.Core;
using alexa_dotnet_lambda_helloworld.BusinessLogic;


// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializerAttribute(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]


namespace alexa_dotnet_lambda_helloworld
{
    /// <summary>
    /// This class extends from APIGatewayProxyFunction which contains the method FunctionHandlerAsync which is the 
    /// actual Lambda function entry point. The Lambda handler field should be set to
    /// 
    /// alexa_dotnet_lambda_helloworld::alexa_dotnet_lambda_helloworld.LambdaEntryPoint::FunctionHandlerAsync
    /// </summary>
    public class Function
    {
        public SkillResponse FunctionHandler(SkillRequest input, ILambdaContext context)
        {
            AlexaRequestProcessor alexaRequestProcessor = new AlexaRequestProcessor();
            return alexaRequestProcessor.Process(input);
        }
    }
}

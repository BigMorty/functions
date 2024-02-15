using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.WebJobs.Extensions.OpenAI;
using Microsoft.Azure.WebJobs.Extensions.OpenAI.Models;

namespace genai2
{
    public static class WhoIs
    {
        [FunctionName(nameof(WhoIs))]
        public static string WhoIsFunction(
            [HttpTrigger(AuthorizationLevel.Function, Route = "whois/{name}")] HttpRequest req,
            [TextCompletion("Who is {name}?")] TextCompletionResponse response)
        {
            return response.Content;
        }

    }

}

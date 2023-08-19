using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Microsoft.WindowsAzure.Storage.Table;
using System;

namespace azure_hol_functions
{
    public static class Function2
    {
        [FunctionName("Function2")]
        [return: Table("<TABLE>", Connection = "StorageConnectionAppSetting")]
        public static SampleData Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)]
        HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];

            var sd = new SampleData()
            {
                PartitionKey = "Http",
                RowKey = Guid.NewGuid().ToString(),
                Text = name
            };

            return sd;
        }
    }

    public class SampleData : TableEntity
    {
        public string Text { get; set; }
    }
}
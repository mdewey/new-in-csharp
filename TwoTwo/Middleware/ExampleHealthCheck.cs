using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TwoTwo.Middleware
{
    public class ExampleHealthCheck : IHealthCheck
    {

        public ExampleHealthCheck()
        {
            // COULD use DI to insert an services **cough cough, database connections cough cough**
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context,
         CancellationToken cancellationToken = default(CancellationToken))
        {
            /*
             COULD do small things to check for status
                - ping a database
                - check each service status
             */
            var isHealthy = new Random().Next(1, 21) % 2 == 0;

            if (isHealthy)
            {
                return Task.FromResult(HealthCheckResult.Healthy("Smooth Sailings Capt'n"));
            }
            else
            {
                return Task.FromResult(HealthCheckResult.Unhealthy("We've run a ground Capt'n!"));
            }

        }

        public static Task WriteResponse(HttpContext context, HealthReport report)
        {
            context.Response.ContentType = "application/json";

            var json = new JObject(
             new JProperty("status", report.Status.ToString()),
             new JProperty("results", new JObject(report.Entries.Select(pair =>
                 new JProperty(pair.Key, new JObject(
                     new JProperty("status", pair.Value.Status.ToString()),
                     new JProperty("description", pair.Value.Description)
                     ))))));
            return context.Response.WriteAsync(
                json.ToString(Formatting.Indented));
        }
    }
}
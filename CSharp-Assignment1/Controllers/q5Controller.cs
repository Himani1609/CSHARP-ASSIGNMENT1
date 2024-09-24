using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSHARP_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q5Controller : ControllerBase
    {
        /// <summary>
        /// Receives a number by user as POST data
        /// </summary>
        /// <returns>
        /// An HTTP response is a message "Shh . . the secret is {number}"
        /// </returns>
        /// <param name="number">It is the input number given by the user in the body of the data</param>
        /// <remarks> 
        /// Heading: Content-Type: application/json
        /// Request Body: { "number": 5 }
        /// </remarks>
        /// <example>
        /// POST api/q5/Secret  ->  "Shh.. the secret is 5" when -d "{ "number": 5 }" is sent as JSON in the body
        /// POST api/q5/Secret  ->  "Shh.. the secret is 10" when -d "{ "number": 10 }" is sent as JSON in the body
        /// POST api/q5/Secret  ->  "Shh.. the secret is 200" when -d "{ "number": 200 }" is sent as JSON in the body
        /// </example>

        [HttpPost(template: "secret")]
        public string secret([FromBody] int number)
        {
            return $"Shh . . the secret is {number}";
        }
    }
}
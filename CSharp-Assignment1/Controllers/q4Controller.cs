using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSHARP_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q4Controller : ControllerBase
    {
        ///<summary>
        /// Recieves an HTTP Post request and outputs the start of a knockknock joke.
        /// </summary>
        /// <returns>
        /// Output is the start of a knockknock message "Who's there?"
        /// </returns>
        /// <example>
        /// POST api/q4/knockknock  ->  Who's there?
        /// </example>
        [HttpPost(template: "knockknock")]
        public string knockknock()
        {
            return "Who's there?";
        }

    }
}
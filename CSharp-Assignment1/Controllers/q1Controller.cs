using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSHARP_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q1Controller : ControllerBase
    {

        /// <summary>
        /// Recieves an HTTP Get request and provides a response message.
        /// </summary>
        /// <returns>
        /// A message "Welcome to 5125!"
        /// </returns>
        ///<example>
        /// GET api/q1/welcome  ->  Welcome to 5125!
        ///</example>

        [HttpGet(template: "welcome")]
        public string welcome()
        {
            return "Welcome to 5125!";
        }

    }
}
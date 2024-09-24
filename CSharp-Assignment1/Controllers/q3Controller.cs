using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSHARP_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q3Controller : ControllerBase
    {
        /// <summary>
        /// Recieves a number from input and outputs the cube of the number.
        /// </summary>
        /// <param name="Base">It is the number input by the user</param>
        /// <returns>
        /// An HTTP respone will be the cube of the number input by the user.
        /// </returns>
        /// <example>
        /// GET api/q3/cube/4  ->  64
        /// GET api/q3/cube/-4  ->  -64
        /// GET api/q3/cube/10  ->  1000
        /// </example>
        /// <remarks>
        /// lowercase base is a reserved keyword in C#. So, I have used "Base" as a parameter with uppercase in the first letter.
        /// </remarks>

        [HttpGet(template: "cube/{Base}")]
        public int cube(int Base)
        {
            return (int)Math.Pow(Base, 3);
        }
    }
}
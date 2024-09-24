using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSHARP_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q6Controller : ControllerBase
    {
        /// <summary>
        /// Recieves an HTTP GET request as the side of the regular hexagon by the user  and outputs the area of hexagon.
        /// </summary>
        /// <param name="side">It is the side length {S} of the hexagon (S must be greater than 0) given by the user</param>
        /// <returns>
        /// An HTTP response will be the area of regular hexagon of side {S}.
        /// </returns>
        /// <remarks>
        /// public double is used because we want the area of regular hexagon in decimals.
        /// side is in integer.
        /// (3 * Math.Sqrt(3) / 2)  is in decimals. so, double is used.
        /// </remarks>
        /// <example>
        /// GET api/q6/hexagon?side=1  ->  2.598076211353316
        /// GET api/q6/hexagon?side=1.5  ->  5.845671475544961
        /// GET api/q6/hexagon?side=2  ->  1039.2304845413264
        /// </example>
        [HttpGet(template: "hexagon")]
        public double hexagon(double side)
        {
            return (double)((double)(3 * Math.Sqrt(3) / 2) * (Math.Pow(side, 2)));
        }
    }
}
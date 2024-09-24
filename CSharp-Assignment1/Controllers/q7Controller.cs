using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSHARP_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q7Controller : ControllerBase
    {
        /// <summary>
        /// Returns the date by adding a specified number of days to the current date.
        /// </summary>
        /// <param name="days">The number of days to add</param>
        /// <returns>
        /// The calculated date in the format yyyy-MM-dd
        /// </returns>
        /// <example>
        /// GET api/q7/timemachine?days=1  ->  the date 1 day from today i.e. tomorrow's date
        /// GET api/q7/timemachine?days=-1  ->  the date 1 day before today i.e. yesterday's date
        /// </example>
        [HttpGet(template: "timemachine")]
        public string timemachine(int days)
        {
            DateTime today = DateTime.Now;
            DateTime answer = today.AddDays(days);

            // Format date to yyyy-MM-dd
            return answer.ToString("yyyy-MM-dd");
        }
    }
}
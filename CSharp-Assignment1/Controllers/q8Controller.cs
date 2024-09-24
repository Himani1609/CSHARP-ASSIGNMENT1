using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace CSHARP_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q8Controller : ControllerBase
    {

        ///<summary>
        /// Recieve the number of small squashfellows and number of large squashfellows.
        /// It calculates the total cost for small and large squash fellows, including tax.
        /// </summary>
        /// <param name="small">The number of small squash fellows</param>
        /// <param name="large">The number of large squash fellows</param>
        /// <returns>
        /// It will output the detailed breakdown of the cost, including subtotal, tax, and total.
        /// </returns>
        /// <remarks>
        /// Content-Type: application/x-www-form-urlencoded
        /// </remarks>
        /// <example>
        /// POST api/q8/squashfellows  ->  1 Small @ $25.50 = $25.50; 1 Large @ $40.50 = $40.50; Subtotal = $66.00; Tax = $8.58 HST; Total = $74.58 when -d"small=1&large=1" 
        /// POST api/q8/squashfellows  ->  2 Small @ $25.50 = $51.00; 1 Large @ $40.50 = $40.50; Subtotal = $91.50; Tax = $11.90 HST; Total = $103.40 when -d"small=2&large=1"
        /// </example>

        [HttpPost(template: "squashfellows")]
        public string squashfellows([FromForm] int small, [FromForm] int large)
        {
            // Calculate the total for small and large squash fellows
            double small_total = small * 25.50;
            double large_total = large * 40.50;
            double subtotal = small_total + large_total;


            // Assuming the tax is 13% HST
            double tax = Math.Round(subtotal * 0.13, 2);
            double total_with_tax = Math.Round(subtotal + tax, 2);

            // Set culture to Canadian dollars
            var cultureInfo = new CultureInfo("en-CA");

            // Format all values as Canadian currency and round to 2 decimal places
            string small_total_formatted = small_total.ToString("C2", cultureInfo);
            string large_total_formatted = large_total.ToString("C2", cultureInfo);
            string subtotal_formatted = Math.Round(subtotal, 2).ToString("C2", cultureInfo);
            string tax_formatted = tax.ToString("C2", cultureInfo);
            string total_formatted = total_with_tax.ToString("C2", cultureInfo);

            // Return the formatted result string
            return $"{small} Small @ $25.50 = {small_total_formatted}; {large} Large @ $40.50 = {large_total_formatted}; Subtotal = {subtotal_formatted}; Tax = {tax_formatted}; Total = {total_formatted}";
        }
    }
}
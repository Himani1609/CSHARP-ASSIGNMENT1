using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSHARP_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q2Controller : ControllerBase
    {

        ///<summary>
        ///Recieves name from user and outputs the message saying Hi to the name input by the user.
        ///</summary>
        ///<param name="name">It is the name input by the user</param>
        ///<returns>
        ///An HTTP response is message "Hi {name}!"
        ///</returns>
        ///<example>
        ///GET api/q2/greeting?name=Himani  ->  Hi Himani!
        ///GET api/q2/greeting?name=Manik  -->  Hi Manik!
        ///GET api/q2/greeting?name=Apurva  -->  Hi Apurva!
        ///</example>

        [HttpGet(template: "greeting")]
        public string greeting(string name)
        {
            return $"Hi {name}!";
        }

    }
}
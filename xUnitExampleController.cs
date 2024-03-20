using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace xUnitExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class xUnitExampleController : ControllerBase
    {
        public string Index(int guessedNumber)
        {
            //return "I am in xUnitExample";
            if(guessedNumber < 100)
            {
                return "Wrong! Try a Bigger number";
            }
            else if(guessedNumber > 100)
            {
                return "Wrong! Try a Smaller number";
            }
            else
            {
                return "You Gussed Correct number";
            }
        }
    }
}

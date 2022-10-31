using Hermes.Common.Dtos;
using Hermes.Common.Interface.UserInterface;
using Hermes.Common.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace Hermes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserActivityController : ControllerBase
    {

        private readonly IUserActivity _userActivity;

        public UserActivityController(IUserActivity userActivity)
        {
            _userActivity = userActivity;
        }

        [HttpPost]
        [Route("Loggin")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult<Response>> LogginAsync(LogginUserDto logginUserDto)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            return Ok(await _userActivity.UserLoggin(logginUserDto));
        }
    }
}

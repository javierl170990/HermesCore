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
    public class UserController : ControllerBase
    {
        private readonly IUserMessage _userMessage;
        public UserController(IUserMessage userMessage)
        {
            _userMessage = userMessage;
        }

        [HttpGet]
        [Route("GetMessage/{userId}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        //[ValidateAntiForgeryToken]
        //add tokenlogin byUser on middleware
        public async Task<ActionResult<Response>> GetMessageAsync([FromRoute]int UserId) 
        {
            return Ok(await _userMessage.GetMessageByUserId(UserId));

        }

        [HttpPost]
        //add tokenlogin byUser on middleware
        [Route("SendMessageBycontactNumber/")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult<Response>> SendMessageAsync(SendMessageDto sendMessageDto)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            return Ok(await _userMessage.SendMessageByUserName(sendMessageDto));

        }

       

    }
}

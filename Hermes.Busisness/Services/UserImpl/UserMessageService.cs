using Hermes.Common.Dtos;
using Hermes.Common.Interface;
using Hermes.Common.Interface.UserInterface;
using Hermes.Common.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Busisness.Services.UserImpl
{
    public class UserMessageService : IUserMessage
    {

        private readonly ICacheService cacheService;

        public UserMessageService(ICacheService cacheService)
        {
            this.cacheService = cacheService;
        }

        public Task<Response> GetMessageByUserId(int UserId)
        {
            throw new NotImplementedException();
        }

        public Task<Response> SendMessageByUserName(SendMessageDto sendMessageDto)
        {
            throw new NotImplementedException();
        }
    }
}

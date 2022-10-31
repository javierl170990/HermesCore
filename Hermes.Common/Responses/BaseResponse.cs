using Hermes.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Common.Responses
{
    public class BaseResponse : IResponse
    {
        public bool IsValid { get; set; }
        public string Message { get; set; }
        public HttpStatusCode Type { get; set; }
        public bool HasMessages
        {
            get
            {
                return (this.Message.Length > 0);
            }
        }
        public BaseResponse()
        {
            this.IsValid = false;
            this.Type = HttpStatusCode.InternalServerError;
            this.Message = string.Empty;
        }
    }
}

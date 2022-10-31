using Hermes.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Common.Responses
{
    public class Response : BaseResponse, IResponseObject
    {
        public object Data { get; set; }


        public Response() { }
        public Response(object Data, bool IsValid, string Message, HttpStatusCode Type)
        {
            this.Data = Data;
            this.IsValid = IsValid;
            this.Message = Message;
            this.Type = Type;
        }
    }
}
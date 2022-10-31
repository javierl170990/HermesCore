using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Common.Dtos
{
    public class SendMessageDto
    {       
        public string ContactNumber { get; set; }

        public string? strMessage { get; set; }

        public byte[]? AudioMessage { get; set; }

        public byte[]? VideoMessage { get; set; }

    }
}

using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Domain.Entities
{
    public class UserMessage
    {
        public Guid UserFrom { get; set; }
        public Guid UserTo { get; set; }

        [StringLength(255)]
        public string? strMessage { get; set; }

        public byte[]? AudioMessage { get; set; }

        public byte[]? VideoMessage { get; set; }

        public bool send { get; set; }

        public DateTime SendDate { get; set; }

        public DateTime ReceiveDate { get; set; }

        public bool Read { get; set; }
    }
}

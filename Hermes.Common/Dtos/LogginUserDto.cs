using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Common.Dtos
{
    public class LogginUserDto
    {
        public Guid Id  { get; set; }
        public string UserName { get; set; }
        public string EncrypPass { get; set; }        
    }
}

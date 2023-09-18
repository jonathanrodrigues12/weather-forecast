using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brasil.Api.Models
{
    public class ErrorResponse
    {
        public string message { get; set; }
        public string type { get; set; }
        public string name { get; set; }
    }
}

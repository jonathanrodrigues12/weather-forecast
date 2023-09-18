using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Log:BaseEntityWithId
    {
        public int Code { get; set; }  
        public string JsonContent { get; set; }
    }
}

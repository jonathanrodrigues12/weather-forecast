using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain {
    public class Cities: Base.BaseEntityWithId {
        public string Name { get; set; }
        public string State { get; set; }
        public long IdBrasilApi { get; set; }
    }
}

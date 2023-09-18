using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain {
    public class CitySearch: Base.BaseEntityWithId {
        [MaxLength(80)]
        [Required]
        public string Name { get; set; }

        [MaxLength(2)]
        [Required]
        public string State { get; set; }
    }
}

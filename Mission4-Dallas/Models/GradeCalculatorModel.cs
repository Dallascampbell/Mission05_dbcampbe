using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4_Dallas.Models
{
    public class GradeCalculatorModel
    {
        //Range makes it so the numebr entered has to be within that range. Type is set to float to allow for decimals in the percentages
        
        [Range(0, 100, ErrorMessage = "Enter number between 0 to 100")]
        public float Assign { get; set; }
        [Range(0, 100, ErrorMessage = "Enter number between 0 to 100")]
        public float Pro { get; set; }
        [Range(0, 100, ErrorMessage = "Enter number between 0 to 100")]
        public float Quiz { get; set; }
        [Range(0, 100, ErrorMessage = "Enter number between 0 to 100")]
        public float Mid { get; set; }
        [Range(0, 100, ErrorMessage = "Enter number between 0 to 100")]
        public float Fin { get; set; }
        [Range(0, 100, ErrorMessage = "Enter number between 0 to 100")]
        public float IN { get; set; }

    }
}

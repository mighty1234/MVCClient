
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLibrary
{
    public partial class StaffDto
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Field is requored")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Field is requored")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Field is requored")]
        public int  Brunch_id { get; set; }
        [Required(ErrorMessage = "Field is requored")]
        public List<int> Orsers_id { get; set; }
        [Required(ErrorMessage = "Field is requored")]
        public int Position_id { get; set; }
        
    }
}


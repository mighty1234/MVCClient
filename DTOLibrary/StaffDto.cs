
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
        public int BrunchId { get; set; }
        [Required(ErrorMessage = "Field is requored")]
        public List<int> OrsersId { get; set; }
        public int PositionId { get; set; }

       //public PositionDto Position{ get; set; }
       // public BrunchDto Brunch { get; set; }
       // public List<Orders> Orders { get; set; }
  
    }
}



using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLibrary
{
    public partial class BrunchDto
    {
       

        public int Id { get; set; }
        [Required(ErrorMessage = "Field is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Field is required")]
        public string Name { get; set; }
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Unvalid EMail")]
        public string Email { get; set; }
        public List<int> StaffId { get; set; }
        public List<int> OrdersId { get; set; }
           
       // public List<StaffDto> Staff { get; set; }
       
    }
}

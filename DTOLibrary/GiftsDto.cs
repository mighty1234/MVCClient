
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLibrary
{
     public partial class GiftsDto
    {
        

        public int Id { get; set; }
        [Required(ErrorMessage = "Field is requored")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Field is requored")]
        public int Cost { get; set; }
        public List<int> OrdersId { get; set; }
    }
}

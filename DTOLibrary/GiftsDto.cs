
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLibrary
{
     public partial class GiftsDto
    {
        

        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Cost { get; set; }
        public List<int> OrdersId { get; set; }
    }
}

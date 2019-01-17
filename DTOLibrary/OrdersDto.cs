
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLibrary
{
    public partial class OrdersDto
    {
       
        public int Id { get; set; }
        public Nullable<int> Staff_id { get; set; }
        public Nullable<int> Brunch_id { get; set; }
        public Nullable<int> Client_id { get; set; }
        public Nullable<int> Gift_id { get; set; }
    }
}

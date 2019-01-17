using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTOLibrary
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public Nullable<int> Staff_id { get; set; }
        public Nullable<int> Brunch_id { get; set; }
        public Nullable<int> Client_id { get; set; }
        public Nullable<int> Gift_id { get; set; }

        public BrunchViewModel Brunch { get; set; }
        public ClientViewModel Client { get; set; }
        public GiftsViewModel Gifts { get; set; }
        public StaffViewModel Staff { get; set; }
    }
}
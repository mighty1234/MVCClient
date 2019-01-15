using DTOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static MVCDataLoader.Globalvariables;

namespace MVCDataLoader
{
    class StaffLoader
    {
        public static List<StaffViewModel> GetAll()
        {
           
               StaffViewModel mappedStaff = new StaffViewModel();
                List<OrderViewModel> list = new List<OrderViewModel>();


                List<StaffDto> staffs;
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Orders").Result;
            staffs = response.Content.ReadAsAsync<List<StaffDto>>().Result;

                foreach (var staff in staffs)
                {
                mappedStaff = Mapper.MapStaff(staff);
                mappedStaff.Brunch = BrunchLoader.GetInsertedById(staff.BrunchId);
                mappedStaff.Position = PositionLoader.GetInsertedById(staff.PositionId);
                foreach ( var orders  in staff.OrsersId)
                { }
               

                    list.Add(mappedOrder);
                }



                return list;
            


        }      

     
        


        public static  StaffViewModel GetById(int id)
        {
            StaffDto staff;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Staff/" + id.ToString()).Result;
            staff = response.Content.ReadAsAsync<StaffDto>().Result;
            var result = Mapper.MapStaff(staff);
            // result.Orders=OrderLoader.



            return result;
        }

        static   public StaffViewModel GetInsertedById(int id)
        {

            StaffDto staff;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Staff/" + id.ToString()).Result;
            staff = response.Content.ReadAsAsync<StaffDto>().Result;
            var result = Mapper.MapStaff(staff);
            // result.Orders=OrderLoader.



            return result;
        }

       
       
    }
}

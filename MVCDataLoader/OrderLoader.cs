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
   public static  class OrderLoader
    {
        public static OrderViewModel GetOrder(int id)
        {

            OrdersDto order;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Orders/" + id.ToString()).Result;
            order = response.Content.ReadAsAsync<OrdersDto>().Result;
            var result = Mapper.MapOrder(order);
            result.Staff = StaffLoader.GetInsertedById(result.Staff_id.GetValueOrDefault());
            result.Brunch = BrunchLoader.GetInsertedById(result.Brunch_id.GetValueOrDefault());
            result.Gifts = GiftsLoader.GetInsertedById(result.Gift_id.GetValueOrDefault());
            result.Client = ClientLoader.GetInsertedById(result.Client_id.GetValueOrDefault());

            return result;
        }
        /// <summary>
        /// unused now 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static OrderViewModel GetInsertedById(int id)
        {

            OrdersDto order;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Orders/" + id.ToString()).Result;
            order = response.Content.ReadAsAsync<OrdersDto>().Result;
            var result = Mapper.MapOrder(order);
            return result;
        }

        public static List<OrderViewModel> GetOrders()
        {
            OrderViewModel  mappedOrder = new OrderViewModel();
            List<OrderViewModel> list = new List<OrderViewModel>();


            List<OrdersDto> orders;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Orders").Result;
            orders = response.Content.ReadAsAsync<List<OrdersDto>>().Result;

            foreach (var order in orders)
            {
                mappedOrder = Mapper.MapOrder(order);
                mappedOrder.Brunch = BrunchLoader.GetInsertedById(order.Brunch_id.GetValueOrDefault());
                mappedOrder.Staff = StaffLoader.GetInsertedById(order.Staff_id.GetValueOrDefault());


                list.Add(mappedOrder);
            }

           

            return list;
        }
    }
}

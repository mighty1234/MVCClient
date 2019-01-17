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
  public static  class ClientLoader
    {
        public static List<ClientViewModel> GetAll()
        {

            ClientViewModel mappedClient = new ClientViewModel();
            List<ClientViewModel> list = new List<ClientViewModel>();


            List<ClientDto> clients;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Clients").Result;
            clients = response.Content.ReadAsAsync<List<ClientDto>>().Result;

            foreach (var client in clients)
            {
                mappedClient = Mapper.MapClient(client);
                
                foreach (var id in client.OrdersId)
                {
                    var order = MVCDataLoader.OrderLoader.GetOrder(id);
                    mappedClient.Orders.Add(order);
                }

                list.Add(mappedClient);




            }
            return list;
        }





        public static ClientViewModel GetById(int id)
        {
           
            ClientDto client;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Clients/" + id.ToString()).Result;
            client = response.Content.ReadAsAsync<ClientDto>().Result;

            var result = Mapper.MapClient(client);
            foreach (var ordertid in client.OrdersId)
            {
                result.Orders.Add(OrderLoader.GetOrder(ordertid));
            }




            return result;
        }

        static public ClientViewModel GetInsertedById(int id)
        {

            ClientDto client;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Clients/" + id.ToString()).Result;
           client = response.Content.ReadAsAsync<ClientDto>().Result;
            var result = Mapper.MapClient(client);            
           
            return result;
        }



    
}
}

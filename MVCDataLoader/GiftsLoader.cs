﻿using DTOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static MVCDataLoader.Globalvariables;

namespace MVCDataLoader
{
 public static  class GiftsLoader
    {
        public static GiftsViewModel GetGift(int id)
        {

            GiftsDto gift;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Gift/" + id.ToString()).Result;
           gift = response.Content.ReadAsAsync<GiftsDto>().Result;
            var result = Mapper.MapGift(gift);
            foreach (var item in gift.OrdersId)
            {
               result.Orders.Add( OrderLoader.GetInsertedById(item));
            }



            return result;
        }

        public static GiftsViewModel GetInsertedById(int id)
        {

            GiftsDto gift;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Gift/" + id.ToString()).Result;
            gift = response.Content.ReadAsAsync<GiftsDto>().Result;
            var result = Mapper.MapGift(gift);
            return result;
        }
        public static List<GiftsViewModel> GetGifts()
        {
            GiftsViewModel mappedGift = new GiftsViewModel();
            List<GiftsViewModel> list = new List<GiftsViewModel>();


            List<GiftsDto> gifts;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Gift").Result;
           gifts  = response.Content.ReadAsAsync<List<GiftsDto>>().Result;

            foreach (var gift in gifts)
            {
                mappedGift = Mapper.MapGift(gift);
                foreach (var item in gift.OrdersId)
                {
                    mappedGift.Orders.Add(OrderLoader.GetOrder(item));
                }


                list.Add(mappedGift);
            }



            return list;
        }

        public static void Save(GiftsDto gift)
        {
            if (gift.Id == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Gift", gift).Result;
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Gift/" + gift.Id, gift).Result;
            }


        }

        public static void Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Gift/" + id).Result;
        }
    }
}

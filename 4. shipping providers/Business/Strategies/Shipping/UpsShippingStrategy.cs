using Strategy_Pattern_Using_different_shipping_providers.Business.Models;
using System;
using System.Net.Http;

namespace Strategy_Pattern_Using_different_shipping_providers.Business.Strategies.Shipping
{
    public class UpsShippingStrategy : IShippingStrategy
    {
        public void Ship(Order order)
        {
            using (var client = new HttpClient())
            {
                Console.WriteLine("Order is shipped with UPS");
            }
        }
    }
}

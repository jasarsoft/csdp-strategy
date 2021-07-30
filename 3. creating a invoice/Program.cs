using Strategy_Pattern_Creating_an_invoice.Business.Models;
using Strategy_Pattern_Creating_an_invoice.Business.Strategies.SalesTax;
using System;
using Strategy_Pattern_Creating_an_invoice.Business.Strategies.Invoice;

namespace Strategy_Pattern_Creating_an_invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order
            {
                ShippingDetails = new ShippingDetails 
                { 
                    OriginCountry = "Sweden",
                    DestinationCountry = "Sweden"
                },
                SalesTaxStrategy = new SwedenSalesTaxStrategy()
            };
            
            order.LineItems.Add(new Item("CSHARP_SMORGASBORD", "C# Smorgasbord", 100m, ItemType.Literature), 1);

            
            order.SelectedPayments.Add(new Payment()
            {
                PaymentProvider = PaymentProvider.Invoice
            });

            Console.WriteLine(order.GetTax());

            order.InvoiceStrategy = new FileInvoiceStrategy();
            order.FinalizeOrder();
        }
    }
}

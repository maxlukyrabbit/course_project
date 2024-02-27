using System;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {

            string id_deal = SearchDeal.SearchDealMethod("1944102691");
            
            string result = DealManager.сhangeStage_accepted_warehouse(id_deal);
            
            Console.WriteLine(result);
           
           
        }
    }
}

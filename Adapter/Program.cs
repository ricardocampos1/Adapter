using Adapter.Classes;
using Adapter.Interfaces;
using System;

namespace Adapter
{
    class Program
    {
        static void Main()
        {
            ITarget target = new EmployeeAdapter();
            ThirdPartyBillingSystem client = new(target);
            client.ShowEmployeeList();

            Console.ReadKey();
        }
    }
}

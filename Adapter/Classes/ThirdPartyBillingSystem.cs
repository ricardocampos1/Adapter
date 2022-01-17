using Adapter.Interfaces;
using System;
using System.Collections.Generic;

namespace Adapter.Classes
{
    public class ThirdPartyBillingSystem
    {
        private readonly ITarget employeeSource;

        public ThirdPartyBillingSystem(ITarget employeeSource)
        {
            this.employeeSource = employeeSource;
        }

        public void ShowEmployeeList()
        {
            List<string> employee = employeeSource.GetEmployeeList();
            //To DO: Implement you business logic

            Console.WriteLine("######## Lista de Funcionários ########");
            foreach (var item in employee)
            {
                Console.Write(item);
            }
        }
    }
}

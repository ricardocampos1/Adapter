namespace Adapter.Classes
{
    public class HRSystem
    {
        public static string[][] GetEmployees()
        {
            string[][] employees = new string[4][];

            employees[0] = new string[] { "100", "Jose Fonseca", "Team Lead" };
            employees[1] = new string[] { "101", "Lucas Domingues", "Tech Lead" };
            employees[2] = new string[] { "103", "Felipe Machado", "Desenvolvedor Senior" };
            employees[3] = new string[] { "103", "Ricardo Campos", "Desenvolvedor Pleno" };

            return employees;
        }
    }
}
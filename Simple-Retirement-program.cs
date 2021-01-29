using System;

namespace Tests
/*Crie um programa que leia nome, ano de nascimento e carteira de trabalho e cadastre-os 
 * (com idade) em um dicionário. se por caso a CTPS for diferente de ZERO, o dicionário 
 * receberá também o ano de contratação e o salário. Calcule e acrescente, além da idade, 
 * com quantos anos a pessoa vai se aposentar*/
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Year of birth: ");
            var yearBirth = int.Parse(Console.ReadLine());
            Console.Write("SSN: ");
            var ssnNumber = int.Parse(Console.ReadLine());
            var hiredYear = 0;            

            if (ssnNumber != 0)
            {
                Console.Write("Hired in: ");
                var tmpHiredYear = int.Parse(Console.ReadLine());
                hiredYear = Convert.ToInt32(tmpHiredYear);
                Console.Write("Salary: ");
                var salary = float.Parse(Console.ReadLine());
            }

            

            var todayYear = DateTime.Now.Year;
            var personAge = todayYear - yearBirth;

            Console.WriteLine("\n---- Your Personal Info -----");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + personAge);
            
            if(ssnNumber != 0){
                Console.WriteLine("SSN Number: " + ssnNumber);

                var retirementYear = hiredYear + 35;
                Console.WriteLine("Year of retirement: " + retirementYear);
            }

        }
    }
}

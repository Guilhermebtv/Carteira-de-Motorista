using System;

namespace CarteiraMotorista 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Bem-vindo ao sistema da Autoescola Santista");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Por favor, insira sua data de nascimento (dd/mm/aaaa): ");
            string inputData = Console.ReadLine();

            
            DateTime dataNascimento;
            bool dataValida = DateTime.TryParseExact(inputData, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataNascimento);

            if (dataValida)
            {
                
                int idade = DateTime.Today.Year - dataNascimento.Year;

                
                if (dataNascimento.Date > DateTime.Today.AddYears(-idade)) idade--;

                
                if (idade >= 18)
                {
                    Console.WriteLine($"Você tem {idade} anos. Você pode começar a tirar a carteira de motorista.", idade);
                }
                else
                {
                    Console.WriteLine($"Você tem {idade} anos. Ainda não pode tirar a carteira de motorista.", idade);
                }
            }
            else
            {
                Console.WriteLine("Data inválida! Por favor, insira a data no formato dd/mm/aaaa.");
            }
        }
    }
    
}
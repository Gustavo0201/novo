
using System.Runtime.InteropServices.ComTypes;
namespace Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args){
            try 
            {
                Console.WriteLine("Informe sua data de nascimento: ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                int idade = DateTime.Today.Year - data.Year;
                
                if (data.DayOfYear < DateTime.Today.DayOfYear)
                    idade = idade - 1;

                Console.WriteLine($"Sua idade é de: {idade}");
                

                Console.WriteLine("Sua idade é de: " + 
                                $"{(DateTime.Today.Year - data.Year)}"
                                + " anos !");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }   
    
}
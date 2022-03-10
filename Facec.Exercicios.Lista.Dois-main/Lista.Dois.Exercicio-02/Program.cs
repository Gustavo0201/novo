
namespace Exercicio_02
{
    internal class Program
    {
        private const string _sim = "SIM";
        static void Main(string[] args)
        {
            string continuar = string.Empty;
            char operacao = 'a';
            decimal valor1, valor2 = 0.0m;
            try
            {
                do
                {
                    try
                    {
                        Console.WriteLine("Informe a operação:");
                        operacao = char.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    switch (operacao)
                    {
                        case '+':
                            Console.WriteLine("Informe o primeiro valor para a soma:");
                            valor1 = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o primeiro valor para a soma:");
                            valor2 = decimal.Parse(Console.ReadLine());

                            Console.WriteLine($"O resultado da sua conta é:{valor1 + valor2}");
                            break;
                        case '-':
                            Console.WriteLine("Informe o primeiro valor para a subtração:");
                            valor1 = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o primeiro valor para a subtração:");
                            valor2 = decimal.Parse(Console.ReadLine());

                            Console.WriteLine($"O resultado da sua conta é:{valor1 - valor2}");
                            break;
                        case '*':
                            Console.WriteLine("Informe o primeiro valor para a multiplicação:");
                            valor1 = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o primeiro valor para a multiplicação:");
                            valor2 = decimal.Parse(Console.ReadLine());

                            Console.WriteLine($"O resultado da sua conta é:{valor1 * valor2}");
                            break;
                        case '/':
                            Console.WriteLine("Informe o primeiro valor para a divisão:");
                            valor1 = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o primeiro valor para a divisão:");
                            valor2 = decimal.Parse(Console.ReadLine());

                            Console.WriteLine($"O resultado da sua conta é:{valor1 / valor2}");
                            break;
                        case '%':
                            Console.WriteLine("Informe o primeiro valor para o resto da divisão:");
                            valor1 = decimal.Parse(Console.ReadLine());

                            Console.WriteLine("Informe o primeiro valor para o resto da divisão::");
                            valor2 = decimal.Parse(Console.ReadLine());

                            Console.WriteLine($"O resultado da sua conta é:{valor1 % valor2}");
                            break;
                        default:
                            throw new Exception("Operação matemática não " +
                                        "configurada !");
                    }

                    Console.WriteLine("Deseja continuar ? [sim/nao]");
                    continuar = Console.ReadLine();

                } while (_sim.Equals(continuar.ToUpper()));
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
namespace Exercicio_03
{
    internal class Program
    {
        private const char _a = 'a';
        private const char _e = 'e';
        private const char _i = 'i';
        private const char _o = 'o';
        private const char _u = 'u';

        static void Main(string[] args)
        {
            int count = 0;
            try
            {
                Console.WriteLine("Digite o seu nome: ");
                string nome = Console.ReadLine().ToLower();

                for (int i = 0; i < nome.Length; i++)
                {
                    if (_a.Equals(nome[i])
                        || _e.Equals(nome[i])
                        || _i.Equals(nome[i])
                        || _o.Equals(nome[i])
                        || _u.Equals(nome[i]))
                        count++;
                }

                Console.WriteLine($"Seu nome possui {count} vogal(is) !");
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
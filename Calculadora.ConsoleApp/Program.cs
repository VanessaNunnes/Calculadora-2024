namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Calculadora Tabajara 2024");

                Console.WriteLine("Digite 1 para Adicionar");
                Console.WriteLine("Digite 2 para Subtrair");
                Console.WriteLine("Digite 3 para Multiplicar");
                Console.WriteLine("Digite 4 para Dividir");

                Console.WriteLine("Digite S para sair");

                string operacao = Console.ReadLine();

             
                if (operacao == "S" || operacao == "s")
                {
                    break;
                }   
                else if (operacao != "S" && operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4")
                {
                    Console.WriteLine("Informe uma opção válida");
                    continue;
                }
                
                Console.WriteLine("Informe o primeiro número: ");
                double primeiroNumero = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe o segundo número: ");
                double segundoNumero = Convert.ToDouble(Console.ReadLine());


               double resultado = 0;

                if (operacao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                }

                else if (operacao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                }

                else if (operacao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                }

                else if (operacao == "4")
                {
                    while(segundoNumero == 0)
                    {
                        Console.WriteLine("Segundo número não pode ser 0, digite outro número");
                        Console.WriteLine("Informe o segundo número novamente");

                        segundoNumero = Convert.ToDouble(Console.ReadLine());
                    }
                    resultado = primeiroNumero / segundoNumero;
                   
                }
                Console.WriteLine("O resultado é: " + resultado);
                Console.ReadLine();

            } 
        }
    }
}

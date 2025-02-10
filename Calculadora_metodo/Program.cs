using System;

namespace CalculadoraPOO
{
    // Interface para padronizar as operações matemáticas
    public interface IOperacao
    {
        decimal Calcular(decimal a, decimal b);
    }

    // Classes das operações matemáticas
    public class Soma : IOperacao
    {
        public decimal Calcular(decimal a, decimal b) => a + b;
    }

    public class Subtracao : IOperacao
    {
        public decimal Calcular(decimal a, decimal b) => a - b;
    }

    public class Multiplicacao : IOperacao
    {
        public decimal Calcular(decimal a, decimal b) => a * b;
    }

    public class Divisao : IOperacao
    {
        public decimal Calcular(decimal a, decimal b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Erro: Divisão por zero não permitida!");
            }
            return a / b;
        }
    }

    // Classe da Calculadora
    public class Calculadora
    {
        private IOperacao operacao;

        // Método para definir a operação desejada
        public void DefinirOperacao(IOperacao op)
        {
            operacao = op;
        }

        // Método para executar a operação
        public decimal ExecutarOperacao(decimal a, decimal b)
        {
            if (operacao == null)
            {
                throw new InvalidOperationException("Operação não definida!");
            }
            return operacao.Calcular(a, b);
        }
    }

    class Program
    {
        static void Main()
        {
            Calculadora calc = new Calculadora();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Digite o Primeiro Número:");
            Console.ResetColor();

            if (!decimal.TryParse(Console.ReadLine(), out decimal valor1))
            {
                Console.WriteLine("Valor Inválido! Encerrando...");
                return;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Digite o Segundo Número:");
            Console.ResetColor();

            if (!decimal.TryParse(Console.ReadLine(), out decimal valor2))
            {
                Console.WriteLine("Valor Inválido! Encerrando...");
                return;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Escolha a operação (+ - * /):");
            Console.ResetColor();

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "+":
                    calc.DefinirOperacao(new Soma());
                    break;
                case "-":
                    calc.DefinirOperacao(new Subtracao());
                    break;
                case "*":
                    calc.DefinirOperacao(new Multiplicacao());
                    break;
                case "/":
                    calc.DefinirOperacao(new Divisao());
                    break;
                default:
                    Console.WriteLine("Operação inválida! Encerrando...");
                    return;
            }

            try
            {
                Console.ForegroundColor = ConsoleColor.Green;                
                decimal resultado = calc.ExecutarOperacao(valor1, valor2);
                Console.WriteLine($"Resultado: {resultado}");
                Console.ResetColor();                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            Console.WriteLine("Programa encerrado.");
        }
    }
}

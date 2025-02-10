namespace Calculadora
{
    class Mais
    {
        public static void RealizarAdicao(
            decimal var1,
            decimal var2
        )
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"A Soma dos valores {var1} + {var2} é = {var1+var2}");
            Console.ResetColor();   
        }
        
    }
    class Menos
    {
        public static void RealizarSubitação(
            decimal var1,
            decimal var2
        )
        {
            Console.ForegroundColor = ConsoleColor.Green;           
            Console.WriteLine($"A Subitração dos valores {var1} - {var2} é = {var1-var2}");
            Console.ResetColor(); 
        }
        
    }
    class Vezes
    {
        public static void RealizarMultiplicação(
            decimal var1,
            decimal var2
        )
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"A Multiplicação dos valores {var1} x {var2} é = {var1*var2}");
            Console.ResetColor(); 
        }
        
    }
     class Divisao
    {
        public static void RealizarDivisão(
            decimal var1,
            decimal var2
        )
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"A Divisão dos valores {var1} / {var2} é = {var1/var2}");
            Console.ResetColor(); 
        }
        
    }
}
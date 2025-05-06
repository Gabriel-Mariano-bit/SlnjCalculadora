namespace PrjCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculadora calc = new Calculadora();
            CalculadoraAvancada calcAdv = new CalculadoraAvancada();

            Console.Write("10 + 10 = ");
            Console.WriteLine(calcAdv.Somar(10, 10));

            Console.Write("10 - 10 = ");
            Console.WriteLine(calcAdv.Subtrair(10, 10));

            Console.Write("10 x 10 = ");
            Console.WriteLine(calcAdv.Multiplicar(10, 10));

            Console.Write("10 / 10 = ");
            Console.WriteLine(calcAdv.Dividir(10, 10));

            Console.Write("2 ^ 2 = ");
            Console.WriteLine(calcAdv.Potencia(2,2));
        }
    }
}


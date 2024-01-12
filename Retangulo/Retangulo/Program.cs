using Retangulo;

namespace Course
{
    internal class Retangulo
    {
        static void Main(string[] args)
        {
            RetanguloMethod method = new RetanguloMethod();

            Console.WriteLine("Entre largura e altura do retângulo");
            method.Largura = double.Parse(Console.ReadLine());
            method.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Area: " + method.Area());
            Console.WriteLine("Perimetro: " + method.Perimetro());
            Console.WriteLine("Diagonal: " + method.Diagonal());


        }
    }
}
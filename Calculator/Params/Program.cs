namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Calculator.Sum(4, 5);
            Console.WriteLine(result);

            int triple = 4; 
            Calculator.Triple(ref triple);
            Console.WriteLine(triple);

            int quadruple = 10;
            int resultQuadruple;
            Calculator.Quadruple(quadruple, out resultQuadruple);
            Console.WriteLine(resultQuadruple);


        }
    }
}
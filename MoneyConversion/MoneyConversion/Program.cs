namespace MoneyConversion
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("What is the exchange rate of the currency that will be purchased?");
            double currency = double.Parse(Console.ReadLine());

            Console.WriteLine("How much are you going to buy?");
            double quantiity = double.Parse(Console.ReadLine());

            double result = CalcMoneyConversion.CalcIOF(currency, quantiity);

            Console.WriteLine("Amount to be paid in BRL: R$ "+ result);

        }
    }
}
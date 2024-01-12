namespace SchoolAverage
{
    internal class SchoolAverage
    {
        static void Main(string[] args)
        {
            SchoolAvg schoolAvg = new SchoolAvg();
            double avgFix = 60;


            Console.WriteLine("Insert your name: ");
            schoolAvg.Name = Console.ReadLine();

            for (int i = 0; i < schoolAvg.Avg.Length; i++) {
                Console.WriteLine("Insert your grade: ");
                schoolAvg.Avg[i] = double.Parse(Console.ReadLine());
                schoolAvg.FinalAvg += schoolAvg.Avg[i];
            }


            Console.WriteLine(schoolAvg);

            if (schoolAvg.FinalAvg < avgFix) {
                Console.WriteLine("You failed!");
                avgFix -= schoolAvg.FinalAvg;
                Console.WriteLine(avgFix + " missing");
            } else
            {
                Console.WriteLine("Congratulations! You have been approved. :)");
            }


        }
    }
}
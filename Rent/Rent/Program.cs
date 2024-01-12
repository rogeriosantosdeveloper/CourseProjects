namespace Rent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] student = new Student[10];

            Console.Write("How many rooms will be ranted?: ");
            int roomsRanted = int.Parse(Console.ReadLine());

            for (int i = 1; i <= roomsRanted; i++)
            {
                Console.WriteLine("Rent #" + i);
                Console.WriteLine("Please provide the name of the " + i + " room.");
                string name = Console.ReadLine();

                Console.WriteLine("Please provide the email of the " + i + " room.");
                string email = Console.ReadLine();

                Console.WriteLine("Which room will " + name + " be staying in? ");
                int rooms = int.Parse(Console.ReadLine());

                student[rooms] = new Student(name, email);
            }


            for (int i = 0; i <= 9; i++)
            {
                if (student[i] != null)
                {
                    Console.WriteLine(i + ":" + student[i]);
                }
            }
        }
    }
}
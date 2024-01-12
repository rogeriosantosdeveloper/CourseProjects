using System.Globalization;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            avg();
        }

        static void avg()
        {
            Employer employer1 = new Employer();
            Employer employer2 = new Employer();

            Console.WriteLine("First person data: ");
            Console.WriteLine("Name: ");
            employer1.Name = Console.ReadLine();
            Console.WriteLine("Wage: ");
            employer1.Wage= int.Parse(Console.ReadLine());

            Console.WriteLine("Second person data: ");
            Console.WriteLine("Name: ");
            employer2.Name = Console.ReadLine();
            Console.WriteLine("Wage: ");
            employer2.Wage = int.Parse(Console.ReadLine());

            double avg = (employer1.Wage + employer2.Wage) / 2;

            Console.WriteLine("Average wage: " + avg);

        }

        static void age()
        {
            Person pessoa1 = new Person();
            Person pessoa2 = new Person();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.WriteLine("Nome: ");
            pessoa1.nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.WriteLine("Nome: ");
            pessoa2.nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            pessoa2.idade = int.Parse(Console.ReadLine());

            if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine("A pessoa: " + pessoa1.nome + " é mais velha!");
            }
            else if (pessoa2.idade > pessoa1.idade)
            {
                Console.WriteLine("A pessoa: " + pessoa2.nome + " é a mais velha");
            }
            else
            {
                Console.WriteLine("As duas pessoas tem a mesma idade");
            }
        }

        static void triangle()
        {
            Triangle x, y;

            x = new Triangle();
            y = new Triangle();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;

            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }

        static void inputNumber()
        {
            Console.WriteLine("Digite três números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);
        }

        static int maior(int n1, int n2, int n3)
        {
            if(n1>n2 && n1 > n3)
            {
                double number = n1;
                return n1;

            } else if (n2 > n3)
            {
                double number = n1;
                return n2;
            } else
            {
                double number = n1;
                return n3;
            }

        }

        static void exercise()
        {
            Console.WriteLine("Informe o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?: ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com um preço de um produto: ");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com sua cor favorita, idade e altura (mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');

            string cor = vet[0];
            int idade = int.Parse(vet[1]);
            double height = double.Parse(vet[2]);

            Console.WriteLine("Seu nome é: "+ nome);
            Console.WriteLine("Em sua casa tem " + quartos + " quartos");
            Console.WriteLine("Preço do produto digitado: " + price);

            Console.WriteLine("Cor favorita: " + cor + " idade: " + idade + " e altura: " + height);
        }

        static void input()
        {
 //           int n1 = int.Parse(Console.ReadLine());
 //           char ch = char.Parse(Console.ReadLine());
 //           double n2 = double.Parse(Console.ReadLine());

            string[] vet = Console.ReadLine().Split(' ');

            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3]);


            Console.WriteLine("Seu nome é: " + nome + " do sexo: " + sexo + " idade: " +idade+ " e altura: "+altura);
        }

        static void readLine()
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string []vet = Console.ReadLine().Split(' ');
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine();

            Console.WriteLine("Você digitou: ");
            Console.WriteLine();
            
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine();

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine();


            Console.WriteLine("Thank you for use our application!");
        }

        static void initial()
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35478;
            string nome = "Maria";

            int a;
            int b;

            a = 5;
            b = 2;

            double resultado = (double)a / b;

            Console.WriteLine(resultado);

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            Console.WriteLine("----------------------------");

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);

            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
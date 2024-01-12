using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AddProducts(qte);

            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int removeQte = int.Parse(Console.ReadLine());
            p.RemoveProducts(removeQte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
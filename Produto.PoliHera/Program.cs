namespace Produto.PoliHera;
class Program
{
    static void Main(string[] args)
    {
        Estadual prodEstadual = new Estadual();
        Nacional prodNacional = new Nacional();
        Importado prodImportado = new Importado();

        Console.WriteLine("Digite a descrição do produto Estadual: ");
        prodEstadual.descricao = Console.ReadLine();
        Console.WriteLine("Digite o valor do produto: ");
        prodEstadual.Valor = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o impsto do produto: ");
        prodEstadual.Imposto = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Valor do produto com imposto: ");
        prodNacional.Imposto = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("------------------------------------------------------");

        Console.WriteLine("Digite a descrição do produto Nacional: ");
        prodNacional.descricao = Console.ReadLine();
        Console.WriteLine("Digite o valor do produto: ");
        prodNacional.Valor = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o imposto do produto: ");
        prodNacional.Imposto = Convert.ToDouble(Console.ReadLine());

        
        Console.WriteLine("Valor do produto com imposto: ");
        prodNacional.Imposto = Convert.ToDouble(Console.ReadLine());

    }
}

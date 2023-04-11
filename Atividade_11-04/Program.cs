namespace Atividade_11_04;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Trabalhando com Agregação!");

        //instanciando os objetos de cada classe 
        CartaoDeCredito cdc = new CartaoDeCredito();
        Cliente cli = new Cliente();

        //adicionando um nome para um cliente
        cli.Nome = "Gabriel Dantas";

        //adicionando número e validade do cartão de  crédito
        cdc.Numero = "987654321";
        cdc.DataValidade = "09/2027";

        //associando o cliente ao atributo de agregação em cartão de crédito
        cdc.Cliente = cli;

        //visualizando informações 
        Console.WriteLine("O nome do cliente é: " + cli.Nome);
        Console.WriteLine("O número do  cartão é: " + cdc.Numero);
        Console.WriteLine("A data de validade é: " + cdc.DataValidade);
        Console.WriteLine("O nome do cliente AGREGADO é: " + cdc.Cliente.Nome);
    }
}

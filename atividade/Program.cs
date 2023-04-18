namespace atividade;
class Program
{
    static void Main(string[] args)
    {
        Banco b = new Banco();

        b.imprime(b.prestacao(1000,12));

        b.imprimir(b.juros(1000,0.06));

        b.imprimi(b.total(60,83));

    }
}

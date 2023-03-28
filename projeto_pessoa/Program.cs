namespace projeto_pessoa;
class Prograim
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa();
        p1.InsereNome("Gabriel");
        //p1.InsereSobreNome("Dantas");
        p1.InsereIdade(16);

        p1.MostraDados();
    }
}

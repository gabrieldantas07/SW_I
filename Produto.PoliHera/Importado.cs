namespace Produto.PoliHera;
class Importado:Produto
{
    public double taxa{get;set;}
    public double taxaImportacao{get;set;}

    public override double calcValor()
    {
        double taxa = (1+(this.taxa/100));
        double taxaImportacao = (1+(this.taxaImportacao/100));
        return base.calcValor();
    }
}
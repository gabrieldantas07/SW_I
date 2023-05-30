namespace Produto.PoliHera;
class Nacional:Produto
{
    public double taxa{get;set;}

    public override double calcValor(){
        double tx = (1+(this.taxa/100));
        return base.calcValor()+(this.Valor);
    }
}
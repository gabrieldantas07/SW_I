namespace Produto.PoliHera;
class Produto
{
    public string? descricao{get;set;}

    public double Valor{get;set;}
    public double Imposto{get;set;}

    public virtual double calcValor(){
        return this.Valor*1.1;
    }
}
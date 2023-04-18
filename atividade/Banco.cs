namespace atividade;
class Banco{
    public int num1 {get;set;}
    public int num2 {get;set;}

    public string prestacao (int n1, int n2){
        this.num1 = n1;
        this.num2 = n2;
        int divisao = this.num1 / this.num2;
        string resultado = "Se o valor de "+this.num1+ " for dividido em "  +this.num2+ "meses, o valor de cada prestação será de " +divisao;

        return resultado;
    }
    
    public string juros (int n1, double n2){
        this.num1 = n1;
        double juro = this.num1 * 0.06;
        string resultado1 = "O valor do juros em cada prestação será de "+juro;

        return resultado1;
        
    }

     public string total (int n1, int n2){
        this.num1 = n1;
        this.num2 = n2;
        double todo = this.num1 + num2;
        double todos = todo * 12;
        string resultado2 = "O valor do juros + prestação é de  "+todo;

        return resultado2;
        
    }

    public void imprime(string texto){
        Console.WriteLine(texto);
    }

    public void imprimir(string text){
        Console.WriteLine(text);
    }

    public void imprimi(string tex){
        Console.WriteLine(tex);
    }
}

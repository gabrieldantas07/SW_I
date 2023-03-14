namespace ExercicioAluno;
class Program
{
    static void Main(string[] args)
    {
        Alunos aluno1 = new Alunos();
        aluno1.nome = "Renan Silva";
        aluno1.nota1 = 4.3;
        aluno1.nota2 = 7.8;

        aluno1.mensagem();

        Alunos aluno2 = new Alunos();
        aluno2.nome = "Ana Fontes";
        aluno2.nota1 = 4;
        aluno2.nota2 = 5;

        aluno2.mensagem();


    }
}

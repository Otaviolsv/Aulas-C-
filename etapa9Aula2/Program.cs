using etapa9_aula2;

public class Program
{
    public static void Main()
    {
        string[] diretorios = Directory.GetDirectories(@"C:\");

        string novoDiretorio = @"C:\MeuDiretorio";

        string nomeArquivo = "Aluno.txt";

        string caminhoArquivo = Path.Combine(novoDiretorio, nomeArquivo);



        Aluno aluno1 = new("Bruno", 18);
        Aluno aluno2 = new("João", 20);
        Aluno aluno3 = new("Pernas", 19);
        Aluno aluno4 = new("Lucas", 21);
        Aluno aluno5 = new("Otavio", 23);


        using (var fluxoArquivo = new StreamWriter(caminhoArquivo))
        {
            fluxoArquivo.WriteLine(aluno1);
            fluxoArquivo.WriteLine(aluno2);
            fluxoArquivo.WriteLine(aluno3);
            fluxoArquivo.WriteLine(aluno4);
            fluxoArquivo.WriteLine(aluno5);
        }

        
    }
}
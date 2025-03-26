
public class Aluno
{
    public int id;
    public string nome;
    public short idade;
}

class Program
{
    static void Main(string[] args)
    {
        string[] diretorios = Directory.GetDirectories(@"C:\");

        string[] arquivos = Directory.GetFiles(@"C:\_pasta", "*.*",
                                               SearchOption.AllDirectories);

        //if (File.Exists("C:\\_pasta\\altera\\output.txt"))
        //{
        //    FileInfo infoarquivo = new FileInfo(@"C:\_pasta\altera\output.txt");

        //    Console.WriteLine($"Nome completo: {infoarquivo.FullName}");
        //    Console.WriteLine($"Data criação: {infoarquivo.CreationTime}");
        //    Console.WriteLine($"Tamanho Arquivo: {infoarquivo.Length}");
        //}

        string novoDiretorio = @"C:\MeuDiretorio";

        //Directory.CreateDirectory(novoDiretorio);

        string nomeArquivo = "MeuArquivo.txt";

        string caminhoArquivo = Path.Combine(novoDiretorio, nomeArquivo);

        //using (var fluxoArquivo = File.Create(caminhoArquivo))
        //{
        //    for (byte i = 0; i < 10; i++)
        //    {
        //        fluxoArquivo.WriteByte(i);
        //    }
        //}

        ///USANDO STREAMWRITER
        using (var fluxoArquivo = new StreamWriter(caminhoArquivo, true))
        {
            string conteudo = "Texto legível";

            for (int i = 200; i < 210; i++)
            {
                fluxoArquivo.WriteLine($"{i} - {conteudo}");
            }
        }

        Aluno aluno = new Aluno { id = 1, nome = "João", idade = 20 };


        using (var fluxoArquivo = new StreamWriter(caminhoArquivo))
        {

            for (short i = 200; i < 210; i++)
            {
                aluno.id = i;
                aluno.nome = "AAA";
                //aluno.idade = i + 10; 
                fluxoArquivo.WriteLine($" {aluno.id},{aluno.nome},{aluno.idade}");
            }

        }

        ///usando StreamReader
        using (var fluxoArquivo = new StreamReader(caminhoArquivo))
        {

            while (!fluxoArquivo.EndOfStream)
            {
                string linha = fluxoArquivo.ReadLine();

                string[] campos = linha.Split(',');

            }

        }
    }

}
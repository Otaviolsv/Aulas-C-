
class Program
{
    static void Main(string[] args)
    {
        string nomecompleto = "Otávio Vasconcelos";
        string sobrenome;
        string sobrenome2;

        Console.WriteLine(nomecompleto);

        Console.WriteLine("Nome em maiúsculo:" + nomecompleto.ToUpper());
        // converte para letras maiusculas 

        Console.WriteLine("Nome em minúsculo:" + nomecompleto.ToLower());
        // converte para letras minusculas

        Console.WriteLine(nomecompleto.Substring(0, nomecompleto.IndexOf(" ")));
        // chama a string até a primeira ocorrencia definida

        sobrenome = nomecompleto.Substring(nomecompleto.IndexOf(" ") +1);
        sobrenome2 = nomecompleto.Substring(7, 11);


        Console.WriteLine(sobrenome);
        Console.WriteLine(sobrenome2);

        string[] array = nomecompleto.Split('2');

        Console.ReadLine();

    }
}
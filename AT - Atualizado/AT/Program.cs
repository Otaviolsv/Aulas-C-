
//EX1
//class Ex1
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("olá, meu nome é otávio vasconcelos");
//        Console.WriteLine("nasci em 09/08/2002 e estou aprendendo c#");
//    }
//}


//EX2
//class Ex2
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Digite seu nome completo: ");
//        string nome = Console.ReadLine();
//        char[] letrasAlteradas = new char[nome.Length];

//        for (int i = 0; i < nome.Length; i++)
//        {
//            char letra = nome[i];

//            if (char.IsLetter(letra))
//            {
//                char baseLetra = char.IsUpper(letra) ? 'A' : 'a';
//                letra = (char)(baseLetra + (letra - baseLetra + 2) % 26);
//            }

//            letrasAlteradas[i] = letra;
//        }

//        string resultado = new string(letrasAlteradas);
//        Console.WriteLine("Saída: " + resultado);
//    }
//}

//EX3
//class Ex3
//{
//    static void Main(string[] args)
//    {

//        //Entrada do usuário
//        Console.WriteLine("Informe o primeiro número");
//        int n1 = int.Parse(Console.ReadLine());
//        Console.WriteLine("Informe o segundo número");
//        int n2 = int.Parse(Console.ReadLine());

//        Console.WriteLine("Escolha uma operação matemática: [Soma(1), Subtracao(2), Multiplicacao(3) ou Divisao(4)]");
//        String operacao = Console.ReadLine();

//        int resultado = 0;

//        //Condicionais validando a operacao
//        if (operacao.Equals("1"))
//        {
//            Console.WriteLine("");
//            resultado = n1 + n2;
//            Console.WriteLine($"{n1} + {n2} = {resultado}");
//        }
//        else if (operacao.Equals("2"))
//        {
//            Console.WriteLine("");
//            resultado = n1 - n2;
//            Console.WriteLine($"{n1} - {n2} = {resultado}");
//        }
//        else if (operacao.Equals("3"))
//        {
//            Console.WriteLine("");
//            resultado = n1 * n2;
//            Console.WriteLine($"{n1} x {n2} = {resultado}");
//        }
//        else if (operacao.Equals("4"))
//        {
//            if (n2 == 0)
//            {
//                Console.WriteLine("");
//                Console.WriteLine("Não é possível dividir por zero");
//            }
//            else
//            {
//                Console.WriteLine("");
//                resultado = n1 / n2;
//                Console.WriteLine($"{n1} / {n2} = {resultado}");
//            }
//        }
//        //Feedback informando valor invalido de operacao
//        else
//        {
//            Console.WriteLine("");
//            Console.WriteLine("Operacao invalida, tente novamente!");
//        }
//    }
//}

//EX4
//class Ex4
//{
//    static void Main(string[] args)
//    {
//        //Entrada do usuário
//        Console.WriteLine("Informe o dia do seu aniversário");
//        var diaAniversario = int.Parse(Console.ReadLine());
//        Console.WriteLine("Informe o mês do seu aniversário");
//        var mesAniversario = int.Parse(Console.ReadLine());
//        Console.WriteLine("Informe o ano do seu aniversário");
//        var anoAniversario = int.Parse(Console.ReadLine());

//        var dataAtual = DateTime.Today;
//        var anoAtual = dataAtual.Year;

//        //Data de aniversario do ano atual
//        var aniversarioAtual = new DateTime(anoAtual, mesAniversario, diaAniversario);


//        //Se o aniversário já passou esse ano, adiciona mais um ano para o aniversarioAtual
//        if (aniversarioAtual < dataAtual)
//        {
//             aniversarioAtual = aniversarioAtual.AddYears(1);
//        }

//        var diasRestantes = (aniversarioAtual - dataAtual).TotalDays;

//        Console.WriteLine("");
//        Console.WriteLine($"Faltam {(int)diasRestantes} para o seu aniversario!");

//        //Mensagem especial se faltar menos de 7 dis para o aniversário
//        if ((int)diasRestantes > 0 && (int)diasRestantes < 7)
//        {
//            Console.WriteLine("Wow seu aniversário está bem próximo!");
//        }
//        //Mensagem especial se o aniversário for hoje 
//        else if ((int)diasRestantes == 0)
//        {
//            Console.WriteLine("Parabéns hoje é o seu aniversário!");
//        }

//    }
//}

//Ex5
//class Ex5
//{
//    static void Main(string[] args)
//    {

//        //Entrada solicitando a data atual para o usuário
//        Console.WriteLine("Digite a data atual (dd/MM/yyyy):");
//        var dataEntrada = DateTime.Parse(Console.ReadLine());

//        //Variavel com a data atual
//        var dataAtual = DateTime.Today;

//        //Definido a data da formatura
//        DateTime dataFormatura = new DateTime(2026, 12, 15);

//        //Condicional que trata caso o usuário informe a data superior a real data atual do sistema
//        if (dataEntrada > dataAtual)
//        {
//            Console.WriteLine("");
//            Console.WriteLine($"Atenção: A data atual informada é no futuro!");
//        }

//        //Variavel com o total de dias restantes para a formatura
//        var tempoRestante = (dataFormatura - dataEntrada).TotalDays;

//        //Transformando total de dias até a formatura em anos, meses e dias
//        int anos = (int)tempoRestante / 365;
//        int meses = ((int)tempoRestante % 365) / 30;
//        int dias = ((int)tempoRestante % 365) % 30;

//        //Condicionais para informar ao usuário se ele já deveria estar formado ou quanto tempo falta até a formatura e a mensagem especial caso falte menos de 6 meses até a formatura
//        if (dataEntrada > dataFormatura)
//        {
//            Console.WriteLine("");
//            Console.WriteLine($"Você já deveria estar formado na data {dataEntrada}");
//        }
//        else
//        {
//            Console.WriteLine("");
//            Console.WriteLine($"Faltam {anos} anos, {meses} meses e {dias} dias para sua formatura na data {dataFormatura.ToString("dd/MM/yyyy")}!");

//            if (anos == 0 && meses < 6)
//            {
//                Console.WriteLine("");
//                Console.WriteLine("A reta final chegou! Prepare-se para a formatura!");

//            }
//        }
//    }
//}

//Ex6
//class Ex6
//{
//    Classe Aluno com os atributos solicitados
//    class Aluno
//    {
//        public String nome;
//        public int matricula;
//        public String curso;
//        public double mediaNotas;

//        Metodo para exibir os dados da classe Aluno
//        public void ExibirDados()
//        {
//            Console.WriteLine($"Nome: {nome}");
//            Console.WriteLine($"Matrícula: {matricula}");
//            Console.WriteLine($"Curso: {curso}");
//            Console.WriteLine($"Média Notas: {mediaNotas}");
//        }

//        Metodo utilizando condicional se a nota for menor que 7 reprovado se não aprovado. 
//        public String VerificarAprovacao()
//        {
//            String resultado;
//            if (mediaNotas >= 7)
//            {
//                 resultado = "Aprovado";
//            }
//            else {
//                resultado = "Reprovado";
//            }
//            return resultado;
//        }

//    }
//    Criação de um objeto aluno1 
//    static void Main(string[] args)
//    {
//        Aluno aluno1 = new Aluno()
//        {
//            nome = "Otávio Vasconcelos",
//            matricula = 12345,
//            curso = "Engenharia de Software",
//            mediaNotas = 10
//        };

//        aluno1.ExibirDados();
//        Console.WriteLine($"Resultado: {aluno1.VerificarAprovacao()}");
//    }
//}

////Ex7
//class Ex7
//{
//    //Classe com os atributos solicitados
//    class ContaBancaria
//    {
//        public String titular;
//        private decimal saldo;

//        //Metodo para depositar valor (adicionar o "valor" ao "saldo")
//        public void Depositar(decimal valor)
//        {
//            //Condicional para somente depositar caso o valor for maior que 0
//            if (valor <= 0)
//            {
//                Console.WriteLine("");
//                Console.WriteLine($"Deposito de R${valor} inválido, o valor precisa ser maior que zero!");
//            }
//            else
//            {
//                saldo = saldo + valor;
//                Console.WriteLine("");
//                Console.WriteLine($"Deposito de R${valor} realizado!");
//            }
//        }
//        //Metodo para sacar valor (subtrair o "valor" do "saldo")
//        public void Sacar(decimal valor)
//        {
//            //Condicional para somente sacar se valor for menor ou igual ao saldo
//            if (valor > saldo)
//            {
//                Console.WriteLine("");
//                Console.WriteLine($"Saque de R${valor} inválido, saldo insuficiente!");
//            }
//            else
//            {
//                saldo = saldo - valor;
//                Console.WriteLine("");
//                Console.WriteLine($"Saque de R${valor} realizado!");
//            }
//        }
//        //Metodo para exibir o saldo atual
//        public void ExibirSaldo()
//        {
//            Console.WriteLine("");
//            Console.WriteLine($"Saldo atual: R${saldo}");
//        }
//    }
//    static void Main(string[] args)
//    {
//        ContaBancaria conta1 = new ContaBancaria()
//        {
//            titular = "Otávio Vasconcelos"
//            //exemplo de uso de alterar o saldo manualmente erro(inacessível)
//            //saldo = 1000
//        };

//        //Simulando transações 
//        Console.WriteLine($"Titular: {conta1.titular}");
//        conta1.Depositar(500);
//        conta1.ExibirSaldo();
//        conta1.Sacar(800);
//        conta1.Sacar(260);
//        conta1.ExibirSaldo();

//    }
//}

//Ex8

//class Ex8
//{
//    //Classe funcionario com os atributos solicitados
//    class Funcionario
//    {
//        public String nome;
//        public String cargo;
//        public double salarioBase;

//        //Metodo virtual para retornar o salario que permite ser sobrescrito
//        public virtual double Salario()
//        {
//            return salarioBase;
//        }

//        //Metodo para exibir os dados do funcionario 
//        public void ExibirDados()
//        {
//            Console.WriteLine($"Nome: {nome}");
//            Console.WriteLine($"Cargo: {cargo}");
//            Console.WriteLine($"Salario: R${Salario()}");
//        }
//    }

//    //Subclasse gerente 
//    class Gerente : Funcionario
//    {
//        //Subscreve o metodo Salario adicionando 20% ao salarioBase
//        public override double Salario()
//        {
//            return salarioBase = salarioBase + (salarioBase * 0.20);
//        }

//    }
//    static void Main(string[] args)
//    {
//        //Criação de objeto para funcionario
//        Funcionario funcionario1 = new Funcionario() 
//        { 
//            nome = "Otávio Vasconcelos",
//            cargo = "Assistente",
//            salarioBase = 1500
//        };
//        //Criação de objeto para gerente
//        Gerente funcionario2 = new Gerente() 
//        { 
//          nome = "Anderson Barbosa",
//          cargo = "Gerente TI",
//          salarioBase = 1500
//        };

//        funcionario1.ExibirDados();
//        Console.WriteLine("");
//        funcionario2.ExibirDados();
//    }
//}

//Ex9
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

//class Ex9
//{
//    //Classe com atributos array solicitados, nome do arquivo.txt e contador para contabilizar o número de contatos
//    class Contatos
//    {
//        private const string arquivo = "contatos.txt";

//        public String[] nome = new string[5];
//        public int[] telefone = new int[5];
//        public double[] email = new double[5];
//        private int contador = 0;

//        //Metodo utilizando laço de repetição while para permanecer na tela de Menu no console até o break
//        public void Menu()
//        {
//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("Gerenciamento de Estoque");
//                Console.WriteLine("\n1.Inserir Produto");
//                Console.WriteLine("2.Listar Contatos");
//                Console.WriteLine("3.Sair");
//                Console.WriteLine("");

//                int opcao = int.Parse(Console.ReadLine());

//                //Condicional se o usuário escolher a opção 1
//                if (opcao == 1)
//                {
//                    //Condicional para exibir mensagem se existirem 5 contatos cadastrados
//                    if (contador >= 5)
//                    {
//                        Console.Clear();
//                        Console.WriteLine("Número de contatos chegou no seu limite!");
//                        Thread.Sleep(5000);
//                        Console.Clear();
//                        continue;
//                    }
//                    //Se ainda não existirem 5 contatos cadastrados solicita os dados para copular os arrays
//                    else
//                    {
//                        Console.Clear();
//                        Console.WriteLine("Inserindo produto");

//                        Console.WriteLine("\nDigite o nome do produto:");
//                        nome[contador] = Console.ReadLine();
//                        Console.WriteLine("\nDigite a telefone do produto:");
//                        telefone[contador] = int.Parse(Console.ReadLine());
//                        Console.WriteLine("\nDigite o preço unitario do produto:");
//                        email[contador] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//                        Console.WriteLine("");

//                        //StreamWriter para inserir os dados no arquivo contatos.txt
//                        using (StreamWriter writer = File.AppendText(arquivo))
//                        {

//                            writer.WriteLine($"{nome[contador]},{telefone[contador]},{email[contador].ToString("0.00", CultureInfo.InvariantCulture)}");
//                        }

//                        //Adiciona +1 ao contador e continua para a repetição do while no Menu
//                        contador++;
//                        continue;
//                    }

//                }
//                //Condicional se o usuário escolher a opção 2
//                if (opcao == 2)
//                {
//                    //Laço de repetição while para permanecer na lista de contatos no console até o break
//                    while (true)
//                    {
//                        Console.Clear();
//                        Console.WriteLine("Lista de contatos:");
//                        Console.WriteLine("");

//                        //Laço de repetição for para exibir os arrays dos contatos no console até o número do contador
//                        for (int i = 0; i < contador; i++)
//                        {
//                            Console.WriteLine($"{i + 1}. Nome:{nome[i]} | Quantidade:{telefone[i]} | Preço: R${email[i]}");
//                            Console.WriteLine("");
//                        }

//                        Console.WriteLine("Digite 3 se deseja voltar para o menu");
//                        int opcao2 = int.Parse(Console.ReadLine());

//                        //Condicional se o usuário não escolher a opção 3 continua na tela de lista
//                        if (opcao2 != 3)
//                        {
//                            continue;
//                        }
//                        //Se o usuário escolher a opção 3 sai do laço de repetição da lista de contatos e volta para o Menu
//                        else
//                        {
//                            break;
//                        }
//                    }
//                }
//                //Condicional se o usuário escolher a opção 3 sai do laço de repetição do Menu
//                if (opcao == 3)
//                {
//                    break;
//                }
//            }

//            Console.Clear();
//            Console.WriteLine("Adeus!");
//        }

//        static void Main(string[] args)
//        {
//            //Condicional se não existir o arquivo, criar arquivo
//            //Exemplo endereço de aquivo:  C:\Users\Otávio\source\repos\AT\AT\bin\Debug\net8.0\contatos.txt
//            if (!File.Exists(arquivo))
//            {
//                using (File.Create(arquivo)) { }
//            }

//            //Criando objeto contatos
//            Contatos contatos = new Contatos();

//            //Chamando o metodo Menu de contatos
//            contatos.Menu();
//        }
//    }
//}

//Ex10
//class Ex10
//{
//    static void Main(string[] args)
//    {
//        //Utilizando a class Random crio uma variavel que armazena um número no intervalo entre 1 e 51 (o 51 não é incluído)
//        Random aleatorio = new Random();
//        int numeroAleatorio = aleatorio.Next(1, 51);
//        int tentativas = 0;

//        Console.WriteLine("Jogo de Adivinhação");

//        //Utilizando o while para permanecer na repetição enquanto o número de tentativas for menor que 5
//        while (tentativas < 5)
//        {
//            Console.WriteLine("\nTente adivinhar o número secreto de 1 a 50:");
//            int numero = int.Parse(Console.ReadLine());

//            //Condicional para exibir mensagem caso o número digitado não pertencer ao grupo de números no intervalo entre 1 e 51
//            if (numero <= 0 || numero > 50)
//            {
//                Console.WriteLine("\nNúmero invalido, tente novamente");
//                continue;
//            }
//            else
//            {
//                //Condicionais para exibir a mensagem correta caso o usuário acerte ou erre, se errar adiciona +1 ao total de tentativas
//                if (numero == numeroAleatorio)
//                {
//                    Console.WriteLine("\nParabéns, você acertou!");
//                    return;
//                }
//                else
//                {
//                    Console.WriteLine("\nVocê Errou!");
//                    tentativas++;

//                    //Se ainda existirem tentativas restantes exibir a respectiva dica 
//                    if(tentativas < 5) 
//                    {
//                        if (numeroAleatorio > numero)
//                        {
//                            Console.WriteLine($"Dica: o número secreto é maior que {numero}, você ainda tem {5 - tentativas} tentativas restantes");
//                            continue;
//                        }
//                        else if (numeroAleatorio < numero)
//                        {
//                            Console.WriteLine($"Dica: o número secreto é menor que {numero}, você ainda tem {5 - tentativas} tentativas restantes");
//                            continue;
//                        }
//                       //Se não existir nenhuma tentativa restante, exibir mensagem de derrota
//                    }
//                    else
//                    {
//                        Console.WriteLine($"\nVocê Perdeu! o número secreto era o {numeroAleatorio}");
//                    }

//                }
//            }
//        }
//    }
//}

//Ex11

//class Ex11
//{
//    //Classe com atributos array solicitados, nome do arquivo.txt e contador para contabilizar o número de contatos
//    class Contatos
//    {
//        private const string arquivo = "Contatos.txt";

//        public String[] nome = new string[30];
//        public String[] telefone = new String[30];
//        public String[] email = new String[30];
//        private int contador = 0;

//        //Metodo utilizando laço de repetição while para permanecer na tela de Menu no console até o break
//        public void Menu()
//        {
//            //Condicional se existir arquivo
//            if (File.Exists(arquivo))
//            {
//                //StreamReade para abrir o arquivo para leitura
//                using (StreamReader reader = new StreamReader(arquivo))
//                {
//                    string linha;

//                    //Laço de repetição while para ler arquivo até o final (null) 
//                    while ((linha = reader.ReadLine()) != null)
//                    {
//                        //Utilizando o Split para separar os dados por ,
//                        string[] dados = linha.Split(',');

//                        //Condicional se a linha conter 3 elementos, armazena os dados nos arrays e incrementa o contador
//                        if (dados.Length == 3)
//                        {
//                            nome[contador] = dados[0];
//                            telefone[contador] = dados[1];
//                            email[contador] = dados[2];
//                            contador++;
//                        }
//                    }
//                }
//            }
//                while (true)
//                {
//                    Console.WriteLine("=== Gerenciador de Contatos ===");
//                    Console.WriteLine("\n1 - Adicionar novo contato");
//                    Console.WriteLine("2 - Listar contatos cadastrados");
//                    Console.WriteLine("3 - Sair");
//                    Console.WriteLine("");

//                    int opcao = int.Parse(Console.ReadLine());

//                    //Condicional se o usuário escolher a opção 1
//                    if (opcao == 1)
//                    {

//                        Console.WriteLine("\nInserindo produto");

//                        Console.WriteLine("\nDigite o nome do contato:");
//                        nome[contador] = Console.ReadLine();
//                        Console.WriteLine("\nDigite a telefone do contato:");
//                        telefone[contador] = Console.ReadLine();
//                        Console.WriteLine("\nDigite o e-mail do contato:");
//                        email[contador] = Console.ReadLine();
//                        Console.WriteLine("");

//                        //StreamWriter para inserir os dados no arquivo contatos.txt
//                        using (StreamWriter writer = File.AppendText(arquivo))
//                        {

//                            writer.WriteLine($"{nome[contador]},{telefone[contador]},{email[contador]}");
//                        }

//                        //Adiciona +1 ao contador e continua para a repetição do while no Menu
//                        contador++;
//                        continue;


//                    }
//                    //Condicional se o usuário escolher a opção 2
//                    if (opcao == 2)
//                    {
//                        //Laço de repetição while para permanecer na lista de contatos no console até o break
//                        while (true)
//                        {
//                            Console.WriteLine("=== Contatos cadastrados: === ");
//                            Console.WriteLine("");

//                            //Laço de repetição for para exibir os arrays dos contatos no console até o número do contador
//                            for (int i = 0; i < contador; i++)
//                            {
//                                Console.WriteLine($"{i + 1}. Nome:{nome[i]} | Telefone:{telefone[i]} | E-mail:{email[i]}");
//                                Console.WriteLine("");
//                            }

//                            Console.WriteLine("Digite 3 se deseja voltar para o menu");
//                            int opcao2 = int.Parse(Console.ReadLine());

//                            //Condicional se o usuário não escolher a opção 3 continua na tela de lista
//                            if (opcao2 != 3)
//                            {
//                                continue;
//                            }
//                            //Se o usuário escolher a opção 3 sai do laço de repetição da lista de contatos e volta para o Menu
//                            else
//                            {
//                                Console.WriteLine("");
//                                break;
//                            }
//                        }
//                    }
//                    //Condicional se o usuário escolher a opção 3 sai do laço de repetição do Menu
//                    if (opcao == 3)
//                    {
//                        break;
//                    }
//                }

//                Console.WriteLine("\nAdeus!");
//            }

//            static void Main(string[] args)
//            {
//                //Condicional se não existir o arquivo, criar arquivo
//                //Exemplo endereço de aquivo:  C:\Users\Otávio\source\repos\AT\AT\bin\Debug\net8.0\contatos.txt
//                if (!File.Exists(arquivo))
//                {
//                    using (File.Create(arquivo)) { }
//                }

//                //Criando objeto contatos
//                Contatos contatos = new Contatos();

//                //Chamando o metodo Menu de contatos
//                contatos.Menu();
//            }
//        }
//    }

class Ex12
{
    //Classe com atributos array solicitados, nome do arquivo.txt e contador para contabilizar o número de contatos
    class Contatos
    {
        private const string arquivo = "Contatos.txt";

        public String[] nome = new string[30];
        public String[] telefone = new String[30];
        public String[] email = new String[30];
        private int contador = 0;

        class Markdown : Contatos {
            public override void FormatoContatos()
            {
                while (true)
                {
                    Console.WriteLine("## Lista de Contatos");
                    Console.WriteLine("");

                    //Laço de repetição for para exibir os arrays dos contatos no console até o número do contador
                    for (int i = 0; i < contador; i++)
                    {
                        Console.WriteLine($"{i + 1}. Nome:{nome[i]} | Telefone:{telefone[i]} | E-mail:{email[i]}");
                        Console.WriteLine("");
                    }

                    Console.WriteLine("Digite 4 se deseja voltar para o menu");
                    int opcao2 = int.Parse(Console.ReadLine());

                    //Condicional se o usuário não escolher a opção 4 continua na tela de lista
                    if (opcao2 != 4)
                    {
                        continue;
                    }
                    //Se o usuário escolher a opção 4 sai do laço de repetição da lista de contatos e volta para o Menu
                    else
                    {
                        Console.WriteLine("");
                        break;
                    }
                }
            }
        }
        public virtual void FormatoContatos()
        {
            //Laço de repetição while para permanecer na lista de contatos no console até o break
            while (true)
            {
                Console.WriteLine("=== Lista de Contatos: === ");
                Console.WriteLine("");

                //Laço de repetição for para exibir os arrays dos contatos no console até o número do contador
                for (int i = 0; i < contador; i++)
                {
                    Console.WriteLine($"{i + 1}. Nome:{nome[i]} | Telefone:{telefone[i]} | E-mail:{email[i]}");
                    Console.WriteLine("");
                }

                Console.WriteLine("Digite 4 se deseja voltar para o menu");
                int opcao2 = int.Parse(Console.ReadLine());

                //Condicional se o usuário não escolher a opção 4 continua na tela de lista
                if (opcao2 != 4)
                {
                    continue;
                }
                //Se o usuário escolher a opção 4 sai do laço de repetição da lista de contatos e volta para o Menu
                else
                {
                    Console.WriteLine("");
                    break;
                }
            }
        }


        //Metodo para verificar se existe arquivo
        public void VerificarArquivo()
        {
            //Condicional se não existir o arquivo, criar arquivo
            //Exemplo endereço de aquivo:  C:\Users\Otávio\source\repos\AT\AT\bin\Debug\net8.0\contatos.txt
            if (!File.Exists(arquivo))
            {
                using (File.Create(arquivo)) { }
            }
            //Condicional se existir arquivo
            else if (File.Exists(arquivo))
            {
                //StreamReade para abrir o arquivo para leitura
                using (StreamReader reader = new StreamReader(arquivo))
                {
                    string linha;

                    //Laço de repetição while para ler arquivo até o final (null) 
                    while ((linha = reader.ReadLine()) != null)
                    {
                        //Utilizando o Split para separar os dados por ,
                        string[] dados = linha.Split(',');

                        //Condicional se a linha conter 3 elementos, armazena os dados nos arrays e incrementa o contador
                        if (dados.Length == 3)
                        {
                            nome[contador] = dados[0];
                            telefone[contador] = dados[1];
                            email[contador] = dados[2];
                            contador++;
                        }
                    }
                }
            }
        }

        //Metodo utilizando laço de repetição while para permanecer na tela de Menu no console até o break
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("=== Gerenciador de Contatos ===");
                Console.WriteLine("\n1 - Adicionar novo contato");
                Console.WriteLine("2 - Listar contatos cadastrados");
                Console.WriteLine("3 - Alterar o formato da lista de contatos");
                Console.WriteLine("4 - Sair");
                Console.WriteLine("");

                int opcao = int.Parse(Console.ReadLine());

                //Condicional se o usuário escolher a opção 1
                if (opcao == 1)
                {

                    Console.WriteLine("\nInserindo produto");

                    Console.WriteLine("\nDigite o nome do contato:");
                    nome[contador] = Console.ReadLine();
                    Console.WriteLine("\nDigite a telefone do contato:");
                    telefone[contador] = Console.ReadLine();
                    Console.WriteLine("\nDigite o e-mail do contato:");
                    email[contador] = Console.ReadLine();
                    Console.WriteLine("");


                    using (StreamWriter writer = File.AppendText(arquivo))
                    {

                        writer.WriteLine($"{nome[contador]},{telefone[contador]},{email[contador]}");
                    }


                    //Adiciona +1 ao contador e continua para a repetição do while no Menu
                    contador++;
                    continue;


                }
                //Condicional se o usuário escolher a opção 2
                if (opcao == 2)
                {
                  //Add metodo aqui
                  this.FormatoContatos();
                }
                if (opcao == 3)
                {
                    while (true)
                    {
                        Console.WriteLine("\nEscolha o tipo de formato:");
                        Console.WriteLine("\n[1.Markdown]");
                        Console.WriteLine("[2.Tabela]");
                        Console.WriteLine("[3.Texto Puro]");

                        Console.WriteLine("Digite 4 se deseja voltar para o menu");
                        int opcao2 = int.Parse(Console.ReadLine());

                        if (opcao2 == 1)
                        {

                           Markdown markdown = new Markdown();
                           markdown.FormatoContatos();
                           break;
                        }
                        //Condicional se o usuário não escolher a opção 4 continua na tela de lista
                        if (opcao2 != 4)
                        {
                            continue;
                        }
                        //Se o usuário escolher a opção 4 sai do laço de repetição da lista de contatos e volta para o Menu
                        else
                        {
                            Console.WriteLine("");
                            break;
                        }
                    }

                }
                //Condicional se o usuário escolher a opção 3 sai do laço de repetição do Menu
                if (opcao == 4)
                {
                    break;
                }
            }

            Console.WriteLine("\nAdeus!");
        }

        static void Main(string[] args)
        {

            Contatos contatos = new Contatos();

            //Chamando os metodos de contatos
            contatos.VerificarArquivo();
            contatos.Menu();
        }
    }
}
namespace firstProject;

class Program
{
    public void Exercicio1()
    {
        Console.WriteLine("Digite seu nome: ");

        string nome = Console.ReadLine();

        Console.WriteLine($"Olá, {nome} Seja muito bem-vindo!");

    }
    public void Exercicio2()
    {

        Console.WriteLine("Digite seu nome: ");

        string nome = Console.ReadLine();

        Console.WriteLine("Digite seu sobrenome: ");

        string sobrenome = Console.ReadLine();

        Console.WriteLine($"seu nome completo é: {nome} {sobrenome} ");

    }
    public void Exercicio3()
    {
        double valor1 = 20, valor2 = 2, soma, subtracao, multiplicacao, divisao, media;

        soma = valor1 + valor2;
        subtracao = valor1 - valor2;
        multiplicacao = valor1 * valor2;
        media = (valor1 + valor2) / 2;

        Console.WriteLine($"soma: de {valor1} + {valor2} = {soma}");
        Console.WriteLine($"subtração: de {valor1} - {valor2} = {subtracao}");
        Console.WriteLine($"multiplicação: de {valor1} * {valor2} = {multiplicacao}");

        if (valor2 != 0)
        {
            divisao = valor1 / valor2;
            Console.WriteLine($"Divisão: {valor1} / {valor2} = {divisao}");
        }
        else
        {
            Console.WriteLine("Erro: divisão por zero não é permitida.");
        }

        Console.WriteLine($"media: de {valor1} e {valor2} = {media}");
    }
    public void Exercicio4()
    {
        
        Console.WriteLine("Digite uma palavra: ");
        string palavra = Console.ReadLine();

        string palavraSemEspacos = palavra.Replace(" ", "");

        Console.WriteLine("A quantidade de caracteres é: " + palavraSemEspacos.Length);
    }
    public void Exercicio5()
    {
        Console.Write("Digite uma placa: ");
        string placa = Console.ReadLine()?.ToUpper(); 

        bool placaValida = placa != null &&
                           placa.Length == 7 &&
                           placa.Take(3).All(char.IsLetter) && 
                           placa.Skip(3).All(char.IsDigit);  

        Console.WriteLine(placaValida ? "Verdadeiro" : "Falso");
    }
    public void Exercicio6()
    {
        Console.WriteLine("Escolha o formato de exibição da data:");
        Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
        Console.WriteLine("2 - Apenas a data (dd/MM/yyyy)");
        Console.WriteLine("3 - Apenas a hora (HH:mm:ss)");
        Console.WriteLine("4 - Data com o mês por extenso");
        Console.Write("Digite a opção desejada: ");

        string opcao = Console.ReadLine();
        DateTime dataAtual = DateTime.Now;

        switch (opcao)
        {
            case "1":
                Console.WriteLine($"Formato completo: {dataAtual:dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss}");
                break;
            case "2":
                Console.WriteLine($"Apenas a data: {dataAtual:dd/MM/yyyy}");
                break;
            case "3":
                Console.WriteLine($"Apenas a hora: {dataAtual:HH:mm:ss}");
                break;
            case "4":
                Console.WriteLine($"Data com mês por extenso: {dataAtual:dd 'de' MMMM 'de' yyyy}");
                break;
            default:
                Console.WriteLine("Opção inválida. Escolha um número entre 1 e 4.");
                break;
        }
    }
    static void Main()
    {
        Program program = new Program();

        Console.WriteLine("qual exercicio deseja executar? ");
        Console.WriteLine("\n1 - 2 - 3 - 4 - 5 - 6");

        int exercicio = int.Parse(Console.ReadLine());

        switch (exercicio)
        {
            case 1:
                program.Exercicio1();
                break;
            case 2:
                program.Exercicio2();
                break;
            case 3:
                program.Exercicio3();
                break;
            case 4:
                program.Exercicio4();
                break;
            case 5:
                program.Exercicio5();
                break;
            case 6:
                program.Exercicio6();
                break;
            default:
                Console.WriteLine("Exercicio não encontrado");
                break;
        }
    }
}

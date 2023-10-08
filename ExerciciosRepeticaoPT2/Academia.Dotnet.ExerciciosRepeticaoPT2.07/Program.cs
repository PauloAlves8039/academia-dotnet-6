internal class Program
{
    /*
    * 7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
    * A cada solicitação, teste se o usuário informou um valor válido. 
    * Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
    * informe que ele está incorreto e saia do programa em VS. 
    * Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
    * informe que está errada e saia. Se estiver correta, solicite o salário. 
    * Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
    * Se estiver correto, mostre todos os valores lidos.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Verificar Dados *****");

        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Digite o salário: ");
        double salario = double.Parse(Console.ReadLine());

        ValidarNome(nome);
        ValidarIdade(idade);
        ValidarSalario(salario);
        ExibirValores(nome, idade, salario);

        Console.ReadKey();
    }

    private static void ValidarNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome) || int.TryParse(nome, out _))
        {
            Console.WriteLine("Nome incorreto. Programa encerrado.");
        }
    }


    private static void ValidarIdade(int idade) 
    {
        if (idade <= 0)
        {
            Console.WriteLine("Idade incorreta. Programa encerrado.");
        }
    }

    private static void ValidarSalario(double salario) 
    {
        if (salario <= 0) 
        {
            Console.WriteLine("Salário incorreto. Programa encerrado.");
        }
        
    }

    private static void ExibirValores(string nome, int idade, double salario) 
    {
        Console.WriteLine("\nValores lidos:");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Salário: {salario}");
    }
}
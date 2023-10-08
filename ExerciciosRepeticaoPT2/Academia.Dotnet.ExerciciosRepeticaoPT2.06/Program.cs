internal class Program
{
    private static void Main(string[] args)
    {
        int idade;
        do
        {
            Console.Write("Digite a idade: ");
            idade = int.Parse(Console.ReadLine());

        } while (!VerificarIdade(idade));

        Console.ReadKey();
    }

    private static bool VerificarIdade(int idade) 
    {
        if (idade <= 0)
        {
            Console.WriteLine("Idade inválida - informe uma idade acima de zero.");
            return false;
        }
        else 
        {
            Console.WriteLine($"Idade digitada: {idade}");
            return true;
        }
    }
}
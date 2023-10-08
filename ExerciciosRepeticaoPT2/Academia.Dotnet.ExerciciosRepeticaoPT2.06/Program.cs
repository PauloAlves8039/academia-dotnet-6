internal class Program
{
    /*
     * 6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
     * ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
     * Ao final, mostre a idade digitada.
    */

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
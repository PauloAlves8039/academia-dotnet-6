internal class Program
{
    /*
     * 20. Foi realizada uma pesquisa de algumas características físicas da população de uma 
     * certa região, a qual coletou os seguintes dados referentes a cada habitante para 
     * serem analisados:
     * - sexo (masculino e feminino)
     * - cor dos olhos (azuis, verdes ou castanhos)
     * - cor dos cabelos ( louros, castanhos, pretos)
     * - idade 
 
     * Faça um algoritmo que determine e escreva: 
 
     * - a maior idade dos habitantes
     * - a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
     * e que tenham olhos verdes e cabelos louros.
     * O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Características Físicas da População *****");

        int maiorIdade = -1;
        int contadorFemininoVerdesLouros = 0;

        while (true)
        {
            char sexo = VerificarSexo();
            char corDosOlhos = VerificarCorDosOlhos();
            char corDosCabelos = VerificarCorDosCabelos();
            int idade = VerificarIdade();

            if (idade == -1) 
            {
                break;
            }

            if (idade > maiorIdade)
            {
                maiorIdade = idade;
            }

            if (sexo == 'F' && idade >= 18 && idade <= 35 && corDosOlhos == 'V' && corDosCabelos == 'L')
            {
                contadorFemininoVerdesLouros++;
            }
        }
        Console.WriteLine("\n-------- Resultado --------");
        Console.WriteLine($"Maior idade: {maiorIdade} anos.");
        Console.WriteLine($"Quantidade de indivíduos do sexo feminino com idade entre 18 e 35 anos, olhos verdes e cabelos louros: {contadorFemininoVerdesLouros}");

        Console.ReadKey();
    }

    private static char VerificarSexo()
    {
        while (true)
        {
            Console.Write("Informe o sexo (M/F): ");
            char sexo = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (sexo == 'M' || sexo == 'F')
            {
                return sexo;
            }
            else
            {
                Console.WriteLine("Sexo inválido. Informe M para masculino ou F para feminino.");
            }
        }
    }

    private static char VerificarCorDosOlhos()
    {
        while (true)
        {
            Console.Write("Informe a cor dos olhos (A - Azuis, V - Verdes, C - Castanhos): ");
            char corDosOlhos = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (corDosOlhos == 'A' || corDosOlhos == 'V' || corDosOlhos == 'C')
            {
                return corDosOlhos;
            }
            else
            {
                Console.WriteLine("Cor dos olhos inválida. Informe A para azuis, V para verdes ou C para castanhos.");
            }
        }
    }

    private static char VerificarCorDosCabelos()
    {
        while (true)
        {
            Console.Write("Informe a cor dos cabelos (L - Louros, C - Castanhos, P - Pretos): ");
            char corDosCabelos = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (corDosCabelos == 'L' || corDosCabelos == 'C' || corDosCabelos == 'P')
            {
                return corDosCabelos;
            }
            else
            {
                Console.WriteLine("Cor dos cabelos inválida. Informe L para louros, C para castanhos ou P para pretos.");
            }
        }
    }

    private static int VerificarIdade()
    {
        while (true)
        {
            Console.Write("Informe a idade (-1 para sair): ");
            int idade;

            if (int.TryParse(Console.ReadLine(), out idade))
            {
                return idade;
            }
            else
            {
                Console.WriteLine("Idade inválida. Informe um valor numérico válido.");
            }
        }
    }
}
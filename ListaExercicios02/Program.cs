namespace Exercício01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: \n");
            string frase = Console.ReadLine();
            Console.WriteLine();

            string[] palavras = frase.Split(' ');
            string[] palavrasTitleCase = new string[palavras.Length];

            for (int i = 0; i < palavras.Length; i++)
            {

                string primeiraLetra = palavras[i].Substring(0, 1).ToUpper();
                string restoDaPalavra = palavras[i].Substring(1);
                palavrasTitleCase[i] = primeiraLetra + restoDaPalavra;
            }

            string novaFrase = string.Join(" ", palavrasTitleCase);

            Console.WriteLine("Frase com as primeiras letras maiúsculas: \n");
            Console.WriteLine(novaFrase);

        }
    }
}
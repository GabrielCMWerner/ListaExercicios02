namespace Exercício03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cifra de Cezar");

            Console.WriteLine();

            Console.Write("Digite a frase que será codificada: ");
            string palavra = Convert.ToString(Console.ReadLine());

            Console.WriteLine(); Console.WriteLine();

            Console.Write("Digite o valor de 'X' para codificar a frase: ");
            int x = Convert.ToInt32(Console.ReadLine());

            char[] cifraSeparada = new char[palavra.Length];
            char[] letrasSeparadas = new char[palavra.Length];

            letrasSeparadas = palavra.ToCharArray();

            for (int i = 0; i < letrasSeparadas.Length; i++)
            {
                int letrasint = letrasSeparadas[i];

                int cifraint = letrasint + x;

                cifraSeparada[i] = Convert.ToChar(cifraint);

            }

            Console.WriteLine();
            string cifra = string.Join("", cifraSeparada);

            Console.Write("A frase após ser codificada é: ");

            Console.WriteLine(cifra);

            Console.ReadLine();

        }
    }
}
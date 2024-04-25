namespace VersionMoyenneIEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demande à l'utilisateur de saisir un entier n
            Console.WriteLine("Veuillez saisir un entier n :");
            int n = Convert.ToInt32(Console.ReadLine());

            // Génère un tableau de 10 nombres entiers aléatoires entre 1 et 100
            Random random = new Random();
            int[] tableau = Enumerable.Range(1, 10).Select(_ => random.Next(1, 101)).ToArray();

            // Affichage du tableau d'entiers
            Console.WriteLine("\nTableau d'entiers :");
            Console.WriteLine(string.Join(" ", tableau));

            // Calcul de la moyenne des éléments inférieurs ou égaux à n
            double moyenne = tableau.Where(x => x <= n).Average();

            // Affichage de la moyenne
            Console.WriteLine($"\nLa moyenne des éléments inférieurs ou égaux à {n} est : {moyenne}");

        }
    }
}

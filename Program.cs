namespace MoyenneNombreTableauInferieurAn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nous demandons à l'utilisateur de saisir la taille du tableau
            Console.WriteLine("Veuillez saisir la taille du tableau :");
            int taille = Convert.ToInt32(Console.ReadLine());

            // Nous demandons à l'utilisateur de saisir un entier n
            Console.WriteLine("Veuillez saisir un entier n :");
            int n = Convert.ToInt32(Console.ReadLine());

            // Nous allons procéder à la création d'un générateur de nombres aléatoires
            Random rnd = new Random();

            // Nous allons remplir le tableau avec les entiers aléatoires en tenant compte de la taille de tableau choisie par l'utilisateur
            int[] tableau = new int[taille];
            Console.WriteLine("\nTableau d'entiers :");
            for (int i = 0; i < taille; i++)
            {
                tableau[i] = rnd.Next(101); // remplissage du tableau avec des entiers aléatoires entre 0 et 100 inclus
                Console.Write(tableau[i] + " ");
            }
            Console.WriteLine();

            // Calcul de la moyenne des éléments inférieurs ou égaux à n précisé par l'utilisateur
            int somme = 0;
            int count = 0;
            foreach (int element in tableau)
            {
                if (element <= n)
                {
                    somme += element;
                    count++;
                }
            }

            // Vérification si le tableau contient des éléments inférieurs ou égaux à n
            if (count > 0)
            {
                double moyenne = (double)somme / count;
                Console.WriteLine($"\nLa moyenne des éléments inférieurs ou égaux à {n} est : {moyenne}");
            }
            else
            {
                Console.WriteLine($"\nIl n'y a aucun élément inférieur ou égal à {n} dans le tableau.");
            }
        }
    }
 
}

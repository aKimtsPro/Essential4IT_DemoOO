
// Ne peut pas etre instancié
// Ne peut pas contenir d'élément non static
// Ne peut pas être hérité
public static class ArrayUtils
{
    
    // Propriétés statiques
    public static int TailleParDefaut { get; set; } = 10;
    
    
    // Méthode pour afficher les éléments d'un tableau
    public static void Afficher(object[] tab)
    {
        foreach (int element in tab)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    // Méthode pour trouver le plus grand élément dans un tableau
    public static int TrouverValeur(object[] tab, object valeur)
    {
        for (int i = 0; i < tab.Length; i++)
        {
            if (tab[i] == valeur)
                return i;
        }

        return -1;
    }
    
    
}
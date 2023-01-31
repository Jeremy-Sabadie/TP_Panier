namespace TP_Panier;

internal class Cart
{
    public Guid Number { get; set; }
    public DateTime creation { get; set; }
    public List<Ligne> lignes = new List<Ligne>();

    public Cart()
    {
        this.creation = DateTime.Now;
        Number = new Guid();
    }
    /// <summary>
    /// Méthode pour ajouter l'article créé.
    /// </summary>
    /// <param name="article"></param>
    public void AddToCart(Article article)
    {

        Ligne ligne = lignes.FirstOrDefault(ligne => ligne.Article.Equals(article));
        if (ligne is not null)
        {
            ligne.Quantity += 1;
        }
        else
        {
            lignes.Add(new Ligne(article, 1));
        }
    }
    public void removeFromCart(Article article)
    {

        Ligne ligne = lignes.FirstOrDefault(ligne => ligne.Article.Equals(article));
        if (ligne is not null)
        {
            ligne.Quantity -= 1;
            {
                lignes.Remove(ligne);

            }
        }

        {
        }
    }
    /// <summary>
    /// Méthode qui parcourt la liste d'article et qui calcule son total.
    /// </summary>
    /// <returns></returns>
    public double TotalCalculate()
    {
        double Total = 0;

        for (int i = 0; i < lignes.Count; i++)
        {
            Total = Total + lignes[i].Article.Price * lignes[i].Quantity;
        }
        return Total;
    }
    public void CartPrint()
    {
        for (int i = 0; i < lignes.Count; i++)
        {
            Console.WriteLine($"{lignes[i].Article.Denomination}|prix:{lignes[i].Article.Price * lignes[i].Quantity} | référence:{lignes[i].Article.Ref}|");
        }
        Console.WriteLine($"total= {TotalCalculate()}€");
    }

    public override string? ToString()
    {
        return base.ToString();
    }
    public int NombreArticles()
    {
        return lignes.Count;
    }
}

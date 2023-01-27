namespace TP_Panier;

internal class Cart
{
    public Guid Number { get; set; }
    public DateTime creation { get; set; }
    public float Total { get; private set; }
    private List<Article> articles = new List<Article>();

    public Cart(Guid Number, DateOnly creation)
    {
        this.creation = DateTime.Now;
        Number = new Guid();
        this.articles = articles;
    }
    /// <summary>
    /// Méthode pour ajouter l'article créé.
    /// </summary>
    /// <param name="article"></param>
    public void AddToCart(Article article)
    {
        if (articles.Contains(article))
            articles.Add(article);

    }
    /// <summary>
    /// Méthode qui parcourt la liste d'article et qui calcule son total.
    /// </summary>
    /// <returns></returns>
    public double TotalCalculate()
    {
        double Total = 0;
        for (int i = 0; i < articles.Count; i++)
        {
            Total = Total + articles[i].Price;
        }
        return Total;
    }



}

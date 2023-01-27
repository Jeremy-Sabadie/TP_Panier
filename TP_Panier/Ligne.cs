namespace TP_Panier;

internal class Ligne
{
    public int Quantity { get; set; }
    public Article Article { get; set; }

    public Ligne(Article article, int quantity)
    {
        Quantity = quantity;
        Article = article;
    }
}

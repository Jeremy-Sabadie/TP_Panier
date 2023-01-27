namespace TP_Panier;

internal class Ligne
{
    public int Quantity { get; set; }
    public Article article { get; set; }

    public Ligne(Article articl, int quantity)
    {
        Quantity = quantity;
        this.article = article;
    }
}

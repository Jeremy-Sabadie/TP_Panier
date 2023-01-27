namespace TP_Panier
{
    internal class Article
    {
        public Article(int quantity, float price, string denomination)
        {
            Ref = new Guid();
            Quantity = quantity;
            Price = price;
            Denomination = denomination;

        }

        public string Denomination { get; set; }
        public Guid Ref { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Article article &&
                   Ref.Equals(article.Ref);
        }
    }
}

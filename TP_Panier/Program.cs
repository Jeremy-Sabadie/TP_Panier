using TP_Panier;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Cart C1 = new Cart();
Article A1 = new Article(1, 12.5f, "steak");
Article A2 = new Article(1, 22.70f, "Bannanes");
C1.AddToCart(A1);
C1.AddToCart(A2);
C1.TotalCalculate();
C1.CartPrint();
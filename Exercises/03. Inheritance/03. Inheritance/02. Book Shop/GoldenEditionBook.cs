public class GoldenEditionBook : Book
{
    //private string title;
    //private string author;
    //private decimal price;

    public GoldenEditionBook(string title, string author, decimal price) 
        :base(title, author, price)
    {
    }

    public override decimal Price
    {
        get { return base.Price * 1.3m; }
    }
}
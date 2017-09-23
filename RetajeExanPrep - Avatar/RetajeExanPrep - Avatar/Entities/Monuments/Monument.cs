public abstract class Monument
{
    private string name;

    protected Monument(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get { return this.name; }
        protected set { this.name = value; }
    }

    public override string ToString()
    {
        var getType = this.GetType().Name;
        var getEnd = getType.IndexOf("Monument");
        getType = getType.Insert(getEnd, " ");
        return $"{getType}: {this.name}";
    }
}
class Animal
{
    private string name;
    private string favouriteFood;

    public string Name { get; protected set; }
    public string FavouriteFood { get; protected set; }

    public virtual string ExplainMyself()
    {
        return $"I am {this.Name} and my fovourite food is {this.FavouriteFood}";
    }
}

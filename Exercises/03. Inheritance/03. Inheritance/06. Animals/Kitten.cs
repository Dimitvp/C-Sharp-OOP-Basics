
class Kitten : HomeHomeAnimalFactory
{
    public Kitten(string name, int age)
    : base(name, age, "Female")
    {
    }

    public override string ProduceSound()
    {
        return base.ProduceSound() + $"\nMiau";
    }
}
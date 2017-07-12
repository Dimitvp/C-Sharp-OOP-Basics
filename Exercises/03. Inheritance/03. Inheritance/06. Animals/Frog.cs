
class Frog : HomeHomeAnimalFactory
{
    public Frog(string name, int age, string gender)
        : base(name, age, gender)
    {
    }

    public override string ProduceSound()
    {
        return base.ProduceSound() + $"\nFrogggg";
    }
}
class Dog : HomeHomeAnimalFactory
{
    public Dog(string name, int age, string gender)
        : base(name, age, gender)
    {
    }

    public override string ProduceSound()
    {
        return base.ProduceSound() + $"\nBauBau";
    }


}
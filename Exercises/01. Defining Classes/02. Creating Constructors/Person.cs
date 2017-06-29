class Person
{
    public string name;
    public int age;

 
    public Person()
    {
        this.age = 1;
        this.name = "No name";
    }

    public Person(int age)
        :this(age, "No name")
    {
        this.age = age;
    }

    public Person(int age, string name)
    {
        this.age = age;
        this.name = name;  
    }
}
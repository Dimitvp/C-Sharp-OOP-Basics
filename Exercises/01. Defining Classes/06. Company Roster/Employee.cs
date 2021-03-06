﻿class Employee
{
    private string name;
    private decimal salary;
    private string position;
    private string department;
    private string email;
    private int age;

    public Employee(string name, decimal salary, string postition, string department)
    {
        this.name = name;
        this.salary = salary;
        this.position = postition;
        this.department = department;
        this.age = -1;
        this.email = "n/a";
    }

    public int Age
    {
        set { this.age = value; }
    }

    public string Email
    {
        set { this.email = value; }
    }

    public string Department { get { return this.department; } }

    public decimal Salary { get { return this.salary; } }

    //public Employee(string name, decimal salary, string postition, string department, int age) : this(name, salary, postition, department)
    //{
    //    this.age = age;
    //}

    //public Employee(string name, decimal salary, string postition, string department, string email) : this(name, salary, postition, department)
    //{
    //    this.email = email;
    //}

    public string PrintEmployeeInfo()
    {
        return $"{this.name} {this.salary:f2} {this.email} {this.age}";
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Tire
{
    private int age;
    private double pressure;

    public Tire(double pressure, int age)
    {
        this.pressure = pressure;
        this.age = age;
    }

    public double Pressure
    {
        get { return this.pressure; }
    }
}
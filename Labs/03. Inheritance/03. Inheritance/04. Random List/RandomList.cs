using System;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;

public class RandomList : ArrayList
{
    private Random rnd;

    public RandomList()
    {
        this.rnd = new Random();
    }

    public string RandomString()
    {
        return "";
    }
}
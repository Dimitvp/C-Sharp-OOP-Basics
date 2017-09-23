using System.Collections.Generic;

public class Nations
{
    private List<Bender> benders;
    private List<Monument> monuments;

    public Nations(List<Bender> benders, List<Monument> monuments)
    {
        this.benders = new List<Bender>();
        this.monuments = new List<Monument>();
    }
}
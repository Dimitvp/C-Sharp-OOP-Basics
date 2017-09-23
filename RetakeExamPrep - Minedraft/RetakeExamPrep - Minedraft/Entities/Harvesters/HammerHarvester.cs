public class HammerHarvester : Harvester
{
    
    public HammerHarvester(string id, double oreOutput, double energyRequiremnt) 
        : base(id, oreOutput, energyRequiremnt)
    {
        this.OreOutput += 2 * this.OreOutput;
        //this.OreOutput += (this.OreOutput * 200) / 100;
        this.EnergyRequirement += this.EnergyRequirement;
    }

    public override string GetName()
    {
        return "Hammer";
    }
}
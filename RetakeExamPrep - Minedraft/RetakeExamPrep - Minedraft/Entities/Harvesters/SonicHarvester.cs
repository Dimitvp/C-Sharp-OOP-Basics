public class SonicHarvester : Harvester
{
    private int sonicFactor;
    public SonicHarvester(string id, double oreOutput, double energyRequiremnt, int sonicFactor) 
        : base(id, oreOutput, energyRequiremnt)
    {
        this.sonicFactor = sonicFactor;
        this.EnergyRequirement /= this.sonicFactor;
    }

    public override string GetName()
    {
        return "Sonic";
    }
}
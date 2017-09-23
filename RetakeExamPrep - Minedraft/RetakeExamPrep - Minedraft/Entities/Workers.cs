using System.Collections.Generic;

public class Workers
{
    private List<Harvester> harvesters;
    private List<Provider> providers;

    public Workers()
    {
        this.harvesters = new List<Harvester>();
        this.providers = new List<Provider>();
    }

    public void AddHarvester(Harvester currentHarvester) => this.harvesters.Add(currentHarvester);
    public void AddProvider(Provider currentProvider) => this.providers.Add(currentProvider);

}
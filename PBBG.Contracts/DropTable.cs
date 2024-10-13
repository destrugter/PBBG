namespace PBBG.Contracts;

public class DropItem
{
    public string Name { get; set; }
    public float Chance { get; set; }
    public string Image { get; set; }

    public DropItem(string name, float chance, string image)
    {
        Name = name;
        Chance = chance;
        Image = image;
    }
}

public class DropTable
{
    public string Name { get; set; }
    public float Chance { get; set; }
    public List<DropItem> Items { get; set; }

    public DropTable(string name, float chance, List<DropItem> items)
    {
        Name = name;
        Chance = chance;
        Items = items;
    }
}
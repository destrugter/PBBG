namespace PBBG.Contracts;

public class Rock
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public RockTypeEnum RockType { get; set; }
    public string Image { get; set; }
    public int RequiredLevel { get; set; }
    public float Experience { get; set; }

    public List<DropTable> DropTables { get; set; } = new List<DropTable>();
}

public enum RockTypeEnum
{
    STONE
}
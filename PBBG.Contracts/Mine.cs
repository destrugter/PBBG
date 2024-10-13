namespace PBBG.Contracts;

public class Mine
{
    public string Name { get; set; }
    public string Image { get; set; }
    public List<Rock> Rocks { get; set; } = new List<Rock>();
}
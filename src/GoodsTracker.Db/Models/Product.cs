namespace GoodsTracker.Db.Models;

public class Product : Entity
{
    public string? Name { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? Link { get; set; }
    public virtual List<History> History { get; set; }
}

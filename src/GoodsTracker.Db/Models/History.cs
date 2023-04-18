namespace GoodsTracker.Db.Models;

public class History : Entity
{
    public double Price { get; set; }
    public DateTime CreateDate { get; set; }
    public Guid ProductId { get; set; }
    public virtual Product Product { get; set; }
}

using System.ComponentModel.DataAnnotations;

namespace GoodsTracker.Db.Models;

public abstract class Entity
{
    [Key] public Guid Id { get; set; }
}
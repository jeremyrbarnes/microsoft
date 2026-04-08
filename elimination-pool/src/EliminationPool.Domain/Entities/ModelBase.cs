namespace EliminationPool.Domain.Models;

public class ModelBase
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime? UpdatedOn { get; set; }

    public ModelBase()
    {
        
    }
}
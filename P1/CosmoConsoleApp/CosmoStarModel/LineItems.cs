
namespace CosmoStarModel;
public class LineItems
{
    public int OrderNumber { get; set; } // First foreign key
    public int ProductId { get; set; } // Second foreign key
    public int Quantity { get; set; }
    public double ProductTotal { get; set; }

    public LineItems()
    {
        OrderNumber = 0;
        ProductId = 0;
        Quantity = 0;
    }
}

public int OrderNumber { get; set; }
    public int CostumerId { get; set; }
    public int StoreNumber { get; set; }
    public double OrderTotal { get; set; }
    public DateTime DateCreated { get; set; }
    public List<OrderProduct> OrderedItems { get; set; }

    public Orders()
    {
        OrderNumber = 0;
        CostumerId = 0;
        StoreNumber = 0;
        OrderTotal = 0.0;
    }
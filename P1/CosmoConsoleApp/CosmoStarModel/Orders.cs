namespace CosmoStarModel
{

public class Orders
{
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
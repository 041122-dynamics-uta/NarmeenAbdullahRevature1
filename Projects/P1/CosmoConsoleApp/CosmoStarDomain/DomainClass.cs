using CosmoStarModel;
using CosmoStarRepo;


namespace CosmoStarDomain;
public class DomainClass
{
 
public CosmoRepoClass _repo { get; set; }
    public DomainClass(CosmoRepoClass CRC)
    {
        this._repo = CRC;
    }

    public List<CosmoCustomer> MembersList(string FirstName, string LastName, string Email, string MySecret)
    {
        List<CosmoCustomer> CC = _repo.MembersList(FirstName, LastName, Email, MySecret);
        return CC;
    }


    public List<CosmoCustomer> uNamePwordExists(string RegEmail, string RegPass)
    {
        return null;
        
    }

  
    public List<StoreLocations> StoreLocationsList()
    {
        List<StoreLocations> SL = _repo.StoreLocationsList();
        return SL;
    }
    public List<Inventory> InventoryList()
    {
        List<Inventory> SI = _repo.InventoryList();
        return SI;
    }
    public List<CosmoOrder> OrderList()
    {
        List<CosmoOrder> MCO = _repo.OrderList();
        return MCO;
    }
    public List<OrderHistory> OrderHistoryList()
    {
        List<OrderHistory> MCOH = _repo.OrderHistoryList();
        return MCOH;
    }


}

using CosmoStarModel;
using CosmoStarRepo;
//using System.Collections.Generic.list;



namespace CosmoStarDomain;
public class DomainClass
{
 //Repo injector make more to inject into and recieve Order, Order History, store locations, and store Inventory tables
public CosmoRepoClass _repo { get; set; }
    public DomainClass(CosmoRepoClass MRC)
    {
        this._repo = MRC;
    }

    public List<CosmoCustomer> MembersList(string FirstName, string LastName, string Email, string MySecret)
    {
        List<CosmoCustomer> CC = _repo.MembersList(FirstName, LastName, Email, MySecret);
        return CC;
    }


    public List<CosmoCustomer> uNamePwordExists(string RegEmail, string RegPass)
    {
        return null;
        //bool CosmoCustomerExists = _repo.uNamePwordExists(RegEmail, RegPass);
        
        // if (CosmoCustomerExists){
        //     return null;    
        // }

        // else {

        //    CosmoCustomer NewCosmoCustomer = MembersList (FirstName, LastName, Email, MySecret);
        //    return NewCosmoCustomer;

        // }


        
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


namespace CosmoStarModel
{
    public class CosmoCustomer
    {
        // Customer -- everything belo wis in Customer Table with the following columns

    public int CosmoCustomerId {get; set;} 
    public string FirstName {get; set;} = "";
    public string LastName {get; set;} = "";
    public string MySecret {get; set;} = "";
    public string Email {get; set;} = "";
    

    public DateTime DateCreated {get; set;} = DateTime.Now;
    }
}
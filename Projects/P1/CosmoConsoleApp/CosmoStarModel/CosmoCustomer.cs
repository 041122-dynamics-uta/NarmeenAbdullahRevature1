
namespace CosmoStarModel
{
    public class CosmoCustomer
    {

    public int CosmoCustomerId {get; set;} 
    public string FirstName {get; set;} = "";
    public string LastName {get; set;} = "";
    public string MySecret {get; set;} = "";
    public string Email {get; set;} = "";
    

    public DateTime DateCreated {get; set;} = DateTime.Now;
    }
}
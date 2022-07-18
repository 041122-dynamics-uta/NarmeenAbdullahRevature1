namespace CosmoStarModel
{
    public class CosmoOrder
    {

        public int CosmoOrderId {get; set;}
        public string FirstName {get; set;} = "";
        public string LastName {get; set;} = "";
        public string ItemName {get; set;} = "";
        public string ItemDescription {get; set;} = "";
        public int Quantity {get; set;}
        public int ItemPrice {get; set;}
        public string City {get; set;} = "";
    }
    
}
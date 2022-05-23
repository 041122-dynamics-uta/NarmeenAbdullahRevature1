namespace CosmoStarModel
{
    public class OrderHistory
    {
        // get and set order History Items in there respective spaces
        public int OrderHistoryId {get; set;} = 0;
        public string FirstName {get; set;} = "";
        public string LastName {get; set;} = "";
        public string ItemName {get; set;} = "";
        public string ItemDescription {get; set;} ="";
        public int Quantity {get; set;}
        public int ItemPrice {get; set;}
        public int MyStoreLocationsId {get; set;}
        public DateTime OrderHistoryDateTime {get; set;} = DateTime.Now;
    }
}
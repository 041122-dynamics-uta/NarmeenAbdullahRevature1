using System.Data.SqlClient;
using CosmoStarModel;


namespace CosmoStarRepo
{
    public class CosmoRepoMapper
    {
       //created to populate the tables and to recall thier contents in the order they appear in the DB repeat for more tables
        public CosmoCustomer DboToCosmoCustomer(SqlDataReader reader)
        {
            CosmoCustomer cc = new CosmoCustomer
            {
                CosmoCustomerId = (int)reader[0],
                FirstName = (string)reader[1],
                LastName = (string)reader[2],
                Email = (string)reader[3],
                MySecret = (string)reader[4]
            };
            return cc;
        }
        public CosmoOrder DboToCosmoOrder(SqlDataReader reader)
        {
            CosmoOrder MCO = new CosmoOrder
            {
                CosmoOrderId = (int)reader[0],
                FirstName = (string)reader[1],
                LastName = (string)reader[2],
                ItemName = (string)reader[3],
                ItemDescription = (string)reader[4],
                Quantity = (int)reader[5],
                ItemPrice = (int)reader[6],
                City = (string)reader[7]
            };
            return MCO;
        }
        public OrderHistory DboToOrderHistory(SqlDataReader reader)
        {
            OrderHistory MCOH = new OrderHistory
            {
                OrderHistoryId = (int)reader[0],
                FirstName = (string)reader[1],
                LastName = (string)reader[2],
                ItemName = (string)reader[3],
                ItemDescription = (string)reader[4],
                Quantity = (int)reader[5],
                ItemPrice = (int)reader[6],
                MyStoreLocationsId = (int)reader[7],
                OrderHistoryDateTime = (DateTime)reader[8]
            };
            return MCOH;
        }
        public Inventory DboToInventory(SqlDataReader reader)
        {
            Inventory MSI = new Inventory
            {
                MyStoreInventoryId = (int)reader[0],
                ItemName = (string)reader[1],
                ItemPrice = (int)reader[2],
                ItemDescription = (string)reader[3],
                ItemQuantity = (int)reader[4]     
            };
            return MSI;
        }
        public StoreLocations DboToStoreLocations(SqlDataReader reader)
        {
            StoreLocations MSL = new StoreLocations
            {
                StoreLocationsId = (int)reader[0],
                City = (string)reader[1]  
            };
            return MSL;
        }
    }
} 


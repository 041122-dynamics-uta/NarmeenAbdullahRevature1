using CosmoStarModel;
using System.Data.SqlClient;


namespace CosmoStarRepo;

public class CosmoRepoClass
{
        public CosmoRepoClass(CosmoRepoMapper _mapper) 
        {
            this._mapper = _mapper;
               
        }

            public CosmoRepoMapper _mapper {get; set;}

            //Azure connection string
    string connectionstring = "Server=tcp:narmeenserver.database.windows.net,1433;Initial Catalog=CosmoDB;Persist Security Info=False;User ID=narmeenServer;Password=happyApr@11;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

//Mapper Reference
        public CosmoRepoClass()
            {
                this._mapper = new CosmoRepoMapper();
            }


    public bool uNamePwordExists(string RegEmail, string RegPass)
    {

       string query = "SELECT * FROM CosmoCustomer WHERE Email LIKE 'Ali@gmail.net' AND MySecret LIKE 'ghghg';";
       
        using (SqlConnection conn = new SqlConnection(connectionstring))
        { 

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@RE", RegEmail);
            command.Parameters.AddWithValue("@RP", RegPass);
            
            conn.Open(); //open the connection to the DB
            SqlDataReader results = command.ExecuteReader(); //do the query
            conn.Close();

            if (results.Read ())
            {
                return true;
            }

            else
            {
                conn.Close();
                return false;
            }

        }

    }


    public List<CosmoCustomer> MembersList(string FirstName, string LastName, string Email, string MySecret)
    {
        
        string myQuery1 = "Insert Into CosmoCustomer ( FirstName, LastName, Email, MySecret ) Values ( @F, @L, @E, @MyS )";

        
        using (SqlConnection query1 = new SqlConnection(connectionstring))
        {
            SqlCommand command = new SqlCommand(myQuery1, query1);
            command.Parameters.AddWithValue("@F", FirstName);
            command.Parameters.AddWithValue("@L", LastName);
            command.Parameters.AddWithValue("@E", Email);
            command.Parameters.AddWithValue("@MyS", MySecret);
            command.Connection.Open(); //open the connection to the DB
            SqlDataReader results = command.ExecuteReader(); //do the query

            List<CosmoCustomer> ccl = new List<CosmoCustomer>();
            while (results.Read())
            {
                ccl.Add(this._mapper.DboToCosmoCustomer(results));//send in the row of the reader to be mapped.
            }
            query1.Close();
            return ccl;      
        }

    }


    //Queries to populate and manipulate the database.

    public List<CosmoOrder> OrderList()
    {
        string myQuery2 = "SELECT * FROM CosmoOrder;";

        using (SqlConnection query2 = new SqlConnection(connectionstring))
        {
            SqlCommand command = new SqlCommand(myQuery2, query2);
            command.Connection.Open(); //open the connection to the DB
            SqlDataReader results = command.ExecuteReader(); 

            List<CosmoOrder> MCO1 = new List<CosmoOrder>();
            while (results.Read())
            {
                MCO1.Add(this._mapper.DboToCosmoOrder(results));//send in the row of the reader to be mapped.
            }
            query2.Close();
            return MCO1;      
        }

    }
    public List<OrderHistory> OrderHistoryList()
    {
        string myQuery3 = "SELECT * FROM CosmoOrderHistory;";

        using (SqlConnection query3 = new SqlConnection(connectionstring))
        {
            SqlCommand command = new SqlCommand(myQuery3, query3);
            command.Connection.Open(); //open the connection to the DB
            SqlDataReader results = command.ExecuteReader(); //do the query

            List<OrderHistory> MCOH1 = new List<OrderHistory>();
            while (results.Read())
            {
                MCOH1.Add(this._mapper.DboToOrderHistory(results));//send in the row of the reader to be mapped.
            }
            query3.Close();
            return MCOH1;      
        }

    }
    public List<Inventory> InventoryList()
    {
        string myQuery4 = "SELECT * FROM CosmoInventory;";

        using (SqlConnection query4 = new SqlConnection(connectionstring))
        {
            SqlCommand command = new SqlCommand(myQuery4, query4);
            command.Connection.Open(); //open the connection to the DB
            SqlDataReader results = command.ExecuteReader(); //do the query

            List<Inventory> MSI1 = new List<Inventory>();
            while (results.Read())
            {
                MSI1.Add(this._mapper.DboToInventory(results));//send in the row of the reader to be mapped.
            }
            query4.Close();
            return MSI1;      
        }

    }
    public List<StoreLocations> StoreLocationsList()
    {
        string myQuery5 = "SELECT * FROM CosmoStoreLocations;";

        using (SqlConnection query5 = new SqlConnection(connectionstring))
        {
            SqlCommand command = new SqlCommand(myQuery5, query5);
            command.Connection.Open(); //open the connection to the DB
            SqlDataReader results = command.ExecuteReader(); //do the query

            List<StoreLocations> MSL1 = new List<StoreLocations>();
            while (results.Read())
            {
                MSL1.Add(this._mapper.DboToStoreLocations(results));//send in the row of the reader to be mapped.
            }
            query5.Close();
            return MSL1;      
        }

    }
}


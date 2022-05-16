using CosmoStarModel;
using System.Data.SqlClient;
namespace CosmoStarRepo;


public class CosmoRepoClass
{

    //mapper class { get; set; } to establish connection string with Azure
    // Mapper provides way to take the result gotten from ADO map them transfer that data into a class in CosmoStarModel
    
    public CosmoRepoMapper _mapper { get; set; }
    
    string connectionString = "$Server=tcp:narmeenserver.database.windows.net,1433;Initial Catalog=CosmoDB;Persist Security Info=False;User ID=narmeenServer;Password=pass;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


 public CosmoRepoClass()
    {
        // this._repo = r;
        this._mapper = new CosmoRepoMapper();
    }

    public List<Member> MembersList()
    {
        string myQuery1 = "SELECT * FROM _Members;";
        //this using block creates teh SqlConnection.
        // the SqlConnection is the object that communicates with the Db.
        using (SqlConnection query1 = new SqlConnection(connectionString))
        {
            //The SqlCommand object uses the query text along with the SqlConnection object to open a connection and send the query.
            SqlCommand command = new SqlCommand(myQuery1, query1);
            command.Connection.Open();//open the connection to the Db
            SqlDataReader results = command.ExecuteReader();//actually conduct the query.

            //query the FamilyRepository Db for the list of members
            //USE ADO.NET .........
            //use the mapper to transfer the falues in to Member objects in a List<Member>.
            List<Member> m1 = new List<Member>();
            while (results.Read())
            {
                //map the current table row to member class objects
                Member m = this._mapper.DboToMember(results);//send in the row of the reader to be mapped.
                m1.add(m);     //send in the row of the reader to be mapped       
            }

            query1.Close();
            return m1;
        }


    }
}


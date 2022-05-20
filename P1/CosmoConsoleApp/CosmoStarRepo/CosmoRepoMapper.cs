using System.Data.SqlClient;
using CosmoStarModel;
namespace CosmoStarRepo
{
    public class CosmoRepoMapper
    {
       //create a method that will transfer the data from the members list return into members
        internal Member DboToMember(SqlDataReader reader)
        {
            Member m = new Member
            {
                MemberIdId = (int)reader[0],
                cName = (string)reader[1],
                cAddress = (string)reader[2],
                cPhone = (byte)reader[3],
                DateCreated = (DateTime)reader[4],
                

            };
            
            return m;
        }
    } 
}

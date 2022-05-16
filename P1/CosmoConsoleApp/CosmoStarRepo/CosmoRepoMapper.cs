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
                Fname = (string)reader[1],
                lname = (string)reader[2],
                Age = (byte)reader[3],
                DateCreated = (DateTime)reader[4],
                FamilyId = (int)reader[5],

            };
            
            return m;
        }
    } 
}

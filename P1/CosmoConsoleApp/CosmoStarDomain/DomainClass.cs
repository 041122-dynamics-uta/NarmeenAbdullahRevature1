using CosmoStarModel;
using CosmoStarRepo;


namespace CosmoStarDomain;
public class DomainClass
{
/// copied from here down
/// 
/// 
public CosmoRepoClass _repo { get; set; }
    public DomainClass(CosmoRepoClass r)
    {
        this._repo = r;
    }

    public List<Member> MembersList()
    {
        List<Member> ml = _repo.MembersList();
        return ml;
    }

    public Member newMember(string cName, string cNumber, string cAddress, string cEmail ){

        
    }


}

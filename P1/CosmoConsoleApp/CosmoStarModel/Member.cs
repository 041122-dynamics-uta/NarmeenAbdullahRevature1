using System;

namespace CosmoStarModel;
public class Member
{
  public int CostumerId { get; set; }
    public string cName { get; set; }
    public string cPhone { get; set; }
    public string cAddress { get; set; }
    public string cEmail { get; set; }
    public List<Orders> _orders;
    
    //Member m =0;

    public Member()
    {
        CostumerId = 0;
        cName = "Name";
        cPhone = "Phone";
        cAddress = "Address";
        cEmail = "Email";
        _orders = new List<Orders>();
    }

}
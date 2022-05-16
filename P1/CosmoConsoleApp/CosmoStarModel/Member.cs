using System;

namespace CosmoStarModel;
public class Member
{
  public int CostumerId { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public List<Orders> _orders;
    

    public Member()
    {
        CostumerId = 0;
        Name = ".Name";
        Phone = ".Phone";
        Address = ".Address";
        Email = ".Email";
        _orders = new List<Orders>();
    }

}
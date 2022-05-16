using System;

namespace CosmoStarModel;
public class Member
{
 
    public int MemberIdId { get; set; } = -1;
    public string? Fname { get; set; }
    public string? lname { get; set; }
    public int Age { get; set; } = 0;
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public MemberClass? Family { get; set; }
    public int FamilyId { get; set; }

}
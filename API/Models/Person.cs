using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{

  public class Person
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string Lastname { get; set; }
    public int PhoneNumber { get; set; }

    public virtual ICollection<Intrest> Intrests { get; set; }
    public virtual ICollection<Link> Links { get; set; }
  }
}
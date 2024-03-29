using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
  public class Person
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }

    public virtual ICollection<PersonInterestLink> PersonInterestLinks { get; set; }
    public virtual ICollection<Link> Links { get; set; }
  }
}
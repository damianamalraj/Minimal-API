using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
  public class Interest
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    public virtual ICollection<PersonInterestLink> PersonInterestLinks { get; set; }
    public virtual ICollection<Link> Links { get; set; }
  }
}
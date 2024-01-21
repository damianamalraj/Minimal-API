using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{

  public class Intrest
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    public virtual ICollection<Person> Persons { get; set; }
    public virtual ICollection<Link> Links { get; set; }
  }
}
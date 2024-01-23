using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Models
{
  public class PersonInterestLink
  {
    public int Id { get; set; }

    public virtual Person Person { get; set; }
    public virtual Interest Interest { get; set; }
  }
}
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
  public class Link
  {
    public int Id { get; set; }
    public string Url { get; set; }

    public virtual Person Person { get; set; }
    public virtual Interest Interest { get; set; }
  }
}
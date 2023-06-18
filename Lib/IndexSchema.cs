using System;
using System.Linq;

namespace System.Data.EntitySchema {

  public class IndexSchema {

    public string Name { get; set; } = "";
    public bool Unique { get; set; } = false;
    public string[] MemberFieldNames { get; set; } = { };

  }

}

using System;
using System.Linq;

namespace System.Data.ModelDescription {

  /// <summary>
  /// (from 'FUSE-fx.ModelDescription')
  /// </summary>
  public class IndexSchema {

    public string Name { get; set; } = "";
    public bool Unique { get; set; } = false;
    public string[] MemberFieldNames { get; set; } = { };

  }

}

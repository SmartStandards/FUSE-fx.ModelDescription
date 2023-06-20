using System;
using System.Linq;

namespace System.Data.ModelDescription {

  /// <summary>
  /// (from 'FUSE-fx.ModelDescription')
  /// </summary>
  public class RelationSchema {

    public string Name { get; set; } = "";

    public string PrimaryEntityName { get; set; } = "";
    public string ForeignEntityName { get; set; } = "";
    public string ForeignKeyIndexName { get; set; } = "";

    public bool IsLookupRelation { get; set; } = true;
    public bool PrimaryEntityIsOptional { get; set; } = false;
    public bool ForeignEntityIsMultiple { get; set; } = true;

    public string PrimaryNavigationName { get; set; } = "";
    public string ForeignNavigationName { get; set; } = "";
    public string PrimaryNavigationSummary { get; set; } = "";
    public string ForeignNavigationSummary { get; set; } = "";

    public bool CascadeDelete { get; set; } = false;

  }

}

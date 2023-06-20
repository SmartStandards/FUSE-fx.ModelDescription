using System;
using System.Linq;

namespace System.Data.ModelDescription {

  /// <summary>
  /// (from 'FUSE-fx.ModelDescription')
  /// </summary>
  public class RelationSchema {

    public string Name = "";

    public string PrimaryEntityName = "";
    public string ForeignEntityName = "";
    public string ForeignKeyIndexName = "";

    public bool IsLookupRelation = true;
    public bool PrimaryEntityIsOptional = false;
    public bool ForeignEntityIsMultiple = true;

    public string PrimaryNavigationName = "";
    public string ForeignNavigationName = "";
    public string PrimaryNavigationSummary = "";
    public string ForeignNavigationSummary = "";

    public bool CascadeDelete = false;

  }

}

using System;
using System.Linq;

namespace System.Data.ModelDescription {

  /// <summary>
  /// (from 'FUSE-fx.ModelDescription')
  /// </summary>
  public class EntitySchema {

    public string Name = "";
    public string NamePlural = "";
    public string InheritedEntityName = null;
    public string Summary = "";

    public bool IsBlEntrypoint = false;

    public string PrimaryKeyIndexName = "";
    public IndexSchema[] Indices = { };

    public FieldSchema[] Fields = { };

  }

}

using System;
using System.Linq;

namespace System.Data.EntitySchema {

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

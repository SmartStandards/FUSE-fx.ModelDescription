using System;
using System.Linq;

namespace System.Data.EntitySchema {

  public class EntitySchema {

    public string Name { get; set; } = "";
    public string NamePlural { get; set; } = "";
    public string InheritedEntityName { get; set; } = null;
    public string Summary { get; set; } = "";

    public bool IsBlEntrypoint { get; set; } = false;

    public string PrimaryKeyIndexName { get; set; } = "";
    public IndexSchema[] Indices { get; set; } = { };

    public FieldSchema[] Fields { get; set; } = { };

  }

}

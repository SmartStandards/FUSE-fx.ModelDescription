using System;
using System.Linq;

namespace System.Data.EntitySchema {

  public class SchemaRoot {

    public string DescriptionFormat { get; set; } = "";

    public string TimestampUtc { get; set; } = "";
    public string SemanticVersion { get; set; } = "";

    public EntitySchema[] Entities { get; set; } = { };

    public RelationSchema[] Relations { get; set; } = { };

  }

}

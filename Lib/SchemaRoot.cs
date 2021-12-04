using System;
using System.Linq;

namespace System.Data.EntitySchema {

  public class SchemaRoot {

    public string DescriptionFormat = "";

    public string TimestampUtc = "";
    public string SemanticVersion = "";

    public EntitySchema[] Entities = { };

    public RelationSchema[] Relations = { };

  }

}

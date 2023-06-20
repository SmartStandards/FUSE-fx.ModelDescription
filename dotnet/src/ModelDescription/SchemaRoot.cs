using System;
using System.Linq;

namespace System.Data.ModelDescription {

  /// <summary>
  /// (from 'FUSE-fx.ModelDescription')
  /// </summary>
  public class SchemaRoot {

    public string DescriptionFormat = "";

    public string TimestampUtc = "";
    public string SemanticVersion = "";

    public EntitySchema[] Entities = { };

    public RelationSchema[] Relations = { };

  }

}

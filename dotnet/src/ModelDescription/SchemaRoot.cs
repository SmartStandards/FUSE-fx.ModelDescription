using System;
using System.Linq;

namespace System.Data.ModelDescription {

  /// <summary>
  /// (from 'FUSE-fx.ModelDescription')
  /// </summary>
  public class SchemaRoot {

    public string DescriptionFormat { get; set; } = "";

    public string TimestampUtc { get; set; } = "";

    public string SemanticVersion { get; set; } = "";

    public EntitySchema[] Entities { get; set; } = { };

    public RelationSchema[] Relations { get; set; } = { };

    public KnownValueRange[] KnownValueRanges { get; set; } = { };

    public string DesignerData { get; set; } = "";
  }

}

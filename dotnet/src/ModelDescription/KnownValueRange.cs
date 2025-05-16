namespace System.Data.ModelDescription {
  public class KnownValueRange {
    public KnownValue[] KnownValues { get; set; }

    /// <summary>
    /// Full Typename of enums
    /// </summary>
    public string Name { get; set; } = "";
  }
}
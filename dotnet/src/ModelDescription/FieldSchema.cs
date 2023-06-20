using System;
using System.Linq;

namespace System.Data.ModelDescription {

  /// <summary>
  /// (from 'FUSE-fx.ModelDescription')
  /// </summary>
  public class FieldSchema {

    public string Name = "";
    public string Type = "";
    public int MaxLength = 0;

    public string Summary = "";

    public bool Required = true;
    public string DefaultValue = null;
    public bool DbGeneratedIdentity = false;

    /// <summary>
    /// Never = 0 (this field should only be set by wellknown technical automatisms),
    /// OnCreation = 1 (this field should be setable when a record is created newly (or on full-import/recovery)),
    /// OnSingleUpdate = 2 (this field should be setable during the usecase of an individual edit),
    /// OnBatchUpdate = 4 (this field should be setable during a batch-update for multiple records),
    /// AfterCreation = 6 (represents the logical combination of 'OnSingleUpdate' + 'OnBatchUpdate'),
    /// Always = 7 (represents the logical combination of 'OnCreation' + 'AfterCreation')
    /// </summary>
    public int SetabilityFlags = 7;

    /// <summary>
    ///  Indicates, if a field belongs to a more specific business domain.
    ///  This can be used to control the detail-grade (displayed fields) in the UI
    ///  or when exporting data in an abstract way.
    /// </summary>
    public string ContentConcern = null;

    /// <summary>
    ///  Defines, that a Property contains content, which represents a human readable natural
    ///  key, that should be preferred when refering to the current record (UI/Logging/Tracing).
    ///  This is a non-technical information, which relates to the domain model (business-level)!
    /// </summary>
    public bool IdentityLabel = false;

    /// <summary>
    ///  Defines whether a field contains content that is commonly used for filtering.
    ///  This can have the values 0=None, 1=ExactMatch, 2=Substring (tect whcih has NOT the semantic of an ID/KEY)
    ///  This is a non-technical information, which relates to the domain model (business-level)!
    /// </summary>
    public int Filterable = 0;

    public bool SystemInternal = false;

    [Obsolete("use value 1 for the 'SetabilityFlags' to protect this field from being changed afterwards...")]
    public bool FixedAfterCreation = false;

  }

}

using System;
using System.Linq;

namespace System.Data.EntitySchema {

  public class FieldSchema {

    public string Name = "";
    public string Type = "";
    public int MaxLength = 0;

    public string Summary = "";
    public bool SystemInternal = false;
    public bool FixedAfterCreation = false;

    public bool Required = true;
    public string DefaultValue = null;
    public bool DbGeneratedIdentity = false;

  }

}

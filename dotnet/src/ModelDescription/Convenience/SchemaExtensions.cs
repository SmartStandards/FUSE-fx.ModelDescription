using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Data.ModelDescription.Convenience {

  public static class SchemaExtensions {

    public static EntitySchema GetSchema(this SchemaRoot schemaRoot, string schemaName) {
      if (schemaName.EndsWith("Entity")) {
        schemaName = schemaName.Replace("Entity", "");
      }
      return schemaRoot.Entities.FirstOrDefault(
        (e) => e.Name == schemaName 
      );
    }

    public static IndexSchema GetIndex(this EntitySchema schema, string indexName) {
      IndexSchema index = schema.Indices.FirstOrDefault((i) => i.Name == indexName);
      return index;
    }

    public static IndexSchema GetPrimaryIndex(this SchemaRoot schemaRoot, string schemaName) {
      EntitySchema schema = GetSchema(schemaRoot, schemaName);
      return GetIndex(schema, schema.PrimaryKeyIndexName);
    }

    public static List<IndexSchema> GetUniqueKeysets(this SchemaRoot schemaRoot, string schemaName) {
      EntitySchema schema = GetSchema(schemaRoot, schemaName);
      List<IndexSchema> result = schema.Indices.Where((i) => i.Unique).ToList();
      return result;
    }

    public static List<PropertyInfo> GetProperties(this IndexSchema indexSchema, Type t) {
      var result = new List<PropertyInfo>();
      foreach (string fieldName in indexSchema.MemberFieldNames) {
        PropertyInfo pi = t.GetProperty(fieldName);
        if (pi == null) continue;
        result.Add(pi);
      }
      return result;
    }

    public static List<PropertyInfo> GetPrimaryKeyProperties(this SchemaRoot schemaRoot, Type t) {
      IndexSchema primaryIndex = schemaRoot.GetPrimaryIndex(t.Name);
      return primaryIndex.GetProperties(t);
    }

    public static List<List<PropertyInfo>> GetUniqueKeysetsProperties(this SchemaRoot schemaRoot, Type t) {
      List<List<PropertyInfo>> result = new List<List<PropertyInfo>>();
      List<IndexSchema> keySets = schemaRoot.GetUniqueKeysets(t.Name);
      foreach (IndexSchema keySet in keySets) {
        result.Add(keySet.GetProperties(t));
      }
      return result;
    }
  }

}
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Data.ModelDescription.Convenience {

  public static class SchemaExtensions {

    public static EntitySchema GetSchema(this SchemaRoot schemaRoot, string schemaName) {      
      return schemaRoot.Entities.FirstOrDefault(
        (e) => e.Name == schemaName
      );
    }

    public static IndexSchema GetIndex(this EntitySchema schema, string indexName) {
      IndexSchema index = schema.Indices.FirstOrDefault((i) => i.Name == indexName);
      if (index == null) {
        return new IndexSchema() {
          MemberFieldNames = new string[] { },
          Unique = false,
          Name = "Empty_Default"
        };
      }
      return index;
    }

    public static IndexSchema GetPrimaryIndex(this SchemaRoot schemaRoot, Type entityType) {
      EntitySchema schema = GetSchema(schemaRoot, entityType.Name);
      if (string.IsNullOrEmpty(schema.PrimaryKeyIndexName)) {
        PropertyInfo primaryKeyProperty = TryGetPrimaryKeyProperty(entityType);
        if (primaryKeyProperty != null) {
          return new IndexSchema() {
            Name = $"{primaryKeyProperty.Name}_Default",
            Unique = true,
            MemberFieldNames = new string[] { primaryKeyProperty.Name }
          };
        }
        return new IndexSchema() {
          Name = "Id_Default",
          Unique = true,
          MemberFieldNames = new string[] { "Id" }
        };
      }
      return GetIndex(schema, schema.PrimaryKeyIndexName);
    }

    private static PropertyInfo TryGetPrimaryKeyProperty(Type t) {
      if (t.GetProperty("Id") != null) return t.GetProperty("Id");
      if (t.GetProperty("UId") != null) return t.GetProperty("UId");
      if (t.GetProperty("Uid") != null) return t.GetProperty("Uid");
      if (t.GetProperty($"{t.Name}+Id") != null) return t.GetProperty($"{t.Name}+Id");
      if (t.GetProperty($"{t.Name}+UId") != null) return t.GetProperty($"{t.Name}+UId");
      if (t.GetProperty($"{t.Name}+Uid") != null) return t.GetProperty($"{t.Name}+Uid");
      if (t.Name.EndsWith("Entity")) {
        string idName = t.Name.Substring(0, t.Name.Length - 6) + "Id";
        if (t.GetProperty(idName) != null) return t.GetProperty(idName);
        string uidName = t.Name.Substring(0, t.Name.Length - 6) + "UId";
        if (t.GetProperty(uidName) != null) return t.GetProperty(uidName);
        string uIdName = t.Name.Substring(0, t.Name.Length - 6) + "Uid";
        if (t.GetProperty(uIdName) != null) return t.GetProperty(uIdName);
      }
      return null;
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
      IndexSchema primaryIndex = schemaRoot.GetPrimaryIndex(t);
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

    public static bool IsForeignKey(this SchemaRoot schemaRoot, PropertyInfo propertyInfo) {
      foreach (RelationSchema relation in schemaRoot.Relations) {
        if (relation.ForeignKeyIndexName == propertyInfo.Name) return true;
      }
      return false;
    }

    public static bool IsNavigation(this SchemaRoot schemaRoot, PropertyInfo propertyInfo) {
      foreach (RelationSchema relation in schemaRoot.Relations) {
        if (
          relation.ForeignNavigationName == propertyInfo.Name ||
          relation.PrimaryNavigationName == propertyInfo.Name
        ) return true;
      }
      return false;
    }

  }

}
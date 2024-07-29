using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace GraphQLCodeGen {
  public class Types {
    
    #region FirstInterfaceType
    public class FirstInterfaceType : MyInterface {
      #region members
      [JsonProperty("volume")]
      public int volume { get; set; }
    
      [JsonProperty("weight")]
      public int weight { get; set; }
      #endregion
    }
    #endregion
    
    #region FirstUnionType
    public class FirstUnionType {
      #region members
      [JsonProperty("age")]
      public int age { get; set; }
      #endregion
    }
    #endregion
    
    public interface MyInterface {
      [JsonProperty("weight")]
      int weight { get; set; }
    }
    
    #region Query
    public class Query {
      #region members
      [JsonProperty("aInterface")]
      public MyInterface aInterface { get; set; }
    
      [JsonProperty("aUnion")]
      public FirstOrSecondUnionType aUnion { get; set; }
      #endregion
    }
    #endregion
    
    #region SecondInterfaceType
    public class SecondInterfaceType : MyInterface {
      #region members
      [JsonProperty("density")]
      public int density { get; set; }
    
      [JsonProperty("weight")]
      public int weight { get; set; }
      #endregion
    }
    #endregion
    
    #region SecondUnionType
    public class SecondUnionType {
      #region members
      [JsonProperty("email")]
      public string email { get; set; }
      #endregion
    }
    #endregion
  }
  
}

     using System;
  
      
      public class HeistMember
    {
        public string? Name{ get; set; }  //the ? means the property can be null

        public int? Skill { get; set; }

        public int? Courage { get; set; }

        public HeistMember(string name, int skill, int courage )
        {
            Name = name;
            Skill = skill; 
            Courage = courage;
        }


}
      
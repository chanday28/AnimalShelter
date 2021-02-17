using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



    public class ValuesAndSettings
    {
      
        //private List<String> 

        public static List<string> FamilySituationValues
        {
            get
            {
                List<String> familySituationValues = new List<string>();
                familySituationValues = new List<string>(){ "single", "married", "divorced", "seperated"};
                return familySituationValues;
            }

           
        }

        
    }

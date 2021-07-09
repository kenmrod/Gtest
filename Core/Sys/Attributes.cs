using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Core.Sys
{
    [System.AttributeUsage(System.AttributeTargets.Method)]
    public class Step : System.Attribute
    {
        public struct Parameter
        {
            public String Name;
            public Boolean IsDataDriven;
            public String Value;

            public Parameter(String[] parameterMembers)
            {
                Name = "";
                IsDataDriven = false;
                Value = "";

                for (int i = 0; i < parameterMembers.Count(); i++)
                {
                    switch (i)
                    {
                        case 0:
                            Name = parameterMembers[i];
                            break;
                        case 1:
                            IsDataDriven = Boolean.Parse(parameterMembers[i]);
                            break;
                        case 2:
                            Value = parameterMembers[i];
                            break;                       
                    }
                }
            }

        }
        public int stepnumber;
        public String component;
        public String description;
        public List<Parameter> Parameters;        

        public Step(int stepnumber, String component, String description, String[] parameters)
        {
            String[] parmMembers;
            Parameter newParm;

            this.stepnumber = stepnumber;
            this.description = description;
            this.component = component;
            Parameters = new List<Parameter>();
            for (int i = 0; i < parameters.Count(); i++)
            {
                parmMembers = parameters[i].Split('|');
                newParm = new Parameter(parmMembers);
                Parameters.Add(newParm);
            }
        }
    }
}

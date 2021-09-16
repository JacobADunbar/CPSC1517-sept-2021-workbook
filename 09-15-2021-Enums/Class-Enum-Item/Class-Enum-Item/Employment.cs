﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Enum_Item.Data
{
    public class Employment
    {
        //An instance in this class will describe an employment of a job
        //the characteristics will be
        //  Title, supervisory level, years of employment within that job

        //The four components are
        //  data field
        //  property
        //  constructor
        //  behaviour (aka method)

        //Data Field
        //This is a storage area in your program
        //This is a variable

        //a declared storage area will be associated with the Title property
        //normally this declaration is a private access type
        //one does not want an outside user to directly interact with the variable
        private string _Title;

        //Properties
        //These are access techniques to retrieve or set data in your class without directly touching the storage data field
        
        //  Fully implemented property
        //  a) declare storage area (data field)
        //  b) declare the property signature
        //  c) code a get "method"
        //  d) optinally code a set "method"

        public string Title {
            get 
            {
                //the get method will return the contents of a data field(s) as an expression
                return _Title;
            } 
            set 
            {
                //the set "method" (mutator) recieves an incoming value and places it in the associated data field
                //during the set method, you might wish to validate the incoming data for correctness
                //during the set "method", you might wish to do some type of logical processing against the incoming data
                //the incoming piece of data is refered to using the keyword "value"

                //Ensure that the incoming data is NOT null or empty
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("title is required piece of data");
                }
                else
                {
                    _Title = value;
                }
            }
        }

        //using an enum to declare a variable
        public SupervisoryLevel Level { get; set; }

        public double Years { get; set; }
    }
}

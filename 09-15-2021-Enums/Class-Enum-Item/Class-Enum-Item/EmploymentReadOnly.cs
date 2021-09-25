using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Enum_Item.Data
{
    public class EmploymentReadOnly
    {
        public readonly string Title;
        public readonly SupervisoryLevel Level;
        public readonly double Years;

        //in a read only class scenario, you will not likely find any property that will allow internal data to be altered
        //you may find behaviours that will allow changes to the data, remembering that internal logic can make changes
        //however, you still may have properties in your calss definition BUT they consist of only get components in the property


        //because your data is read only, you need to have a pathway for data to come into the class instance

        //one: use a greeddy constructor
        public EmploymentReadOnly(string title, SupervisoryLevel level, double years)
        {
            //validation that would normally exist in your property will NOW be coded in the constructor
            //In this example, we will be using a method from a static class that we have coded called utilities
            if (Utilities.IsEmpty(title))
            {
                throw new Exception("Job Title is required");
            }
            else
            {
                Title = title;
            }
            if (Utilities.IsPositive(years))
            {
                throw new Exception("Job years needs to be 0 or greater.");
            }
            else
            {
                Years = years;
            }
            Level = level;
        }

        public double EmploymentYears 
        {
            get { return Years; }
            init set { }
        }
    }
}

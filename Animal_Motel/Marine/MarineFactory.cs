using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;


namespace Animal_Motel
{
    /// <summary>
    /// This class has a set of methods for  creating different animals of the Marine category.
    /// </summary>
    public class MarineFactory
    {
        public static Marines CreateMarine(MarineSpecies Species)
        {
            Marines animalObj = null; //type not known at this time

            //type determined by late binding
            switch (Species)
            {
                case MarineSpecies.Dolphine:
                    animalObj = new Dolphine();           //Late binding
                    break;
                //Continue with the rest
                case MarineSpecies.Shark:
                    animalObj = new Shark();    //Late binding
                    break;

                default:
                    Debug.Assert(false, "To be completed!");
                    break;
            }

            //set the category
            animalObj.Category = CategoryType.Marine;

            return animalObj; //return the crated animal Object
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Animal_Motel
{
    /// <summary>
    /// This class has a set of methods for  creating different animals of the Birds category.
    /// </summary>
    public class BirdFactory
    {
        public static Birds CreateBird(BirdSpecies Species)
        {
            Birds animalObj = null; //type not known at this time

            //type determined by late binding
            switch (Species)
            {
                case BirdSpecies.Ostrich:
                    animalObj = new Ostrich();           //Late binding
                    break;
                //Continue with the rest
                case BirdSpecies.Parrot:
                    animalObj = new Parrot();    //Late binding
                    break;

                default:
                    Debug.Assert(false, "To be completed!");
                    break;
            }

            //set the category
            animalObj.Category = CategoryType.Bird;

            return animalObj; //return the crated animal Object
        }
    }
}

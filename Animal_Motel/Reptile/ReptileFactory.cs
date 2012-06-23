//File: ReptileFactory.cs
//Name: Padma Priya Duvvuri
//Date: 21/06/2012

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
    public class ReptileFactory
    {
        public static Reptiles CreateReptile(ReptileSpecies Species)
        {
            Reptiles animalObj = null; //type not known at this time

            //type determined by late binding
            switch (Species)
            {
                case ReptileSpecies.Snake:
                    animalObj = new Snake();           //Late binding
                    break;
                //Continue with the rest
                case ReptileSpecies.Lizard:
                    animalObj = new Lizard();    //Late binding
                    break;

                default:
                    Debug.Assert(false, "To be completed!");
                    break;
            }

            //set the category
            animalObj.Category = CategoryType.Reptile;

            return animalObj; //return the crated animal Object
        }
    }
}

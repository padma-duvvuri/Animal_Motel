//File: InsectFactory.cs
//Name: Padma Priya Duvvuri
//Date: 19/06/2012

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;


namespace Animal_Motel
{
    /// <summary>
    /// This class has a set of methods for  creating different animals of the Insect category.
    /// </summary>
    public class InsectFactory
    {
        public static Insects CreateInsect(InsectSpecies Species)
        {
            Insects animalObj = null; //type not known at this time

            //type determined by late binding
            switch(Species)
            {
                case InsectSpecies.Bee:
                    animalObj = new Bee();           //Late binding
                    break;
                //Continue with the rest
                case InsectSpecies.ButterFly:
                    animalObj = new ButterFly();    //Late binding
                    break;

                default:
                    Debug.Assert(false, "To be completed!");
                    break;
            }

            //set the category
            animalObj.Category = CategoryType.Insect;

            return animalObj; //return the crated animal Object
        }
    }
}

//File: MammalFactory.cs
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
    /// This class has a set of methods for  creating different animals of the Mammal category.
    /// </summary>
    public class MammalFactory
    {
        public static Mammals CreateMammal(MammalSpecies Species)
        {
            Mammals animalObj = null; //type not known at this time

            //type determined by late binding
            switch (Species)
            {
                case MammalSpecies.Cow:
                    animalObj = new Cow();           //Late binding
                    break;
                //Continue with the rest
                case MammalSpecies.Dog:
                    animalObj = new Dog();    //Late binding
                    break;

                default:
                    Debug.Assert(false, "To be completed!");
                    break;
            }

            //set the category
            animalObj.Category = CategoryType.Mammal;

            return animalObj; //return the crated animal Object
        }
    }
}

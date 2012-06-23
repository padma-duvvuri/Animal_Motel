//File: IAnimal.cs
//Name: Padma Priya Duvvuri
//Date: 18/06/2012


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal_Motel
{
    /// <summary>
    /// Interface IAnimal containing specific methods and properties that other classes 
    /// need to implement
    /// </summary>
    interface IAnimal
    {
        //ID for animal
        int ID { get; set; }

        //Name for animal
        string Name { get; set; }
        //Gender of the animal
        GenderType Gender { get; set; }
        //Category of the animal Bird, Insect etc.
        CategoryType Category { get; set; }
        //Age of the Animal
        double Age { get; set; }
        //Extra info
        string ExtraAnimalInfo { get; set; }
        //animal type
        string AnimalType { get; set; }

        //Other Methods
        string GetAnimalSpecificData();
    }
}

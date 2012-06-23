//File: Animal.cs
//Name: Padma Priya Duvvuri
//Date: 18/06/2012

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal_Motel
{
    /// <summary>
    /// This class inherits the Interface IAnimal and defied as abstract class
    /// so that other classe must inherit all from this class if inherited
    /// </summary>
    public abstract class Animal : IAnimal
    {
        private int m_ID; //ID for animal
        private string m_name; //pet name
        private GenderType m_gender; // gender
        private CategoryType m_category; // category that animal belongs to
        private double m_age; //age of the animal
        private string m_extraAnimalInfo; //additional information about the animal
        private string m_animalType; // animal specific information

        //default construdtor
        public Animal()
        { }

        /// <summary>
        /// property for m_animalType field
        /// </summary>
        public string AnimalType
        {
            get { return m_animalType; }
            set { m_animalType = value; }
        }

        /// <summary>
        /// property for m_name field
        /// </summary>
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        /// <summary>
        /// property for m_ID field
        /// </summary>
        public int ID
        {
            get { return m_ID; }
            set { m_ID = value; }
        }
        /// <summary>
        /// property for m_gender field
        /// </summary>
        public GenderType Gender
        {
            get { return m_gender; }
            set { m_gender = value; }
        }
        /// <summary>
        /// property for m_category field
        /// </summary>
        public CategoryType Category
        {
            get { return m_category; }
            set { m_category = value; }
        }
        /// <summary>
        /// property for m_age field
        /// </summary>
        public double Age
        {
            get { return m_age; }
            set { m_age = value; }
        }
        /// <summary>
        /// property for m_extraAnimalInfo field
        /// </summary>
        public string ExtraAnimalInfo
        {
            get { return m_extraAnimalInfo; }
            set { m_extraAnimalInfo = value; }
        }

        /// For all catzagories of animal objects, information specific to that 
        /// category should be implemented
        /// </summary>
        /// <returns></returns>
        public abstract string GetAnimalSpecificData();
    }
}

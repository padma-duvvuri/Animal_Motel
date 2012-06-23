//File: Cow.cs
//Name: Padma Priya Duvvuri
//Date: 19/06/2012

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal_Motel
{
    /// <summary>
    /// This class inherits the Mammals class
    /// Also defines properties and methods specific to Cows
    /// </summary>
    public class Cow : Mammals
    {
        //fields specific to Cows
        private int m_amountOfMilkPerDay;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Cow()
        {
        }

        /// <summary>
        /// Gets or sets the amount of milk this cow
        /// can produce (or has produced) per day
        /// </summary>
        public int AmountOfMilkPerDay
        {
            get { return this.m_amountOfMilkPerDay; }
            set { this.m_amountOfMilkPerDay = value; }
        }


        #region "Implementation of Abstract Methods"

        /// <summary>
        /// Implementation of Abstract class from Mammals.cs
        /// </summary>
        /// <returns>Retuns infomation about stinking nature of the Cow</returns>
        public override string PetOrBusinessData()
        {
            string strOut = "Part of a group for Milk Business!";
            return strOut;
          
        }

        /// <summary>
        /// Implementation of Abstract class from Animal.cs
        /// </summary>
        /// <returns>A string with information regarding Mammal Cow</returns>
        public override string GetAnimalSpecificData()
        {
            string strInfo = ExtraAnimalInfo;  //Call to porperty in base class (Animal.cs)
            string strout = (string.IsNullOrEmpty(strInfo) ? string.Empty : strInfo);
            strout += (IsPet ? "This is a Pet" : "This is not a Pet.");
            strout += Environment.NewLine;
            strout += string.Format("Produces {0} liters of milk per day", m_amountOfMilkPerDay);
         
            strout += Environment.NewLine + PetOrBusinessData();
            
            return strout;
        }

        #endregion

       
    }
}

//File: Dog.cs
//Name: Padma Priya Duvvuri
//Date: 19/06/2012

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal_Motel
{
    public class Dog : Mammals
    {

        //fields specific to Dogs
        private int m_numberOfTeeth;

         /// <summary>
        /// Default Constructor
        /// </summary>
        public Dog()
        {
        }

        /// <summary>
        ///Gets or Sets the number of teeth that dog has
        /// </summary>
        public int NumberOfTeeth
        {
            get { return m_numberOfTeeth; }
            set { m_numberOfTeeth = value; }
        }



        #region "Implementation of Abstract Methods"

        /// <summary>
        /// Implementation of Abstract class from Mammals.cs
        /// </summary>
        /// <returns>Retuns infomation about stinking nature of the Dog</returns>
        public override string PetOrBusinessData()
        {
            string strOut = "It's not used for any business purposes.";
            strOut += Environment.NewLine;
            strOut += string.Format("Number of Teeth are {0} ", NumberOfTeeth);
            return strOut;

        }

        /// <summary>
        /// Implementation of Abstract class from Animal.cs
        /// </summary>
        /// <returns>A string with information regarding Mammal Dog</returns>
        public override string GetAnimalSpecificData()
        {
            string strInfo = ExtraAnimalInfo;  //Call to porperty in base class (Animal.cs)
            string strout = (string.IsNullOrEmpty(strInfo) ? string.Empty : strInfo);
            strout += (IsPet ? "This is a Pet" : "This is a K-9!");
            if (UnderQuarantine)
            {
                strout += string.Format("Under quarantine, Days in Quarantine are {0} ", DaysQuarantine);
            }
            strout += Environment.NewLine + PetOrBusinessData();
            return strout;
        }

        #endregion
    }
}

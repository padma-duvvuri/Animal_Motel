//File: Lizard.cs
//Name: Padma Priya Duvvuri
//Date: 21/06/2012

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal_Motel
{
    /// <summary>
    /// This class inherits the Reptiles class
    /// Also defines properties and methods specific to Lizards
    /// </summary>
    public class Lizard : Reptiles
    {
        //fields specific to Lizards
        private bool m_isChamelian;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Lizard()
        {
        }


        /// <summary>
        /// Gets or sets the whether the Lizard is a Chamelian or
        /// not
        /// </summary>
        public bool IsChamelian
        {
            get { return m_isChamelian; }
            set { m_isChamelian = value; }
        }

        #region "implementation of Abstract Methods"

        /// <summary>
        /// Implementation of Abstract class from Animal.cs
        /// </summary>
        /// <returns>A string with information regarding Reptile Lizard</returns>
        public override string GetAnimalSpecificData()
        {
            string strInfo = ExtraAnimalInfo;  //Call to porperty in base class (Animal.cs)
            string strout = (string.IsNullOrEmpty(strInfo) ? string.Empty : strInfo);

            strout += Environment.NewLine + BiteAndDangerousData();
            strout += (IsPoisonous ? "Rare Poisonoues Type" : "This Lizard type is not dangerous.");
            return strout;
        }

        /// <summary>
        /// Implementation of Abstract class from Reptiles.cs
        /// </summary>
        /// <returns>Retuns infomation about Lizards</returns>
        public override string BiteAndDangerousData()
        {
            string strOut = "Can bite. ";

            strOut += (IsChamelian ? "This is a Chamelian, It can change colous." : "Type Unknown.");

            return strOut;
        }
        #endregion
    }
}

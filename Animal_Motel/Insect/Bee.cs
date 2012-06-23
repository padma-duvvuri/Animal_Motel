//File: Bee.cs
//Name: Padma Priya Duvvuri
//Date: 19/06/2012

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal_Motel
{
    /// <summary>
    /// This class inherits the Insects class
    /// Also defines properties and methods specific to Bees
    /// </summary>
    public class Bee : Insects
    {
        //fields specific to Bees
        private int m_amountOfHoneyPerMonth;
        private bool m_isHoneyBee;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Bee()
        {
        }

        /// <summary>
        /// Gets or sets the amount of honey this bee
        /// can produce (or has produced) per month
        /// </summary>
        public int AmountOfHoneyPerMonth
        {
            get { return this.m_amountOfHoneyPerMonth; }
            set { this.m_amountOfHoneyPerMonth = value; }
        }

        /// <summary>
        /// Gets or sets the whether the Bees is Honeybee or
        /// not
        /// </summary>
        public bool IsHoneyBee
        {
            get { return m_isHoneyBee; }
            set { m_isHoneyBee = value; }
        }

        #region "implementation of Abstract Methods"

        /// <summary>
        /// Implementation of Abstract class from Animal.cs
        /// </summary>
        /// <returns>A string with information regarding Insect bee</returns>
        public override string  GetAnimalSpecificData()
        {
            string strInfo = ExtraAnimalInfo;  //Call to porperty in base class (Animal.cs)
            string strout = (string.IsNullOrEmpty(strInfo) ? string.Empty : strInfo);

            if (IsHoneyBee)
            {
                strout += string.Format("Produces {0} liters of honey", m_amountOfHoneyPerMonth);
            }
            strout += Environment.NewLine + SetStinkAndInvasiveData();
            strout += (IsPoisonous ? "This bee type is poisonous." : "This bee type is not poisonous.");
            return strout;
        }

        /// <summary>
        /// Implementation of Abstract class from Insects.cs
        /// </summary>
        /// <returns>Retuns infomation about stinking nature of the Bee</returns>
        public override string SetStinkAndInvasiveData()
        {
            string strOut = "Not stinky but it can be invasive when bothered!";

            return strOut;
        }
        #endregion
    }
}

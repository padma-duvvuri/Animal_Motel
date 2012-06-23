//File: Shark.cs
//Name: Padma Priya Duvvuri
//Date: 20/06/2012

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal_Motel
{
    /// <summary>
    /// This class inherits the Insects class
    /// Also defines properties and methods specific to Sharks
    /// </summary>
    public class Shark : Marines
    {
        //fields specific to Sharks
        private bool m_IsDangerous;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Shark()
        {
        }


        /// <summary>
        /// Gets or sets the whether this animal is dangerous or not
        /// </summary>
        public bool IsDangerous
        {
            get { return m_IsDangerous; }
            set { m_IsDangerous = value; }
        }

        #region "implementation of Abstract Methods"

        /// <summary>
        /// Implementation of Abstract class from Animal.cs
        /// </summary>
        /// <returns>A string with information regarding Marine Shark</returns>
        public override string GetAnimalSpecificData()
        {
            string strInfo = ExtraAnimalInfo;  //Call to porperty in base class (Animal.cs)
            string strout = (string.IsNullOrEmpty(strInfo) ? string.Empty : strInfo);

            strout += Environment.NewLine + DangerousAndWildData();
            strout += (IsScary ? "This animal is scary" : "This animal is not that scary");
            return strout;
        }

        /// <summary>
        /// Implementation of Abstract class from Marines.cs
        /// </summary>
        /// <returns>Retuns infomation about Shark</returns>
        public override string DangerousAndWildData()
        {
            string strOut = "Lot of Movies are made about this animal";
            strOut += (IsDangerous ? "This animal is very wild and dangerous" : "This animal is already trained, so won't harm anyone");
            return strOut;
        }
        #endregion
    }
}

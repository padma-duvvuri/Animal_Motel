﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal_Motel
{
    /// <summary>
    /// This class inherits the Insects class
    /// Also defines properties and methods specific to Bees
    /// </summary>
    public class Dolphine : Marines
    {
        //fields specific to Dolphines
        private bool m_CanBeTrained;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Dolphine()
        {
        }


        /// <summary>
        /// Gets or sets the whether this animal can be trained for entertainment purpose or not
        /// </summary>
        public bool CanBeTrained
        {
            get { return m_CanBeTrained; }
            set { m_CanBeTrained = value; }
        }

        #region "implementation of Abstract Methods"

        /// <summary>
        /// Implementation of Abstract class from Animal.cs
        /// </summary>
        /// <returns>A string with information regarding Insect bee</returns>
        public override string GetAnimalSpecificData()
        {
            string strInfo = ExtraAnimalInfo;  //Call to porperty in base class (Animal.cs)
            string strout = (string.IsNullOrEmpty(strInfo) ? string.Empty : strInfo);

            strout += Environment.NewLine + DangerousAndWildData() + Environment.NewLine ;
            strout += (IsScary ? "This animal very joyful and Playfull, Not Scary at all!" : "This animal is little scary.");
            return strout;
        }

        /// <summary>
        /// Implementation of Abstract class from Insects.cs
        /// </summary>
        /// <returns>Retuns infomation about stinking nature of the Bee</returns>
        public override string DangerousAndWildData()
        {
            string strOut = "This animal very lively animal";

            strOut += (CanBeTrained ? "Cab be Trained!" : "Cannot be trained");

            return strOut;
        }
        #endregion
    }
}

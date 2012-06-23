//File: Mammals.cs
//Name: Padma Priya Duvvuri
//Date: 19/06/2012

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal_Motel
{
    /// <summary>
    /// This class inherits the Animal Class and defied as abstract class
    /// so that other classe must inherit all from this class if inherited
    /// </summary>
    public abstract class Mammals : Animal
    {
        //Tfield specific to mammals
        private bool m_isPet; // whehter this mammal is pet or not
        private bool m_underQuarantine; //whether the mammel is under quarantine or not
        private int m_daysQuarantine;


        /// <summary>
        /// Default constructor
        /// </summary>
        public Mammals()
        {
        }

        /// <summary>
        /// property for m_isPet field
        /// </summary>
        public bool IsPet
        {
            get { return this.m_isPet; }
            set { this.m_isPet = value; }
        }
        /// <summary>
        ///Gets or Sets the number of days in quarantine
        /// </summary>
        public int DaysQuarantine
        {
            get { return m_daysQuarantine; }
            set { m_daysQuarantine = value; }
        }

        /// <summary>
        /// Gets or sets wether the dog is under quarantine or not
        /// </summary>
        public bool UnderQuarantine
        {
            get { return m_underQuarantine; }
            set { m_underQuarantine = value; }
        }
        /// <summary>
        /// Lot of mammals kept as pets and some as group for business purpose
        /// For mil etc.
        /// </summary>
        /// <returns></returns>
        public abstract string PetOrBusinessData();

    }
}

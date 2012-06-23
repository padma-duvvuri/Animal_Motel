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
        /// Lot of mammals kept as pets and some as group for business purpose
        /// For mil etc.
        /// </summary>
        /// <returns></returns>
        public abstract string PetOrBusinessData();

    }
}

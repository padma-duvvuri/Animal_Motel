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
        //mammal gives milk for people
        private bool m_isPet;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Mammals()
        {
        }

        /// <summary>
        /// property for m_givesMilkForPeople field
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

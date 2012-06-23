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
    public abstract class Birds : Animal
    {
        //mammal gives milk for people
        private bool m_canFly;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Birds()
        {
        }

        /// <summary>
        /// property for m_givesMilkForPeople field
        /// </summary>
        public bool CanFly
        {
            get { return this.m_canFly; }
            set { this.m_canFly = value; }
        }

        /// <summary>
        /// Some birds kept as pets, and some used for poultry business purposes
        /// </summary>
        /// <returns></returns>
        public abstract string PetOrPoultryBusinessData();
    }
}

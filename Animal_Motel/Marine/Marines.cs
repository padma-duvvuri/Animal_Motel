//File: Marines.cs
//Name: Padma Priya Duvvuri
//Date: 20/06/2012

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
    public abstract class Marines : Animal
    {
        //fileds specific to Marines
        private bool m_isScary;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Marines()
        {
        }

        /// <summary>
        /// property for m_isScary field
        /// </summary>
        public bool IsScary
        {
            get { return m_isScary; }
            set { m_isScary = value; }
        }

        /// <summary>
        /// For all Marines objects, info on whethere they are dangerous and wild
        /// </summary>
        /// <returns></returns>
        public abstract string DangerousAndWildData();

    }
}

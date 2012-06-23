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
        //insect poisonous or not
        private bool m_isScary;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Marines()
        {
        }

        /// <summary>
        /// property for m_ispoisonous field
        /// </summary>
        public bool IsScary
        {
            get { return m_isScary; }
            set { m_isScary = value; }
        }

        /// <summary>
        /// For all insects objects, info on their invasiveness and stinkynss
        /// should be provided
        /// </summary>
        /// <returns></returns>
        public abstract string DangerousAndWildData();

    }
}

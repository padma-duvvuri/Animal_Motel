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
    public abstract class Reptiles : Animal
    {
        //insect poisonous or not
        private bool m_ispoisonous;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Reptiles()
        {
        }

        /// <summary>
        /// property for m_ispoisonous field
        /// </summary>
        public bool IsPoisonous
        {
            get { return m_ispoisonous; }
            set { m_ispoisonous = value; }
        }

        /// <summary>
        /// For all insects objects, info on their invasiveness and stinkynss
        /// should be provided
        /// </summary>
        /// <returns></returns>
        public abstract string BiteAndDangerousData();

    }
}

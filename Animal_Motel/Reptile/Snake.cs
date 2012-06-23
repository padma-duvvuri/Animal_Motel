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
    public class Snake : Reptiles
    {
        //fields specific to Bees
        private bool m_isCobra;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Snake()
        {
        }


        /// <summary>
        /// Gets or sets the whether the Bees is Honeybee or
        /// not
        /// </summary>
        public bool IsCobra
        {
            get { return m_isCobra; }
            set { m_isCobra = value; }
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

            strout += Environment.NewLine + BiteAndDangerousData();
            strout += (IsPoisonous ? "This snake is very poisonous." : "This snake type is not poisonous.");
            return strout;
        }

        /// <summary>
        /// Implementation of Abstract class from Insects.cs
        /// </summary>
        /// <returns>Retuns infomation about stinking nature of the Bee</returns>
        public override string BiteAndDangerousData()
        {
            string strOut = "Can bite ";

            strOut += (IsCobra ? "This is a Cobra." : "Type Unknown.");

            return strOut;
        }
        #endregion
    }
}

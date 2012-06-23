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
    public class Lizard : Reptiles
    {
        //fields specific to Bees
        private bool m_isChamelian;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Lizard()
        {
        }


        /// <summary>
        /// Gets or sets the whether the Bees is Honeybee or
        /// not
        /// </summary>
        public bool IsChamelian
        {
            get { return m_isChamelian; }
            set { m_isChamelian = value; }
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
            strout += (IsPoisonous ? "Rare Poisonoues Type" : "This Lizard type is not dangerous.");
            return strout;
        }

        /// <summary>
        /// Implementation of Abstract class from Insects.cs
        /// </summary>
        /// <returns>Retuns infomation about stinking nature of the Bee</returns>
        public override string BiteAndDangerousData()
        {
            string strOut = "Can bite. ";

            strOut += (IsChamelian ? "This is a Chamelian, It can change colous." : "Type Unknown.");

            return strOut;
        }
        #endregion
    }
}

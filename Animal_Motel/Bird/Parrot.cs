using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal_Motel
{/// <summary>
    /// This class inherits the Birds class
    /// Also defines properties and methods specific to Parrots
    /// </summary>
    class Parrot : Birds
    {
        //field specific to Parrot
        private bool m_canTalk;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Parrot()
        {
        }

        /// <summary>
        /// Gets or sets the whether the Parrot can talk
        /// </summary>
        public bool CanTalk
        {
            get { return m_canTalk; }
            set { m_canTalk = value; }
        }

        #region "Implementation of Abstract Methods"

        /// <summary>
        /// Implementation of Abstract class from Birds.cs
        /// </summary>
        /// <returns>Retuns infomation about stinking nature of the Dog</returns>
        public override string PetOrPoultryBusinessData()
        {
            string strOut = "It is kept as pet";
           
            return strOut;

        }

        /// <summary>
        /// Implementation of Abstract class from Animal.cs
        /// </summary>
        /// <returns>A string with information regarding Mammal Cow</returns>
        public override string GetAnimalSpecificData()
        {
            string strInfo = ExtraAnimalInfo;  //Call to porperty in base class (Animal.cs)
            string strout = (string.IsNullOrEmpty(strInfo) ? string.Empty : strInfo);

            strout += (CanTalk ? "This parrot can talk too" : "Sorry it Cannot talk!");

            strout += Environment.NewLine + PetOrPoultryBusinessData();
            return strout;
        }
        #endregion
    }
}

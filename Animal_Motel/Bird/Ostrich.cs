using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal_Motel
{/// <summary>
    /// This class inherits the Birds class
    /// Also defines properties and methods specific to Ostrich
    /// </summary>
    public class Ostrich : Birds
    {
        //fields specific to Ostrich
        private bool m_layEggs; //whether this animal can lay eggs
        private int m_numberOfEggs;

         /// <summary>
        /// Default Constructor
        /// </summary>
        public Ostrich()
        {
        }

        /// <summary>
        ///Gets or Sets the number of teeth that dog has
        /// </summary>
        public int NumberOfEggs
        {
            get { return m_numberOfEggs; }
            set { m_numberOfEggs = value; }
        }

        /// <summary>
        /// Gets or sets wether the dog is under quarantine or not
        /// </summary>
        public bool LayEggs
        {
            get { return m_layEggs; }
            set { m_layEggs = value; }
        }

        #region "Implementation of Abstract Methods"

        /// <summary>
        /// Implementation of Abstract class from Mammals.cs
        /// </summary>
        /// <returns>Retuns infomation about stinking nature of the Dog</returns>
        public override string PetOrPoultryBusinessData()
        {
            string strOut = "It is used for Poultry business. ";
            if (LayEggs)
            {
                strOut += string.Format("Eggs it can lay per year are {0} ", NumberOfEggs);
            }
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

            strout += (CanFly ? "Amazing it can Fly" : "It cannot fly as it is a huge bird.");

            strout += Environment.NewLine + PetOrPoultryBusinessData();
            return strout;
        }

        #endregion
       }
}

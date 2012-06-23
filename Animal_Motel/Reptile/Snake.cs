//File: Snake.cs
//Name: Padma Priya Duvvuri
//Date: 21/06/2012

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal_Motel
{
    /// <summary>
    /// This class inherits the Reptiles class
    /// Also defines properties and methods specific to Snake
    /// </summary>
    public class Snake : Reptiles
    {
        //fields specific to Reptiles
        private bool m_isCobra; 

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Snake()
        {
        }


        /// <summary>
        /// Gets or sets the whether the snake is a cobra or
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
        /// <returns>A string with information regarding Reptile Snake</returns>
        public override string GetAnimalSpecificData()
        {
            string strInfo = ExtraAnimalInfo;  //Call to porperty in base class (Animal.cs)
            string strout = (string.IsNullOrEmpty(strInfo) ? string.Empty : strInfo);

            strout += Environment.NewLine + BiteAndDangerousData();
            strout += (IsPoisonous ? "This snake is very poisonous." : "This snake type is not poisonous.");
            return strout;
        }

        /// <summary>
        /// Implementation of Abstract class from Reptiles.cs
        /// </summary>
        /// <returns>Retuns infomation about Snake</returns>
        public override string BiteAndDangerousData()
        {
            string strOut = "Can bite ";

            strOut += (IsCobra ? "This is a Cobra." : "Type Unknown.");

            return strOut;
        }
        #endregion
    }
}

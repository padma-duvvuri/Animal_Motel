//File: ButterFlys.cs
//Name: Padma Priya Duvvuri
//Date: 19/06/2012

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal_Motel
{
    /// <summary>
    /// This class inherits the Insects class
    /// Also defines properties and methods specific to ButterFly
    /// </summary>
    class ButterFly : Insects
    {
        //field specific to ButterFly
        private bool m_larvalPhase;

         /// <summary>
        /// Constructor - Create an instance of an Insect
        /// </summary>
        public ButterFly()
        {
        }

        /// <summary>
        /// Gets or sets the whether the Butterfly is in the larvaphase or
        /// not
        /// </summary>
        public bool IsLarvalPhase
        {
            get { return m_larvalPhase; }
            set { m_larvalPhase = value; }
        }

        #region "Implementation of Abstract Methods"

        /// <summary>
        /// Implementation of the abstract method in the base class
        /// </summary>
        /// <returns>A string containing specific info about the Butterfly</returns>
        /// <remarks></remarks>
        public override string GetAnimalSpecificData()
        {
            dynamic strInfo = ExtraAnimalInfo;
            string strout = (string.IsNullOrEmpty(strInfo) ? string.Empty : strInfo);

            string strLarval = " not ";
            if (m_larvalPhase)
            {
                strLarval = "";
            }

            strout += string.Format("This butterfly is  {0} In the larval phase.", strLarval);
            strout += Environment.NewLine + SetStinkAndInvasiveData();
            return strout;
        }


        /// <summary>
        /// Implementation of Abstract class from Insects.cs
        /// </summary>
        /// <returns>Retuns infomation about stinking nature of the ButterFly</returns>
        public override string SetStinkAndInvasiveData()
        {
            string strOut = "Butterflies are beautiful.  They do not stink or get aggressive!";
            return strOut;
        }
        #endregion
    }
}

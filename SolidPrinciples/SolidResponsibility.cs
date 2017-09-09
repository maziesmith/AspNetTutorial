using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class SolidResponsibility
    {
        #region Constructor

        public SolidResponsibility()
        {

        }

        #endregion

        #region Functions

        /// <summary>
        /// This method can write any solid setttings
        /// </summary>
        public void WriteSolidResponsibilitySettins()
        {
            Console.WriteLine("Solid Responsibility");
        }

        /// <summary>
        /// This method can initialize mail Instance but
        /// it is not depends on this class we have to change principle design 
        /// and have to move anathor class
        /// </summary>
        public void InitializeMailInstance() => Console.WriteLine("Initalize Mail Instance");

        #endregion

    }

    public class MailHelper
    {
        #region Constructor
        public MailHelper()
        {

        }
        #endregion

        #region Functions

        /// <summary>
        /// This method can initialize mail Instance
        /// and have to move anathor class
        /// </summary>
        public void InitializeMailInstance()
        {
            Console.WriteLine("Initalize Mail Instance");
        }

        #endregion
    }
}

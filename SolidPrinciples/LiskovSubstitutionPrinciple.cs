using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class LiskovSubstitutionPrinciple
    {
        public LiskovSubstitutionPrinciple()
        {

        }

    }

    /// <summary>
    /// We deattached this interface cause that did not suitable
    /// </summary>
    public interface IDeveloper
    {
        void ProjectDevelope();
        void UseSolidPrinciple();
    }

    /// <summary>
    /// 
    /// </summary>
    //public class JuniorDeveloper : IDeveloper
    //{
    //    public void ProjectDevelope()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void UseSolidPrinciple()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    public class JuniorDeveloper : Developer
    {
        public override void ProjectDevelope()
        {
            Console.WriteLine("Project Develope Task");
        }
    }

    //public class SeniorDeveloper : IDeveloper
    //{
    //    public void ProjectDevelope()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void UseSolidPrinciple()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    public class SeniorDeveloper : Developer, IUseSolidPrinciple
    {
        public override void ProjectDevelope()
        {
            Console.WriteLine("Project Develope Task");
        }

        public void UseSolidPrinciple()
        {
            Console.WriteLine("Use Solid Principle Task");
        }
    }

    public abstract class Developer
    {
        public abstract void ProjectDevelope();
    }

    public interface IUseSolidPrinciple
    {
        void UseSolidPrinciple();
    }
}

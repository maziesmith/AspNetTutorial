using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    /// <summary>
    /// This principle must not add more abilities as far as needed
    /// </summary>
    public class InterfaceSegregationPrinciple
    {
    }

    /// <summary>
    /// This interface shared common abilities which have computers
    /// </summary>
    public interface IComputer
    {
        void Run();
        void Off();
    }

    /// <summary>
    /// this interface based on spesific abilities computer
    /// </summary>
    public interface ITuneUpKey : IComputer
    {
        void TuneUpKey();
    }

    public class Lenova : IComputer
    {
        public void Off()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }

    public class MSI : ITuneUpKey
    {
        public void Off()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void TuneUpKey()
        {
            throw new NotImplementedException();
        }
    }
}

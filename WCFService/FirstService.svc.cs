using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService
{

    public class FirstService : IFirstService
    {
        public string Hi(string name)
        {
            return "Hi," + name;
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public string Welcome()
        {
            return "Welcome";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercises2
{
    internal class AreaOfCircle
    {
        public static double AreaOfCircles(double radius) 
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}

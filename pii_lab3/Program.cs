using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pii_lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task ts = new Task();
            ts.start();
            int [,] a = { { 2,1}, { 1, 3 } };
            int [,] b = { { 1,2}, { 3, 1 } };
            Matrix mx = new Matrix();
            mx.start(a, b);
        }
    }
}

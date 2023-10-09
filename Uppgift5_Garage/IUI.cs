using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift5_Garage
{
    internal interface IUI
    {
        string GetInput();

        void Print(string message);
    }
}

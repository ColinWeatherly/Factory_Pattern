/* Name: Colin Weatherly
 * Date: 2/5/2022
 * File: Line.cs
 * IDE: Visual Studio 2019
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    class Line : IGeometricShape
    {
        void IGeometricShape.draw()
        {
            Console.WriteLine("Line is drawn.");
        }
    }
}

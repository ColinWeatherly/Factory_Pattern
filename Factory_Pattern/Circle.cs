/* Name: Colin Weatherly
 * Date: 2/5/2022
 * File: Circle.cs
 * IDE: Visual Studio 2019
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    class Circle : IGeometricShape
    {
        void IGeometricShape.draw()
        {
            Console.WriteLine("Circle is drawn.");
        }
    }
}

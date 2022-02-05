/* Name: Colin Weatherly
 * Date: 2/5/2022
 * File: Rectangle.cs
 * IDE: Visual Studio 2019
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    class Rectangle : IGeometricShape
    {
        void IGeometricShape.draw()
        {
            Console.WriteLine("Rectangle is drawn.");
        }
    }
}

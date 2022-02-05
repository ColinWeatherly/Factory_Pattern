/* Name: Colin Weatherly
 * Date: 2/4/2022
 * File: Rectangle.cs
 * IDE: Visual Studio 2019
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    class Rectangle : GeometricShape
    {
        void GeometricShape.draw()
        {
            Console.WriteLine("Rectangle is drawn.");
        }
    }
}

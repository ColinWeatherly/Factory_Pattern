/* Name: Colin Weatherly
 * Date: 2/4/2022
 * File: Circle.cs
 * IDE: Visual Studio 2019
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    class Circle : GeometricShape
    {
        void GeometricShape.draw()
        {
            Console.WriteLine("Circle is drawn.");
        }
    }
}

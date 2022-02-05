/* Name: Colin Weatherly
 * Date: 2/5/2022
 * File: Program.cs
 * IDE: Visual Studio 2019
 */

using System;

namespace Factory_Pattern
{
    class Program
    {
        static void Main()
        {
            ShapeFactory factory = new ShapeFactory();
            for (ShapeType test = ShapeType.LINE; test <= ShapeType.TRIANGLE; test++)
            {
                IGeometricShape shape = factory.getShape(test);
                if (shape != null)
                {
                    shape.draw();
                }
            }
        }
    }
}

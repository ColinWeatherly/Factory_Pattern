/* Name: Colin Weatherly
 * Date: 2/4/2022
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
            for (ShapeFactory.ShapeType test = ShapeFactory.ShapeType.LINE; test <= ShapeFactory.ShapeType.TRIANGLE; test++)
            {
                GeometricShape shape = factory.getShape(test);
                if (shape != null)
                {
                    shape.draw();
                }
            }
        }
    }
}

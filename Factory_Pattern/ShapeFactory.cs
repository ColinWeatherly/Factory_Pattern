/* Name: Colin Weatherly
 * Date: 2/5/2022
 * File: ShapeFactory.cs
 * IDE: Visual Studio 2019
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public enum ShapeType
    {
        LINE,
        CIRCLE,
        RECTANGLE,
        TRIANGLE
    }

    public class ShapeFactory
    {

        public IGeometricShape getShape(ShapeType type)
        {
            switch (type)
            {
                case ShapeType.LINE:
                    {
                        return new Line();
                    }
                case ShapeType.CIRCLE:
                    {
                        return new Circle();
                    }
                case ShapeType.RECTANGLE:
                    {
                        return new Rectangle();
                    }
                default:
                    {
                        Console.WriteLine("This shape has not been implemented.");
                        return null;
                    }
            }
        }
    }
}

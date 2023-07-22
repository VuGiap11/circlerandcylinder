using CloudinaryDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lopcicler
{
    public class Circle
    {
        public double radius;

        public Circle()
        {

        }

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double GetRadius()
        {
            return radius;
        }
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
        public double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }
        public override string ToString()
        {
            return $"Circle - Radius: {radius}, Area: {GetArea()}, Perimeter: {GetPerimeter()}";
        }
    }
    public class Cylinder : Circle
    {
        private double height;
        public Cylinder()
        {

        }
        public Cylinder(double radius, double height) : base(radius)
        {
            this.height = height;
        }
        public double GetHeight()
        {
            return height;
        }
        public double SetHeight(double height)
        {
            return this.height = height;
        }
        public double GetVolume()
        {
            return base.GetRadius() * height;
        }
        public double GetSurfaceArea()
        {
            return 2 * base.GetArea() + base.GetPerimeter() * height;
        }
        public override string ToString()
        {
            return $"Cylinder - Radius: {radius}, Height: {height}, Volume: {GetVolume()}, Surface Area: {GetSurfaceArea()}";
        }
    }
}

﻿using System;

public class Rectangle : Shape
{
    private double height;
    private double width;

    public Rectangle(double height, double width)
    {
        this.Height = height;
        this.Width = width;
    }

    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    

    public double Height
    {
        get { return height; }
        set { height = value; }
    }

    public override double CalculateArea()
    {
        return this.Height * this.Width;
    }

    public override double CalculatePerimeter()
    {
        return 2 * this.Height + 2 * this.Width;
    }

    public override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}
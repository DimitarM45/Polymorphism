using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
	public class Rectangle : Shape
	{
		private double height;

		private double width;

		public Rectangle(double height, double width)
		{
			this.height = height;
			this.width = width;
		}

		public override double CalculateArea() => height * width;

		public override double CalculatePerimeter() => 2 * (height + width);

		public override string Draw()
		{
			StringBuilder rectangle = new StringBuilder();

			StringBuilder widthLine = new StringBuilder();
			StringBuilder emptyWidthLine = new StringBuilder();

			for (int i = 1; i <= width; i++)
				widthLine.Append("*");

			for (int i = 1; i <= width - 2; i++)
				emptyWidthLine.Append(" ");

			rectangle.AppendLine(widthLine.ToString());

			for (int i = 1; i <= height; i++)
				rectangle.AppendLine($"*{emptyWidthLine}*");

			rectangle.AppendLine(widthLine.ToString());

			return rectangle.ToString().TrimEnd();
		}
	}
}

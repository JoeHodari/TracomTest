using System;

class Rectangle{
	static void Main( string[] args){
		int length, width, area; 

		Console.Write("Enter the length of the rectangle: ");
		length = Convert.ToInt16(Console.ReadLine());
		Console.Write("Enter the width of the rectangle: ");
		width = Convert.ToInt16(Console.ReadLine());

		int compute(){
			area = length * width;
			return area;
		}
		compute();
		Console.Write("The area of the rectangle is: " +area);
		
	}
}

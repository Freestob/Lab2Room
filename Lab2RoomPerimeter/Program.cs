using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2RoomPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            
               Console.WriteLine("This program will display the area and the perimeter for a room in which you enter the dimensions.");

                double roomLength, roomWidth, roomHeight;
                char runAgain;
            bool decision = true;
            while (decision == true)
            {
                roomLength = GetLength();
                roomWidth = GetWidth();
                roomHeight = GetHeight();

                double roomArea = roomLength * roomWidth;
                double roomPerimeter = roomLength * 2 + roomWidth * 2;
                double roomVolume = roomLength * roomWidth * roomHeight;

                Console.WriteLine("\n" + "The area of the room is " + roomArea + " feet.");
                Console.WriteLine("\n" + "The perimeter of the room is " + roomPerimeter + " feet.");
                Console.WriteLine("\n" + "The volume of the room is " + roomVolume + " feet.");
            }
                Console.WriteLine("Do you want to run again (Y/N)? ");
            runAgain = Convert.ToChar(Console.ReadLine());
            if (runAgain != 'Y' && runAgain != 'y');
            {
                decision = false;
            }
            
               

        }
            static double GetLength()
            {
                string userLength;
                double roomLength;
                Console.WriteLine("Please enter the length of the room in feet.");
                userLength = Console.ReadLine();
                bool succes = double.TryParse(userLength, out roomLength);
                if (succes == true)
                {
                    return roomLength;
                }
                else
                    Console.WriteLine("Please enter in a valid number");
                    return GetLength();
            }
            static double GetWidth()
            {
                string userWidth;
                double roomWidth;
                Console.WriteLine("Please enter the width of the room in feet.");
                userWidth = Console.ReadLine();
                bool succes = double.TryParse(userWidth, out roomWidth);
                if (succes == true)
                {
                    return roomWidth;
                }
                else
                    Console.WriteLine("Please enter in a valid number");
                return GetWidth();

            }
        static double GetHeight()
        {
            string userHeight;
            double roomHeight;
            Console.WriteLine("Please enter the height of the room in feet.");
            userHeight = Console.ReadLine();
            bool succes = double.TryParse(userHeight, out roomHeight);
            if (succes == true)
            {
                return roomHeight;
            }
            else
                Console.WriteLine("Please enter in a valid number");
            return GetHeight();

        }
    }
}

//*********************************************************************************************************************************************
//*********************************************************************************************************************************************
//************                              STUDENT NAME:SUDENAZ KIZILÇAY                                        ******************************
//************                              STUDENT NUMBER:B231202050                                            ******************************
//*********************************************************************************************************************************************
//*********************************************************************************************************************************************

using System; // Basic .NET classes
using System.Collections.Generic;// For collection classes like List<T>
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b231202050new
{
    public class Point2D // Represents a 2D point with Cartesian and Polar coordinate methods
    {
        private double x, y; // Private fields for X and Y coordinates
        public double X { get => x; set => x = value; } // Public X property
        public double Y { get => y; set => y = value; } // Public Y property

        public Point2D(double x, double y) // Constructor with specified coordinates
        {
            this.x = x;
            this.y = y;
        }
        public Point2D()  // Default constructor – random coordinates between 0 and 3
        {
            Random rnd = new Random();
            x = rnd.Next(0, 4); // Random  x: 0-3
            y = rnd.Next(0, 4); // Random  y: 0-3
        }

        public void PrintKoordinat() // Prints the Cartesian coordinates to the console
        {
            Console.WriteLine("Coordinates: ({x}, {y})");
        }
        public (double r, double theta) CalculatePolarCoordinates()  // Calculates polar coordinates (r, θ) from (x, y)
        {
            double r = Math.Sqrt(x * x + y * y);// Radius

            double theta = Math.Atan2(y, x) * (180 / Math.PI); // Angle in degrees
            if (theta < 0) theta += 360; // Ensure angle is in [0, 360)

            return (r, theta);//Return
        }

        public void CalculateCartesianCoordinates(double r, double theta) // Sets (x, y) based on polar coordinates (r, θ)
        {
            double rad = theta * (Math.PI / 180); // Convert degrees to radians
            x = r * Math.Cos(rad); // X = r cos(θ)
            y = r * Math.Sin(rad); // Y = r sin(θ)
        }
        public string PrintPolarKoordinat()  // Returns polar coordinates as formatted string
        {
            var (r, theta) = CalculatePolarCoordinates();  // Get polar coordinates

            return ("Polar Coordinates: r={r:F2}, θ ={ theta:F2}°"); // Corrected interpolation
        }
    }
}
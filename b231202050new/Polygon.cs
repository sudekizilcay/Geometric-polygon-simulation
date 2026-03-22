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

using System.Drawing; // Graphical operations (color, drawing, etc.)


namespace b231202050new
{
    public class Polygon //Regular polygon
    {
        public Point2D Center { get; set; } // Center point of the polygon
        public int Length { get; set; }    // Length from center to a vertex
        public ColorRGB Color { get; set; } // Color of the polygon
        public int NumberOfEdges { get; set; }  // Number of sides of the polygon
        public List<Point2D> Vertices { get; private set; } // List of vertex coordinates

        public Polygon()   // Default Constructor creates a polygon with random properties
        {
            Random rnd = new Random();
            Center = new Point2D(rnd.Next(0, 100), rnd.Next(0, 100)); //  Random center
            Length = rnd.Next(3, 10);   // get random length between 3-9
            NumberOfEdges = rnd.Next(3, 11);  // Random edge count (3 to 10)
            Color = new ColorRGB(rnd);  // Random color
            Vertices = new List<Point2D>(); // Initialize vertex list
            CalculateEdgeCoordinates();  // Calculate initial vertices
        }
        public Polygon(Point2D center, int length, int numberOfEdges, ColorRGB color)   // Parameterized constructor – custom values
        {
            Center = center;
            Length = length;
            NumberOfEdges = numberOfEdges;
            Color = color;
            Vertices = new List<Point2D>();
            CalculateEdgeCoordinates();  // Calculate vertices
        }

        public void CalculateEdgeCoordinates() // Calculates the coordinates of each vertex
        {
            Vertices.Clear(); // Clear existing vertices
            double angleStep = 360.0 / NumberOfEdges; // Angle between each vertex


            for (int i = 0; i < NumberOfEdges; i++)
            {
                double angle = angleStep * i;
                double radian = angle * (Math.PI / 180);  // Convert angle to radians

                int x = (int)(Center.X + Length * Math.Cos(radian));  // X coordinate
                int y = (int)(Center.Y + Length * Math.Sin(radian));  // Y coordinate

                Vertices.Add(new Point2D(x, y));  // Add vertex to list
            }
        }
        public void RotatePolygon(int angle, bool counterClockwise = false)  // Rotates the polygon around its center
        {
            double angleInRadians = angle * (Math.PI / 180);  // Convert to radians
            if (counterClockwise)
                angleInRadians = -angleInRadians; // Invert for counter-clockwise


            for (int i = 0; i < Vertices.Count; i++)
            { // Translate vertex to origin
                int x = (int)(Vertices[i].X - Center.X);
                int y = (int)(Vertices[i].Y - Center.Y);
                // Apply rotation matrix
                int rotatedX = (int)(x * Math.Cos(angleInRadians) - y * Math.Sin(angleInRadians) + Center.X);
                int rotatedY = (int)(x * Math.Sin(angleInRadians) + y * Math.Cos(angleInRadians) + Center.Y);

                Vertices[i] = new Point2D(rotatedX, rotatedY);   // Update rotated vertex
            }
        }
    }
}
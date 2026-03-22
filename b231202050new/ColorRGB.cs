//*********************************************************************************************************************************************
//*********************************************************************************************************************************************
//************                              STUDENT NAME:SUDENAZ KIZILÇAY                                        ******************************
//************                              STUDENT NUMBER:B231202050                                            ******************************
//*********************************************************************************************************************************************
//*********************************************************************************************************************************************

using System; // Basic .NET classes
using System.Collections.Generic; // For collection classes like List<T>
using System.Text;// For string-related classes (optional here)
using System.Drawing; // Graphical operations (color, drawing, etc.)
public class ColorRGB // A custom class to represent RGB color values
{
    public int Red { get; set; } // Red component (0–255)
    public int Green { get; set; }// Green component (0–255)
    public int Blue { get; set; } // Blue component (0–255)

    public ColorRGB() // Default constructor, sets color to black (0,0,0)
    {
        Red = 0;
        Green = 0;
        Blue = 0;
    }

    public ColorRGB(int r, int g, int b)  // Constructor with specific RGB values
    {
        Red = r;
        Green = g;
        Blue = b;
    }

    public ColorRGB(Random rnd) // Constructor that generates a random RGB color
    {
        Red = rnd.Next(0, 256);    // Random value between 0 and 255
        Green = rnd.Next(0, 256); //Random value between 0 and 255
        Blue = rnd.Next(0, 256); //Random value between 0 and 255
    }

    public string ToHex()  // Returns the color as a HEX string
    {
        return $"#{Red:X2}{Green:X2}{Blue:X2}"; // Converts each component to 2-digit hex
    }

    public Color ToColor() // Converts to System.Drawing.Color object
    {
        return Color.FromArgb(Red, Green, Blue); // Creates a Color from RGB values
    }

}
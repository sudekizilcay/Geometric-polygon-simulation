//*********************************************************************************************************************************************
//*********************************************************************************************************************************************
//************                              STUDENT NAME:SUDENAZ KIZILÇAY                                        ******************************
//************                              STUDENT NUMBER:B231202050                                            ******************************
//*********************************************************************************************************************************************
//*********************************************************************************************************************************************
using System; // Basic .NET classes
using System.Collections.Generic;  // For collection classes like List<T>
using System.Linq; // For LINQ queries (Language Integrated Query), useful for working with collections in a functional style
using System.Threading.Tasks; // For working with asynchronous programming, Tasks, async/await keywords
using System.Windows.Forms;  // For forms and controls

namespace b231202050new
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); // Enables visual styles for the application (modern look for controls)
            Application.SetCompatibleTextRenderingDefault(false); // Sets text rendering to use GDI+ instead of GDI for better compatibility
            Application.Run(new Form1()); // Starts the application with Form1 as the main form
        }
    }
}

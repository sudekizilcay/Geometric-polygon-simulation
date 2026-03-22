//*********************************************************************************************************************************************
//*********************************************************************************************************************************************
//************                              STUDENT NAME:SUDENAZ KIZILÇAY                                        ******************************
//************                              STUDENT NUMBER:B231202050                                            ******************************
//*********************************************************************************************************************************************
//*********************************************************************************************************************************************

using System; // Basic .NET classes
using System.Collections.Generic; // For collection classes like List<T>
using System.Drawing; // Graphical operations (color, drawing, etc.)
using System.Reflection;
using System.Windows.Forms; // For forms and controls
using b231202050new; //Project that spesifically defined

namespace b231202050new
{
    public partial class Form1 : Form
    {

        private double TotalRotationAngleDeg = 0; //Variable that holds the total rotation angle
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;// When the Form is load,then Form1 will be work
            this.Paint += new PaintEventHandler(Form1_Paint);// When the form is drawn, the Paint event will be triggered

            txtCenterX.Text = "0";  // Default value
            txtCenterY.Text = "0"; // Default value
            txtLength.Text = "4";  // Default value
            txtEdge.Text = "5";   // Default value
            txtAngle.Text = "30"; // Default value

            // Assigning default values (0, 0, 0)
            trackRed.Value = 0;     // Default value
            trackGreen.Value = 0;  // Default value
            trackBlue.Value = 0;  // Default value

            chkCounterClockwise.Checked = false; // Initially rotate clockwise (CounterClockwise=False)
            PictureBox1.Invalidate(); //For the first draw Polygon we are refreshing the area
        }

        private void DrawPolygon(Graphics gObj, bool rotate) // Function that draws polygons
        {
            // Checking the parameters we get from the user are correct 
            if (!int.TryParse(txtCenterX.Text, out int centerX) ||
                !int.TryParse(txtCenterY.Text, out int centerY) ||
                !int.TryParse(txtLength.Text, out int length) ||
                !int.TryParse(txtEdge.Text, out int edgeCount))
            {
                MessageBox.Show("Please enter valid numeric values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); //warning
                return;
            }

            if (edgeCount < 3 || edgeCount > 10) // It makes sure that the number of sides is valid
            {
                MessageBox.Show("The number of sides must be between 3 and 10.");
                return;
            }

            if (rotate) // Get the angle if rotation is to be done
            {
                if (!int.TryParse(txtAngle.Text, out int rotationAngle))
                {
                    MessageBox.Show("Please enter a valid rotation angle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (chkCounterClockwise.Checked) // Counterclockwise rotation status (True/False)
                    rotationAngle = -rotationAngle;

                TotalRotationAngleDeg += rotationAngle;// Update rotation angle
            }

            double angleRad = TotalRotationAngleDeg * Math.PI / 180; //Convert from degrees to radians

            ColorRGB polygonColor = new ColorRGB(trackRed.Value, trackGreen.Value, trackBlue.Value); //Color selection
            Pen pen = new Pen(polygonColor.ToColor(), 2); //Drawing tool


            // Calculating the corner points of a polygon
            List<PointF> vertices = new List<PointF>();
            double angleStep = 2 * Math.PI / edgeCount;

            for (int i = 0; i < edgeCount; i++)
            {
                double angle = (i * angleStep) - angleRad;
                float originX = PictureBox1.Width / 2f; // Center of the screen
                float originY = PictureBox1.Height / 2f;// Center of the screen

                float scaleFactor = 5.5f; // I used this to make my graphic bigger
                float x = originX + centerX + (float)((length * scaleFactor / Math.Sin(Math.PI / edgeCount)) * Math.Cos(angle));
                float y = originY + centerY + (float)((length * scaleFactor / Math.Sin(Math.PI / edgeCount)) * Math.Sin(angle));
                vertices.Add(new PointF(x, y)); // Add the vertex to the list
            }

            gObj.Clear(Color.White); // Cleans the screen with white background

            for (int i = 0; i < vertices.Count; i++) //Draw the polygon
            {
                PointF p1 = vertices[i];
                PointF p2 = vertices[(i + 1) % vertices.Count];// Draw the space between the last corner and the first corner
                gObj.DrawLine(pen, p1, p2); //Draw line
            }
            // Show coordinates in list
            lstEdgeCoordinates.Items.Clear();
            for (int i = 0; i < vertices.Count; i++)
            {
                double angle = i * angleStep + angleRad;
                double x = centerX + length * Math.Cos(angle);
                double y = centerY + length * Math.Sin(angle);

                lstEdgeCoordinates.Items.Add($"V{i + 1} = ({x:F2}, {y:F2})");

            }


            ColorRGB PolygonColor = new ColorRGB(trackRed.Value, trackGreen.Value, trackBlue.Value); // Create a color for the polygon using RGB values from track bars (sliders)
            Point2D center = new Point2D(centerX, centerY);// Define the center point of the polygon using the provided X and Y coordinates

            Polygon poly = new Polygon(center, length, edgeCount, polygonColor);// Create a polygon object with the center point, length, number of edges, and color
            // Loop through each vertex of the polygon (e.g., to process or draw them)
            foreach (var vertex in poly.Vertices)
            {

            }

        }
        private void BtnRotate_Click(object sender, EventArgs e) //When the Rotate button is clicked
        {
            PictureBox1.Invalidate(); //Refresh drawing
            TotalRotationAngleDeg += int.Parse(txtAngle.Text); // Increase total route by angle
        }

        private void BtnDraw_Click(object sender, EventArgs e)  //When the  Draw button is clicked
        {
            TotalRotationAngleDeg = 0; // Reset to initial route
            PictureBox1.Invalidate();  // Refresh drawing
        }
        private void BtnReset_Click(object sender, EventArgs e) //When the Reset button is clicked
        {

            TotalRotationAngleDeg = 0; // Reset to initial route
            Random rnd = new Random();

            txtCenterX.Text = rnd.Next(0, 4).ToString(); // between 0-3 random X
            txtCenterY.Text = rnd.Next(0, 4).ToString(); // between 0-3 random Y

            txtLength.Text = rnd.Next(3, 10).ToString(); // between 3-9 random Length
            txtEdge.Text = rnd.Next(3, 11).ToString(); //between 3-10 random Edge number
            txtAngle.Text = rnd.Next(0, 360).ToString(); //between 0-359 random Angle

            ColorRGB randomColor = new ColorRGB(rnd); //Random colors
            trackRed.Value = randomColor.Red; //Random Red
            trackGreen.Value = randomColor.Green; //Random Green
            trackBlue.Value = randomColor.Blue; //Random BLue

            chkCounterClockwise.Checked = false; // Reset the counterclockwise rotation box

            PictureBox1.Refresh(); // Tüm alanı yeniden çizmek için
            PictureBox1.Invalidate(); //Refresh

        }
        private void Form1_Load(object sender, EventArgs e) // Set parameters and start drawing immediately when the form loads
        {
            txtCenterX.Text = "0"; // Default value
            txtCenterY.Text = "0"; // Default value
            txtLength.Text = "4"; // Default value
            txtEdge.Text = "5";   // Default value
            txtAngle.Text = "30"; // Default value

            trackRed.Value = 0; // Default value
            trackGreen.Value = 0; // Default value
            trackBlue.Value = 0; // Default value

            chkCounterClockwise.Checked = false;  // Reset the counterclockwise rotation box

            PictureBox1.Paint += PictureBox1_Paint; // Trigger the paint event
            PictureBox1.Invalidate(); //Refresh

        }

        private void Form1_Paint(object sender, PaintEventArgs e) // When the form is drawn
        {
            PictureBox1.Invalidate(); //Refresh
        }
        private void PictureBox1_Paint(object sender, PaintEventArgs e) // Drawing on PictureBox
        {
            DrawPolygon(e.Graphics, false); ; // It starts the drawing process
        }

    }
}
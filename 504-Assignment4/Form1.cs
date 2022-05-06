//***************************************************************************
//
//  Troy DeClerck       - Z1877438
//  Brandon Anzalone    - Z1884778
//  CSCI 473/504        Assignment 4
//
//  We certify that this is our own work and where appropriate an extension
//  of the starter code provided for the assignment
//***************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.Remoting.Channels;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        private static Pen WhitePen;
        private static Pen SelectedPen;
        private static int xMax = 10;
        private static int xMin = -10;
        private static int yMax = 10;
        private static int yMin = -10;

        // Tick Variables
        private static int xTick = 1;
        private static int yTick = 1;

        // Regex checks
        Regex regex = new Regex(@"^-?[0-9]\d*(\.\d+)?$");

        public Form1()
        {
            InitializeComponent();

            WhitePen = new Pen(Color.White);
            SelectedPen = new Pen(Color.White);

            string[] colors = { "White", "Red", "Green", "Blue" };
            LinearColor.DataSource = colors;
            CircleColor.DataSource = colors;
            QuadraticColor.DataSource = colors;
            cubicColor.DataSource = colors;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LinearColor.SelectedIndex = 0;
            CircleColor.SelectedIndex = 0;
            QuadraticColor.SelectedIndex = 0;
            cubicColor.SelectedIndex = 0;

            ToolTipMessage();
        }

        /**
         * Empties text box once user clicks on text box
         * 
         * @param sender The reference to the object that contains the event data 
         * 
         * @param e The parameter which contains the event data
         ****************************************************************************/
        private void Text_Enter(object sender, EventArgs e)
        {
            if (LinearM.Text == "m")
            {
                LinearM.ForeColor = Color.Black;
                LinearM.Text = "";
            }

            if (LinearB.Text == "b")
            {
                LinearB.ForeColor = Color.Black;
                LinearB.Text = "";
            }

            if (CircleH.Text == "h")
            {
                CircleH.ForeColor = Color.Black;
                CircleH.Text = "";
            }

            if (CircleK.Text == "k")
            {
                CircleK.ForeColor = Color.Black;
                CircleK.Text = "";
            }

            if (CircleR.Text == "r")
            {
                CircleR.ForeColor = Color.Black;
                CircleR.Text = "";
            }

            if (quadA.Text == "a")
            {
                quadA.ForeColor = Color.Black;
                quadA.Text = "";
            }

            if (quadB.Text == "b")
            {
                quadB.ForeColor = Color.Black;
                quadB.Text = "";
            }

            if (quadC.Text == "c")
            {
                quadC.ForeColor = Color.Black;
                quadC.Text = "";
            }

            if (cubicA.Text == "a")
            {
                cubicA.ForeColor = Color.Black;
                cubicA.Text = "";
            }

            if (cubicB.Text == "b")
            {
                cubicB.ForeColor = Color.Black;
                cubicB.Text = "";
            }

            if (cubicC.Text == "c")
            {
                cubicC.ForeColor = Color.Black;
                cubicC.Text = "";
            }
            if (cubicD.Text == "d")
            {
                cubicD.ForeColor = Color.Black;
                cubicD.Text = "";
            }
        }

        /**
        * Changes text boxes back to variable names once a user leaves the box.
        * 
        * @param sender The reference to the object that contains the event data 
        * 
        * @param e The parameter which contains the event data
        ****************************************************************************/
        private void Text_Leave(object sender, EventArgs e)
        {
            if (LinearM.Text.Length == 0)
            {
                LinearM.ForeColor = Color.Gray;
                LinearM.Text = "m";
            }

            if (LinearB.Text.Length == 0)
            {
                LinearB.ForeColor = Color.Gray;
                LinearB.Text = "b";
            }

            if (CircleH.Text.Length == 0)
            {
                CircleH.ForeColor = Color.Gray;
                CircleH.Text = "h";
            }

            if (CircleK.Text.Length == 0)
            {
                CircleK.ForeColor = Color.Gray;
                CircleK.Text = "k";
            }

            if (CircleR.Text.Length == 0)
            {
                CircleR.ForeColor = Color.Gray;
                CircleR.Text = "r";
            }

            if (quadA.Text.Length == 0)
            {
                quadA.ForeColor = Color.Gray;
                quadA.Text = "a";
            }

            if (quadB.Text.Length == 0)
            {
                quadB.ForeColor = Color.Gray;
                quadB.Text = "b";
            }

            if (quadC.Text.Length == 0)
            {
                quadC.ForeColor = Color.Gray;
                quadC.Text = "c";
            }
            if (cubicA.Text.Length == 0)
            {
                cubicA.ForeColor = Color.Gray;
                cubicA.Text = "a";
            }

            if (cubicB.Text.Length == 0)
            {
                cubicB.ForeColor = Color.Gray;
                cubicB.Text = "b";
            }

            if (cubicC.Text.Length == 0)
            {
                cubicC.ForeColor = Color.Gray;
                cubicC.Text = "c";
            }

            if (cubicD.Text.Length == 0)
            {
                cubicD.ForeColor = Color.Gray;
                cubicD.Text = "d";
            }

        }

        /**
        * Draws the default hash marks on the graphing box we will be using
        * 
        * draws lines to scale as well as every % of the graphed lines, draws a 
        * tick to simulate a realistic graphing calculator look.
        * 
        * @param sender The reference to the object that contains the event data 
        * 
        * @param e The parameter which contains the event data
        ****************************************************************************/
        private void DrawAxes(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Horizontal Axis
            g.DrawLine(WhitePen, 0, (float)yMax * (600 / ((float)yMax - (float)yMin)), Graph.Width, (float)yMax * (600 / ((float)yMax - (float)yMin)));
            //Vertical Axis
            g.DrawLine(WhitePen, (float)Math.Abs(xMin) * (600 / ((float)xMax - (float)xMin)), 0, (float)Math.Abs(xMin) * (600 / ((float)xMax - (float)xMin)), Graph.Height);

            // Set ticks
            xTick = Convert.ToInt32(xInterval.Value);
            int counter = xTick;

            for (int i = 0; i < xMax; i++)
            {
                Point[] PosTicks =
                {
                    new Point((counter + Math.Abs(xMin)) * (600 / (xMax - xMin)), yMax * (600 / (yMax - yMin)) - 10),
                    new Point((counter + Math.Abs(xMin)) * (600 / (xMax - xMin)), yMax * (600 / (yMax - yMin)) + 10),
                };

                g.DrawLines(WhitePen, PosTicks);

                counter += xTick;

            }

            counter = xTick;
            for (int i = 0; i < Math.Abs(xMin); i++)
            {
                Point[] NegTicks =
                {
                    new Point((-counter + Math.Abs(xMin)) * (600 / (xMax - xMin)), yMax * (600 / (yMax - yMin)) - 10),
                    new Point((-counter + Math.Abs(xMin)) * (600 / (xMax - xMin)), yMax * (600 / (yMax - yMin)) + 10),
                };

                g.DrawLines(WhitePen, NegTicks);

                counter += xTick;
            }

            yTick = Convert.ToInt32(yInterval.Value);
            counter = yTick;

            for (int i = 0; i < yMax; i++)
            {
                Point[] PosTicks =
                {

                    new Point(Math.Abs(xMin) * (600 / (xMax - xMin)) - 10, (-counter + yMax) * (600 / (yMax - yMin))),
                    new Point(Math.Abs(xMin) * (600 / (xMax - xMin)) + 10, (-counter + yMax) * (600 / (yMax - yMin))),
                };

                g.DrawLines(WhitePen, PosTicks);

                counter += yTick;


            }

            counter = yTick;
            for (int i = 0; i < Math.Abs(yMin); i++)
            {
                Point[] NegTicks =
                {
                    new Point(Math.Abs(xMin) * (600 / (xMax - xMin)) - 10, (counter + yMax) * (600 / (yMax - yMin))),
                    new Point(Math.Abs(xMin) * (600 / (xMax - xMin)) + 10, (counter + yMax) * (600 / (yMax - yMin))),
                };

                g.DrawLines(WhitePen, NegTicks);

                counter += yTick;
            }

        }

        /**
        * sets the boundaries of the graphing area
        * 
        * @param sender The reference to the object that contains the event data 
        * 
        * @param e The parameter which contains the event data
        ****************************************************************************/
        private void Set_Bounds(object sender, EventArgs e)
        {
            ToolTipMessage();

            Graphics g = Graph.CreateGraphics();

            xMin = Convert.ToInt32(xMinRange.Value);
            xMax = Convert.ToInt32(xMaxRange.Value);
            yMin = Convert.ToInt32(yMinRange.Value);
            yMax = Convert.ToInt32(yMaxRange.Value);

            SolidBrush Black = new SolidBrush(Color.Black);
            g.FillRectangle(Black, 0, 0, Graph.Width, Graph.Height);

            //Horizontal Axis
            g.DrawLine(WhitePen, 0, (float)yMax * (600 / ((float)yMax - (float)yMin)), Graph.Width, (float)yMax * (600 / ((float)yMax - (float)yMin)));
            //Vertical Axis
            g.DrawLine(WhitePen, (float)Math.Abs(xMin) * (600 / ((float)xMax - (float)xMin)), 0, (float)Math.Abs(xMin) * (600 / ((float)xMax - (float)xMin)), Graph.Height);

            // Set ticks
            xTick = Convert.ToInt32(xInterval.Value);
            int counter = xTick;

            for (int i = 0; i < xMax; i++)
            {
                Point[] PosTicks =
                {
                    new Point((counter + Math.Abs(xMin)) * (600 / (xMax - xMin)), yMax * (600 / (yMax - yMin)) - 10),
                    new Point((counter + Math.Abs(xMin)) * (600 / (xMax - xMin)), yMax * (600 / (yMax - yMin)) + 10),
                };

                g.DrawLines(WhitePen, PosTicks);

                counter += xTick;

            }

            counter = xTick;
            for (int i = 0; i < Math.Abs(xMin); i++)
            {
                Point[] NegTicks =
                {
                    new Point((-counter + Math.Abs(xMin)) * (600 / (xMax - xMin)), yMax * (600 / (yMax - yMin)) - 10),
                    new Point((-counter + Math.Abs(xMin)) * (600 / (xMax - xMin)), yMax * (600 / (yMax - yMin)) + 10),
                };

                g.DrawLines(WhitePen, NegTicks);

                counter += xTick;
            }



            yTick = Convert.ToInt32(yInterval.Value);
            counter = yTick;

            for (int i = 0; i < yMax; i++)
            {
                Point[] PosTicks =
                {

                    new Point(Math.Abs(xMin) * (600 / (xMax - xMin)) - 10, (-counter + yMax) * (600 / (yMax - yMin))),
                    new Point(Math.Abs(xMin) * (600 / (xMax - xMin)) + 10, (-counter + yMax) * (600 / (yMax - yMin))),
                };

                g.DrawLines(WhitePen, PosTicks);

                counter += yTick;


            }


            counter = yTick;
            for (int i = 0; i < Math.Abs(yMin); i++)
            {
                Point[] NegTicks =
                {
                    new Point(Math.Abs(xMin) * (600 / (xMax - xMin)) - 10, (counter + yMax) * (600 / (yMax - yMin))),
                    new Point(Math.Abs(xMin) * (600 / (xMax - xMin)) + 10, (counter + yMax) * (600 / (yMax - yMin))),
                };

                g.DrawLines(WhitePen, NegTicks);

                counter += yTick;
            }

        }

        // Check to see if Max is greater than Min
        private void xMinCheck(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(xMinRange.Value);
            int max = Convert.ToInt32(xMaxRange.Value);

            if (min > max)
            {
                xMaxRange.Value = xMinRange.Value + 1;
            }
        }

        // Check to see if Max is greater than Min
        private void xMaxCheck(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(xMinRange.Value);
            int max = Convert.ToInt32(xMaxRange.Value);

            if (max < min)
            {
                xMinRange.Value = xMaxRange.Value - 1;
            }
        }

        // Check to see if Max is greater than Min
        private void yMinCheck(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(yMinRange.Value);
            int max = Convert.ToInt32(yMaxRange.Value);

            if (min > max)
            {
                yMaxRange.Value = yMinRange.Value + 1;
            }
        }

        // Check to see if Max is greater than Min
        private void yMaxCheck(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(yMinRange.Value);
            int max = Convert.ToInt32(yMaxRange.Value);

            if (min > max)
            {
                yMinRange.Value = yMaxRange.Value - 1;
            }
        }

        // Converts points to match the form field
        private float Convert_X(float x)
        {
            float min = (float)xMin;
            float max = (float)xMax;

            if (xMin < 0)
            {
                return ((x + Math.Abs(min)) * (600 / (max - min)));
            }
            else
            {
                return (x * (600 / (max - min)));
            }

        }

        // Converts points to match the form field
        private float Convert_Y(float y)
        {
            float min = (float)yMin;
            float max = (float)yMax;

            return (Math.Abs(y - max) * (600 / (max - min)));
        }


        /**
        * Draws a linear Line across the entire graphing area with the supplied y = mx + b formula
        * 
        * Takes the inputed numbers from the user and conducts the math formula to get the 2 points
        * neccesary to graph a straight line, then sends them to draw line. 
        * 
        * @param sender The reference to the object that contains the event data 
        * 
        * @param e The parameter which contains the event data
        ****************************************************************************/
        private void LinearGraph(object sender, EventArgs e)
        {
            ToolTipMessage();

            if (regex.IsMatch(LinearM.Text) && regex.IsMatch(LinearB.Text))
            {

                Graphics g = Graph.CreateGraphics();

                // Pen Color
                if ((string)LinearColor.SelectedValue == "White")
                {
                    SelectedPen = new Pen(Color.White);
                }
                else if ((string)LinearColor.SelectedValue == "Red")
                {
                    SelectedPen = new Pen(Color.Red);
                }
                else if ((string)LinearColor.SelectedValue == "Green")
                {
                    SelectedPen = new Pen(Color.Green);
                }
                else if ((string)LinearColor.SelectedValue == "Blue")
                {
                    SelectedPen = new Pen(Color.Blue);
                }

                // Initalize all necessary points in graph
                float m = float.Parse(LinearM.Text);
                float b = float.Parse(LinearB.Text);
                float y = (float)yMax;
                float x1;
                float x2;
                float y1;
                float y2;

                // Check if slope will be zero
                if (m != 0)
                {
                    y1 = y;
                    x1 = (y - b) / m;

                    if (x1 < (float)xMin)
                    {
                        x1 = (float)xMin;
                        y1 = (m * x1) + b;
                    }

                    x1 = Convert_X(x1);
                    y1 = Convert_Y(y1);

                    // Find the second point
                    y = (float)yMin;

                    y2 = y;
                    x2 = (y - b) / m;

                    if (x2 > (float)xMax)
                    {
                        x2 = (float)xMax;
                        y2 = (m * x2) + b;
                    }

                    x2 = Convert_X(x2);
                    y2 = Convert_Y(y2);
                }
                else
                {
                    x1 = 0;
                    y1 = b;
                    x2 = Graph.Width;
                    y2 = b;

                    y1 = Convert_Y(y1);
                    y2 = Convert_Y(y2);
                }

                if (Math.Abs(x1) > 600 || Math.Abs(x2) > 600 || Math.Abs(y1) > 600 || Math.Abs(y2) > 600) OutOfScope();
                else
                {
                    // Draw the line from each point
                    g.DrawLine(SelectedPen, x1, y1, x2, y2);
                }


            }

        }
        /**
        * Draws a Circle with the provided user information in the form of ( (x - h)2 + (y - k)2 = r2 )
        * 
        * Takes the inputed numbers from the user and conducts the math formula to get the neccesary
        * points in order to graph a circle and muliplies them by the scale of the graphing box
        * in order to get them into the correct region.
        * 
        * @param sender The reference to the object that contains the event data 
        * 
        * @param e The parameter which contains the event data
        ****************************************************************************/
        private void CircleGraph(object sender, EventArgs e)
        {
            ToolTipMessage();

            if (regex.IsMatch(CircleH.Text) && regex.IsMatch(CircleK.Text) && regex.IsMatch(CircleR.Text))
            {
                Graphics g = Graph.CreateGraphics();

                // Pen Color
                if ((string)CircleColor.SelectedValue == "White")
                {
                    SelectedPen = new Pen(Color.White);
                }
                else if ((string)CircleColor.SelectedValue == "Red")
                {
                    SelectedPen = new Pen(Color.Red);
                }
                else if ((string)CircleColor.SelectedValue == "Green")
                {
                    SelectedPen = new Pen(Color.Green);
                }
                else if ((string)CircleColor.SelectedValue == "Blue")
                {
                    SelectedPen = new Pen(Color.Blue);
                }

                float xMinR = Math.Abs(Convert.ToSingle(xMinRange.Value)); // Get min x range and scale it to graph
                float xMaxR = Math.Abs(Convert.ToSingle(xMaxRange.Value)); // Get max x range and scale it to graph

                float yMinR = Math.Abs(Convert.ToSingle(yMinRange.Value)); // Get min y range and scale it to graph
                float yMaxR = Math.Abs(Convert.ToSingle(yMaxRange.Value)); // Get max y range and scale it o graph

                float scaleModX = (xMinR + xMaxR) / 2;
                float scaleModY = (yMinR + yMaxR) / 2;
                float scaleX = Graph.Height / (xMaxR + xMinR);
                float scaleY = Graph.Height / (yMaxR + yMinR);

                float h = Convert.ToSingle(CircleH.Text) * scaleX;
                float k = Convert.ToSingle(CircleK.Text) * scaleY;


                double temp = Convert.ToSingle(CircleR.Text);
                float r = (float)Math.Sqrt(temp) * scaleX; // Scale the radius


                if ((h + (scaleModX * scaleX) - r) > 600 || (h + (scaleModX * scaleX) - r) < 0 ||
                    ((scaleY * scaleModY) - k - r) > 600 || ((scaleY * scaleModY) - k - r) < 0) OutOfScope();
                else
                {
                    // Draw "Ellipse"
                    g.DrawEllipse(SelectedPen, h + (scaleModX * scaleX) - r, (scaleY * scaleModY) - k - r, r * 2, r * 2);
                }

            }
        }

        // Click to view coordinates on mouse click
        private void GraphClick(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;

            // Set coordinates to proper format
            float x = (coordinates.X / (600 / ((float)xMaxRange.Value - (float)xMinRange.Value))) - Math.Abs((float)xMinRange.Value);
            float y = -((coordinates.Y / (600 / ((float)yMaxRange.Value - (float)yMinRange.Value))) - (float)yMaxRange.Value);

            MessageBox.Show("(" + x + "," + y + ")");
        }

        /**
        * Draws a quadratic line with the provided user information in the form of (y = ax2 + bx + c)
        * 
        * Takes the inputed numbers from the user and conducts the math formula to get the neccesary
        * points in order to graph a curved line, inputs scaled x's into the formula in the line of the curve
        * in order to get many points that a placed into an array then sent to the drawCurve function.
        * 
        * @param sender The reference to the object that contains the event data 
        * 
        * @param e The parameter which contains the event data
        ****************************************************************************/
        private void QuadraticBtn_Click(object sender, EventArgs e)
        {
            ToolTipMessage();

            if (regex.IsMatch(quadA.Text) && regex.IsMatch(quadB.Text) && regex.IsMatch(quadC.Text))
            {
                Graphics g = Graph.CreateGraphics();

                // Pen Color
                if ((string)QuadraticColor.SelectedValue == "White")
                {
                    SelectedPen = new Pen(Color.White);
                }
                else if ((string)QuadraticColor.SelectedValue == "Red")
                {
                    SelectedPen = new Pen(Color.Red);
                }
                else if ((string)QuadraticColor.SelectedValue == "Green")
                {
                    SelectedPen = new Pen(Color.Green);
                }
                else if ((string)QuadraticColor.SelectedValue == "Blue")
                {
                    SelectedPen = new Pen(Color.Blue);
                }

                List<PointF> PointList = new List<PointF>();
                float xMinR = Convert.ToSingle(xMinRange.Value); // Get min x range and scale it to graph
                float xMaxR = Convert.ToSingle(xMaxRange.Value); // Get max x range and scale it to graph
                float xMinPOS = Math.Abs(xMinR); // Get positive value of min range
                float xMaxPOS = Math.Abs(xMaxR); // Get positive value of max range

                float scale = Graph.Height / (xMaxPOS + xMinPOS);
                float a = Convert.ToSingle(quadA.Text) * scale;
                float b = Convert.ToSingle(quadB.Text) * scale;
                float c = Convert.ToSingle(quadC.Text) * scale;


                // Loop through x min and max range
                for (float x = xMinR; x < xMaxR; x++)
                {
                    float y = (a * (x * x) + (b * x + c));
                    PointList.Add(new PointF((scale * xMinPOS) + x * scale, (scale * xMaxPOS) - y));
                }

                // Convert list to array for drawing curve
                PointF[] PointArray = PointList.ToArray();

                // Find the vertex and determine if it is within the scope of the graph
                float xMax = 0;
                float yMax = 0;
                float yMin = 600;
                float xMin = 600;

                // Loop through the points to find the max (if positive) or min (if negative)
                foreach (PointF p in PointArray)
                {
                    if (p.Y > yMax && a > 0)
                    {
                        yMax = p.Y;
                        xMax = p.X;
                    }

                    if (p.Y < yMin && a < 0)
                    {
                        yMin = p.Y;
                        xMin = p.X;
                    }
                }

                // Draw the graph if within bounds
                if (xMax > 0 && xMax < 600 && yMax > 0 && yMax < 600)
                    g.DrawCurve(SelectedPen, PointArray);
                else if (xMin > 0 && xMin < 600 && yMin > 0 && yMin < 600)
                    g.DrawCurve(SelectedPen, PointArray);
                else OutOfScope();

            }
        }
        /**
        * Draws a Cubic line with the provided user information in the form of (y = ax3 + bx2 + cx + d)
        * 
        * Takes the inputed numbers from the user and conducts the math formula to get the neccesary
        * points in order to graph a curved line, inputs scaled x's into the formula in the line of the curve
        * in order to get many points that a placed into an array then sent to the drawCurve function.
        * 
        * @param sender The reference to the object that contains the event data 
        * 
        * @param e The parameter which contains the event data
        ****************************************************************************/
        private void cubicBtn_Click_Click(object sender, EventArgs e)
        {
            ToolTipMessage();

            if (regex.IsMatch(cubicA.Text) && regex.IsMatch(cubicB.Text) && regex.IsMatch(cubicC.Text) && regex.IsMatch(cubicD.Text))
            {
                Graphics g = Graph.CreateGraphics();

                // Pen Color
                if ((string)QuadraticColor.SelectedValue == "White")
                {
                    SelectedPen = new Pen(Color.White);
                }
                else if ((string)QuadraticColor.SelectedValue == "Red")
                {
                    SelectedPen = new Pen(Color.Red);
                }
                else if ((string)QuadraticColor.SelectedValue == "Green")
                {
                    SelectedPen = new Pen(Color.Green);
                }
                else if ((string)QuadraticColor.SelectedValue == "Blue")
                {
                    SelectedPen = new Pen(Color.Blue);
                }

                List<PointF> PointList = new List<PointF>();
                float xMinR = Convert.ToSingle(xMinRange.Value); // Get min x range and scale it to graph
                float xMaxR = Convert.ToSingle(xMaxRange.Value); // Get max x range and scale it to graph
                float xMinPOS = Math.Abs(xMinR); // Get positive value of min range
                float xMaxPOS = Math.Abs(xMaxR); // Get positive value of max range

                float yMinR = Convert.ToSingle(yMinRange.Value); // Get min y range and scale it to graph
                float yMaxR = Convert.ToSingle(yMaxRange.Value); // Get max y range and scale it to graph
                float yMinPOS = Math.Abs(yMinR); // Get positive value of min range
                float yMaxPOS = Math.Abs(yMaxR); // Get positive value of max range

                float scaleX = (xMinPOS + xMaxPOS) / 2;

                float scale = Graph.Height / (xMaxPOS + xMinPOS);
                float a = Convert.ToSingle(cubicA.Text) * scale;
                float b = Convert.ToSingle(cubicB.Text) * scale;
                float c = Convert.ToSingle(cubicC.Text) * scale;
                float d = Convert.ToSingle(cubicD.Text) * scale;

                for (float x = xMinR; x < xMaxR; x++)
                {
                    float y = (a * (x * x * x) + (b * (x * x)) + (c * x) + d);
                    PointList.Add(new PointF((scale * scaleX) + x * scale, (scale * xMaxPOS) - y));

                }

                // Convert list to array for drawing curve
                PointF[] PointArray = PointList.ToArray();

                // Testing to see if cubic graph is in scope
                bool InRange = false;
                foreach (PointF p in PointArray)
                {
                    if (p.Y <= 600 && p.Y >= 0) InRange = true;
                }

                if (InRange) g.DrawCurve(SelectedPen, PointArray);
                else OutOfScope();

            }
        }

        // Function to call initial tool tip
        private void ToolTipMessage()
        {
            InfoTextBox.Clear();

            InfoTextBox.Text += "Hover over any text fields for a definition of the variable provided. 'Set Graph' also resets the graph.";
        }

        // Function to call out of scope message
        private void OutOfScope()
        {
            InfoTextBox.Clear();

            InfoTextBox.Text += "The given equation is out of scope!";
        }

    }
}
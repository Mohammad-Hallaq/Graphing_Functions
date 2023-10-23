using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CColor = System.Drawing.Color; // we used an extra library to help us with the colors

namespace MINI_PROJECT
{
    public partial class Form1 : Form
    {
        static float thick;              // a variable for the thickness
        Pen cpen = new Pen(Color.Black, 2); // a Pen variable for the coordinates lines
        float maxy, miny, maxx, minx;     // variables prsesnt the maximum and minimum values in the Y and X axis
        Pen pen = new Pen(Color.Red, thick);   // general Pan variable ... helps us with drawing 
        bool loadbtn_Clicked = false;      
        public bool draw_btn_Clicked = false;

       // public object Messagebox { get; private set; }

        static double[] x_val(double a, double b, int n)  // a function to get the values of X axis
        {
            double[] ar = new double[n + 1];
            double dx = (b - a) / n;
            for (int i = 0; i <= n; i++)
                ar[i] = a + i * dx;
            return ar;
        }
        static double[] Y_val(string function, double[] x)    // a function to get the values of Y axis
        {

            double[] ar = new double[x.Length];

            // the next part gives the values that match the function

            if (function == "sin")                                   
            {
                for (int i = 0; i <= x.Length - 1; i++)
                    ar[i] = Math.Sin(x[i]);
            }
            else if (function == "cos")
            {

                for (int i = 0; i <= x.Length - 1; i++)
                    ar[i] = Math.Cos(x[i]);

            }
            else if (function == "X^2")
            {

                for (int i = 0; i <= x.Length - 1; i++)
                    ar[i] = x[i] * x[i];

            }
            else if (function == "3X+5")
            {

                for (int i = 0; i <= x.Length - 1; i++)
                    ar[i] = 3 * x[i] + 5;

            }
            else if (function == "|X|")
            {

                for (int i = 0; i <= x.Length - 1; i++)
                    ar[i] = Math.Abs(x[i]);

            }
            else if (function == "tan")
            {

                for (int i = 0; i <= x.Length - 1; i++)
                    ar[i] = Math.Tan(x[i]);

            }
            else if (function == "ln")
            {

                for (int i = 0; i <= x.Length - 1; i++)
                    ar[i] = Math.Log(x[i]);
            }

            return ar;
        }

        static double MaxY(double[] x)               // a function to get the maximum value among the values Y axis
        {
            double max_val = x[0];
            for (int i = 1; i < x.Length - 1; i++)
            {
                if (x[i] > max_val)
                    max_val = x[i];
            }
            return max_val;
        }
        static double MinY(double[] x)                // a function to get the minimum value among the values Y axis
        {
            double min_val = x[0];
            for (int i = 1; i < x.Length - 1; i++)
            {
                if (x[i] < min_val)
                    min_val = x[i];
            }
            return min_val;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            draw_btn_Clicked = true;
            mypanel.Invalidate();


        }

        private void mypanel_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                
                 if (draw_btn_Clicked == true)
                {


                    // in these three lines we give the variables a,b and n the values of the maximum and minimum 
                    //valus in X axis and the number of points respectively
                    float a = float.Parse(X0_val.Text);    
                    float b = float.Parse(XN_val.Text);
                    int n = int.Parse(N_val.Text);

                    Graphics graphicsobject = e.Graphics;
                    thick = float.Parse(th.Text);           

                    if (func_list.Text == "sin")
                    {
                        Pen penth = new Pen(colorDialog1.Color, thick);
                        pen = penth;

                        double[] x_axis = x_val(a, b, n);
                        double[] y_axis = Y_val(func_list.Text, x_axis);

                        Y0_val.Text = MinY(y_axis).ToString();
                        YN_val.Text = MaxY(y_axis).ToString();

                        float f_a = float.Parse(Y0_val.Text);
                        float f_b = float.Parse(YN_val.Text);
                        maxy = f_b;
                        miny = f_a;
                        maxx = b;
                        minx = a;

                        title.Text = "  Sin";   //to show the title on the form 


                        for (float i = a; i < b; i = i + (b - a) / n)
                        {
                            // we used DrawLine method to draw our functions giving it the positins(coordinates) of two consecutive points 
                            //using the transformation formulas we found
                            graphicsobject.DrawLine                             
                                (pen, (i - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - (float)Math.Sin(i)),
                                ((i + (b - a) / n) - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - (float)Math.Sin(i + (b - a) / n)));

                        }
                    }
                    else if (func_list.Text == "cos")
                    {

                        Pen penth = new Pen(colorDialog1.Color, thick);
                        pen = penth;

                        double[] x_axis = x_val(a, b, n);
                        double[] y_axis = Y_val(func_list.Text, x_axis);

                        Y0_val.Text = MinY(y_axis).ToString();
                        YN_val.Text = MaxY(y_axis).ToString();

                        float f_a = float.Parse(Y0_val.Text);
                        float f_b = float.Parse(YN_val.Text);
                        maxy = f_b;
                        miny = f_a;
                        maxx = b;
                        minx = a;
                        title.Text = "  Cos";

                        for (float i = a; i < b; i = i + (b - a) / n)
                        {
                            graphicsobject.DrawLine
                                (pen, (i - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - (float)Math.Cos(i)),
                                ((i + (b - a) / n) - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - (float)Math.Cos(i + (b - a) / n)));

                        }
                    }
                    else if (func_list.Text == "X^2")
                    {

                        Pen penth = new Pen(colorDialog1.Color, thick);
                        pen = penth;

                        double[] x_axis = x_val(a, b, n);
                        double[] y_axis = Y_val(func_list.Text, x_axis);

                        Y0_val.Text = MinY(y_axis).ToString();
                        YN_val.Text = MaxY(y_axis).ToString();

                        float f_a = float.Parse(Y0_val.Text);
                        float f_b = float.Parse(YN_val.Text);
                        maxy = f_b;
                        miny = f_a;
                        maxx = b;
                        minx = a;
                        title.Text = "  X^2";

                        for (float i = a; i < b; i = i + (b - a) / n)
                        {
                            graphicsobject.DrawLine
                                (pen, (i - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - i * i),
                                ((i + (b - a) / n) - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - (i + (b - a) / n) * (i + (b - a) / n)));

                        }
                    }
                    else if (func_list.Text == "3X+5")
                    {
                        Pen penth = new Pen(colorDialog1.Color, thick);
                        pen = penth;

                        a = a * 1000;
                        b = b * 1000;

                        double[] x_axis = x_val(a, b, n);
                        double[] y_axis = Y_val(func_list.Text, x_axis);

                        Y0_val.Text = (3 * a / 1000 + 5).ToString();
                        YN_val.Text = (3 * b / 1000 + 5).ToString();

                        float f_a = (float)MinY(y_axis);
                        float f_b = (float)MaxY(y_axis);
                        maxy = f_b;
                        miny = f_a;
                        maxx = b / 1000;
                        minx = a / 1000;

                        title.Text = "  3x+5";


                        for (float i = a; i < b; i = i + (b - a) / n)
                        {
                            graphicsobject.DrawLine
                                (pen, (i - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - 3 * i + 5),
                                ((i + (b - a) / n) - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - (3 * (i + (b - a) / n) + 5)));

                        }
                    }
                    else if (func_list.Text == "|X|")
                    {
                        Pen penth = new Pen(colorDialog1.Color, thick);
                        pen = penth;

                        double[] x_axis = x_val(a, b, n);
                        double[] y_axis = Y_val(func_list.Text, x_axis);

                        Y0_val.Text = MinY(y_axis).ToString();
                        YN_val.Text = MaxY(y_axis).ToString();

                        float f_a = float.Parse(Y0_val.Text);
                        float f_b = float.Parse(YN_val.Text);
                        maxy = f_b;
                        miny = f_a;
                        maxx = b;
                        minx = a;
                        title.Text = "  |X|";
                        for (float i = a; i < b; i = i + (b - a) / n)
                        {
                            graphicsobject.DrawLine
                                (pen, (i - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - Math.Abs(i)),
                                ((i + (b - a) / n) - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - (Math.Abs(i + (b - a) / n))));

                        }
                    }
                    else if (func_list.Text == "tan")
                    {
                        Pen penth = new Pen(colorDialog1.Color, thick);
                        pen = penth;

                        double[] x_axis = x_val(a, b, n);
                        double[] y_axis = Y_val(func_list.Text, x_axis);

                        Y0_val.Text = MinY(y_axis).ToString();
                        YN_val.Text = MaxY(y_axis).ToString();

                        float f_a = float.Parse(Y0_val.Text);
                        float f_b = float.Parse(YN_val.Text);
                        maxy = f_b;
                        miny = f_a;
                        maxx = b;
                        minx = a;
                        title.Text = "  Tan";

                        for (float i = a; i < b; i = i + (b - a) / n)
                        {
                            graphicsobject.DrawLine
                                (pen, (i - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - (float)Math.Tan(i)),
                                ((i + (b - a) / n) - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - (float)Math.Tan(i + (b - a) / n)));

                        }

                    }
                    else if (func_list.Text == "ln")
                    {
                        Pen penth = new Pen(colorDialog1.Color, thick);
                        pen = penth;

                        double[] x_axis = x_val(a, b, n);
                        double[] y_axis = Y_val(func_list.Text, x_axis);

                        Y0_val.Text = MinY(y_axis).ToString();
                        YN_val.Text = MaxY(y_axis).ToString();

                        float f_a = float.Parse(Y0_val.Text);
                        float f_b = float.Parse(YN_val.Text);
                        maxy = f_b;
                        miny = f_a;
                        maxx = b;
                        minx = a;
                        title.Text = "  Ln";

                        for (float i = a; i < b; i = i + (b - a) / n)
                        {
                            graphicsobject.DrawLine
                                (pen, (i - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - (float)Math.Log(i)),
                                ((i + (b - a) / n) - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - ((float)Math.Log(i + (b - a) / n))));

                        }
                    }

                    else MessageBox.Show("You didn't select a function to plot !!"); // to show a message if the user selected a wrong or unexisted function

                    // the next two 'if' statments are for drawing the coordinates lines
                    if (minx < 0 && maxx > 0) // if the maximum and minimum values have different signs then draw the vertical line 
                    {
                        for (float i = 0; i < mypanel.Height; i++)
                        {



                            graphicsobject.DrawLine
                           (cpen, Math.Abs(minx) * mypanel.Width / (maxx - minx), i, Math.Abs(minx) * mypanel.Width / (maxx - minx), (i + 1));

                        }
                    }

                    if (miny < 0 && maxy > 0)  // if the maximum and minimum values have different signs then draw the horizontal line
                    {
                        for (float i = 0; i < mypanel.Width; i++)
                        {
                            graphicsobject.DrawLine
                                (cpen, i, maxy * (mypanel.Height / (maxy - miny)), i + 1, maxy * (mypanel.Height / (maxy - miny)));

                        }
                    }




                }
                 // the next part is for enabling the drawing properity after the user click on the 'Load' button
                 // after the user click the button he can choose any function he wants to draw from the function list blow
                else if (loadbtn_Clicked == true)
                {
                    string line = datalist.SelectedItem.ToString();
                    string[] sline = line.Split(',');



                    float a = float.Parse(sline[0]);
                    float b = float.Parse(sline[1]);
                    int n = int.Parse(sline[2]);
                    X0_val.Text = a.ToString();
                    XN_val.Text = b.ToString();
                    N_val.Text = n.ToString();
                    th.Text = thick.ToString();
                    Graphics graphicsobject = e.Graphics;
                    
                    if (CColor.FromName(sline[4]).IsKnownColor)   // if the color is known then use the name directly
                    {
                        CColor clrColor = CColor.FromName(sline[4]);
                        Pen lpen = new Pen(clrColor, thick);
                        pen = lpen;
                    }
                    else         //else if it is not known ... convert the hexadecimal code to a decimal onr then put id as an ARGB because each two characters present a properity
                    {
                        string sen = sline[4];
                        string A = sen.Substring(0, 2);
                        string R = sen.Substring(2, 2);
                        string G = sen.Substring(4, 2);
                        string B = sen.Substring(6, 2);
                        colorDialog1.Color = Color.FromArgb(Convert.ToInt32(A, 16) , Convert.ToInt32(R, 16), Convert.ToInt32(G, 16), Convert.ToInt32(B, 16));
                        Pen lpen = new Pen(colorDialog1.Color, thick);
                        pen = lpen;

                    }
                   
                    if (sline[3] == "sin")
                    {


                        double[] x_axis = x_val(a, b, n);
                        double[] y_axis = Y_val(sline[3], x_axis);

                        Y0_val.Text = MinY(y_axis).ToString();
                        YN_val.Text = MaxY(y_axis).ToString();

                        float f_a = float.Parse(Y0_val.Text);
                        float f_b = float.Parse(YN_val.Text);
                        maxy = f_b;
                        miny = f_a;
                        maxx = b;
                        minx = a;
                        title.Text = "  Sin";
                        for (float i = a; i < b; i = i + (b - a) / n)
                        {
                            graphicsobject.DrawLine
                                (pen, (i - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - (float)Math.Sin(i)),
                                ((i + (b - a) / n) - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - (float)Math.Sin(i + (b - a) / n)));

                        }
                    }
                    else if (sline[3] == "cos")
                    {



                        double[] x_axis = x_val(a, b, n);
                        double[] y_axis = Y_val(sline[3], x_axis);

                        Y0_val.Text = MinY(y_axis).ToString();
                        YN_val.Text = MaxY(y_axis).ToString();

                        float f_a = float.Parse(Y0_val.Text);
                        float f_b = float.Parse(YN_val.Text);
                        maxy = f_b;
                        miny = f_a;
                        maxx = b;
                        minx = a;
                        title.Text = "  Cos";
                        for (float i = a; i < b; i = i + (b - a) / n)
                        {
                            graphicsobject.DrawLine
                                (pen, (i - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - (float)Math.Cos(i)),
                                ((i + (b - a) / n) - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - (float)Math.Cos(i + (b - a) / n)));

                        }
                    }
                    else if (sline[3] == "X^2")
                    {



                        double[] x_axis = x_val(a, b, n);
                        double[] y_axis = Y_val(sline[3], x_axis);

                        Y0_val.Text = MinY(y_axis).ToString();
                        YN_val.Text = MaxY(y_axis).ToString();

                        float f_a = float.Parse(Y0_val.Text);
                        float f_b = float.Parse(YN_val.Text);
                        maxy = f_b;
                        miny = f_a;
                        maxx = b;
                        minx = a;
                        title.Text = "  X^2";

                        for (float i = a; i < b; i = i + (b - a) / n)
                        {
                            graphicsobject.DrawLine
                                (pen, (i - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - i * i),
                                ((i + (b - a) / n) - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - (i + (b - a) / n) * (i + (b - a) / n)));

                        }
                    }
                    else if (sline[3] == "3X+5")
                    {
                        a = a * 1000;
                        b = b * 1000;

                        double[] x_axis = x_val(a, b, n);
                        double[] y_axis = Y_val(sline[3], x_axis);

                        Y0_val.Text = (3 * a / 1000 + 5).ToString();
                        YN_val.Text = (3 * b / 1000 + 5).ToString();

                        float f_a = (float)MinY(y_axis);
                        float f_b = (float)MaxY(y_axis);

                        maxy = f_b;
                        miny = f_a;
                        maxx = b / 1000;
                        minx = a / 1000;
                        title.Text = "3x+5";
                        for (float i = a; i < b; i = i + (b - a) / n)
                        {
                            graphicsobject.DrawLine
                                (pen, (i - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - 3 * i + 5),
                                ((i + (b - a) / n) - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - (3 * (i + (b - a) / n) + 5)));

                        }
                    }
                    else if (sline[3] == "|X|")
                    {
                        double[] x_axis = x_val(a, b, n);
                        double[] y_axis = Y_val(sline[3], x_axis);

                        Y0_val.Text = MinY(y_axis).ToString();
                        YN_val.Text = MaxY(y_axis).ToString();

                        float f_a = float.Parse(Y0_val.Text);
                        float f_b = float.Parse(YN_val.Text);

                        maxy = f_b;
                        miny = f_a;
                        maxx = b;
                        minx = a;
                        title.Text = "  |X|";
                        for (float i = a; i < b; i = i + (b - a) / n)
                        {
                            graphicsobject.DrawLine
                                (pen, (i - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - Math.Abs(i)),
                                ((i + (b - a) / n) - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - (Math.Abs(i + (b - a) / n))));

                        }
                    }
                    else if (sline[3] == "tan")
                    {
                        double[] x_axis = x_val(a, b, n);
                        double[] y_axis = Y_val(sline[3], x_axis);

                        Y0_val.Text = MinY(y_axis).ToString();
                        YN_val.Text = MaxY(y_axis).ToString();

                        float f_a = float.Parse(Y0_val.Text);
                        float f_b = float.Parse(YN_val.Text);

                        maxy = f_b;
                        miny = f_a;
                        maxx = b;
                        minx = a;
                        title.Text = "  Tan";
                        for (float i = a; i < b; i = i + (b - a) / n)
                        {
                            graphicsobject.DrawLine
                                (pen, (i - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - (float)Math.Tan(i)),
                                ((i + (b - a) / n) - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - (float)Math.Tan(i + (b - a) / n)));

                        }

                    }
                    else if (sline[3] == "ln")
                    {
                        double[] x_axis = x_val(a, b, n);
                        double[] y_axis = Y_val(sline[3], x_axis);

                        Y0_val.Text = MinY(y_axis).ToString();
                        YN_val.Text = MaxY(y_axis).ToString();

                        float f_a = float.Parse(Y0_val.Text);
                        float f_b = float.Parse(YN_val.Text);
                        maxy = f_b;
                        miny = f_a;
                        maxx = b;
                        minx = a;
                        title.Text = "  Ln";

                        for (float i = a; i < b; i = i + (b - a) / n)
                        {
                            graphicsobject.DrawLine
                                (pen, (i - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - (float)Math.Log(i)),
                                ((i + (b - a) / n) - a) * mypanel.Width / (b - a),
                                (mypanel.Height / (f_b - f_a)) * (Math.Abs(f_b) - ((float)Math.Log(i + (b - a) / n))));

                        }
                    }

                    else MessageBox.Show("You didn't select a function to plot !!");


                    if (a < 0 && b > 0)
                    {
                        for (float i = 0; i < mypanel.Height; i++)
                        {
                            graphicsobject.DrawLine
                                (cpen, Math.Abs(a) * mypanel.Width / (b - a), i, Math.Abs(a) * mypanel.Width / (b - a), (i + 1));

                        }
                    }

                    if (miny < 0 && maxy > 0)
                    {
                        for (float i = 0; i < mypanel.Width; i++)
                        {
                            graphicsobject.DrawLine
                                (cpen, i, maxy * (mypanel.Height / (maxy - miny)), i + 1, maxy * (mypanel.Height / (maxy - miny)));
                            
                        }
                    }
                }



                }
            // this part is for handling the exceptions in the upper statements
            catch (FormatException ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                MessageBox.Show("Error : Parsing to int failed");

               
            }


            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                MessageBox.Show("Error : Can't divide by zero");
               
            }

            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                MessageBox.Show("Error : wrong index");
                
            }

            catch (NullReferenceException ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                MessageBox.Show("Error : null object");

                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                MessageBox.Show("Error : Exceptoin");
              
            }
            
            finally
            {}




        }

        private void Form1_Load(object sender, EventArgs e)  //nothing important
        {
            string path = "text.txt";

            string[] lines = File.ReadAllLines(path);
            datalist.Items.AddRange(lines);
        }

        private void save_btn_Click(object sender, EventArgs e) // the 'save' button event
        {
            string details = X0_val.Text + "," + XN_val.Text + "," + N_val.Text + "," + func_list.Text + "," + colorDialog1.Color.Name + "\n"; // determine the formula to save the data
            File.AppendAllText("Text.txt", details);

            

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.Append))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(details);
                }
            }
            details = null;
        }

        private void Button5_Click(object sender, EventArgs e)         //the 'load' button event (has a different name (Button5) but it is the 'load' button
        {
            datalist.Items.Clear();          //clear the function list first 

            OpenFileDialog openFileDialog1 = new OpenFileDialog();  //then open file dialog to choose a file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s2 = File.Open(openFileDialog1.FileName, FileMode.Open))
                using (StreamReader sw = new StreamReader(s2))
                {
                    // the next part is for splitting the text to have a single line then put it in the function list
                    string q = "";                 
                    q = sw.ReadToEnd();
                    string[] lines = q.Split('\n');
                    datalist.Items.AddRange(lines);


                }
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)   // the 'clear' button
        {
            draw_btn_Clicked = false;
            loadbtn_Clicked = false;
            mypanel.Invalidate();
        }

        private void func_list_SelectedIndexChanged(object sender, EventArgs e)  //nothing important
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e) // nothing important
        {

        }

        private void color_btn_Click(object sender, EventArgs e)  // the 'Color' button
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)  //first we want to erase the panel then draw a new function with new color
            {
                draw_btn_Clicked = false;
                loadbtn_Clicked = false;
                mypanel.Invalidate();

                
                Pen npen = new Pen(colorDialog1.Color, thick);
                pen = npen;
                draw_btn_Clicked = true;
                mypanel.Invalidate();
            }
        }

        private void jerry(object sender, MouseEventArgs e)                    // the mouse moving event
        {
            float ly = ((-e.Y) * ((maxy - miny) / mypanel.Height)) + Math.Abs(maxy); // transformation formula for the position
            float lx = ((e.X) * ((maxx - minx) / mypanel.Width)) + minx;             // transformation formula for the position
            pc.Text = "(" + e.X + " , " + e.Y + ")";     //position in the panel 
            dc.Text = "(" + (float)lx + " , " + (float)ly + ")"; // position in the drawing area

        }
        private void datalist_SelectedIndexChanged(object sender, EventArgs e)  //the function list event
        {
            //first we want to erase the panel then draw a new selected function
            loadbtn_Clicked = false;    
            draw_btn_Clicked = false;
            mypanel.Invalidate();

            loadbtn_Clicked = true;
            mypanel.Invalidate();
        }


    }
}

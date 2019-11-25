using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseMovementCalculator
{
    public partial class MouseMove : Form
    {
        // counts till 320 clicks
        int i = 0;
        
        
        //below are all variables for index for each task 
        
        int direction, secondTask, fourthTask, sixthTask = 15, eightTask =15 , task1 = 15, task3 =15, task5 =15 , task7= 15;
        int dir = 15, thirdTask=15, fifthTask=0, seventhTask=0, nineTask=0, task2=0, task4=0, task6 = 0;
        int fourthTask1 = 15;
        int seventhTask1 = 15;
        int nineTask1 = 15;
        int nineTask2 = 0;
        //counts error
        int errorCount = 0;

        float diameter;
        //time calculator

        Stopwatch sw = new Stopwatch();//time calculator for the event



        List<Tuple<double, float, int, string, string>> data = new List<Tuple<double, float,int, string, string>>();

        private List<Point> coords = new List<Point> { };
        private bool taskOngoing = false;
        MouseEventHandler mouseIsMoving;

        public MouseMove()
        {
            InitializeComponent();
            roundButton1.Hide();

        }

        private void MouseMove_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            sw.Start();//starts the timer 
            taskOngoing = true;
            button1.Enabled = false;


            List<Tuple<int, int>> mylist = new List<Tuple<int, int>>();

            //4 possible distances for X-axis
            var distances = new List<int> { 246, 261, 373, 441 };
            // 4 possible size of the circle
            var sizes = new List<int> { 45, 91, 80, 180 };


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    mylist.Add(new Tuple<int, int>(distances[i], sizes[j]));


                }
            }
            Random randomList = new Random();
            //mylist = randomList .Next()

            List<int> randomSize = new List<int> { };
            List<int> randomDistance = new List<int> { };
            for (int i = 0; i < mylist.Count; i++)
            {
                string value = mylist[i].ToString();
                string[] split = value.Split(',');
                var a = Regex.Replace(split[0], @"^\(+", "");
                var b = Regex.Replace(split[1], @"\)+$", "");
                randomDistance.Add(Convert.ToInt32(a));
                randomSize.Add(Convert.ToInt32(b));

            }


            List<int> randomSize1 = randomSize;
            List<int> randomDistance1 = randomDistance;/// For the other 16 


            //following code is for all the possible 32 tasks 10 times
            //for other 32
            //one task

            if (direction < 16)
            {
                if (direction % 2 == 0)
                {

                    Point location = new Point(randomDistance[direction] + 500, 274);
                    Size size = new Size(randomSize[direction], randomSize[direction]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                else if (direction % 2 != 0)
                {

                    Point location = new Point(500 - randomDistance[direction], 274);
                    Size size = new Size(randomSize[direction], randomSize[direction]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;
                    
                }
                direction++;
                
            }



            //
            else if (dir >=0  )
            {
                if (dir % 2 != 0)
                {

                    Point location = new Point(randomDistance1[dir] + 500, 274);
                    Size size = new Size(randomSize1[dir], randomSize1[dir]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                else if (dir % 2 == 0)
                {

                    Point location = new Point(500 - randomDistance1[dir], 274);
                    Size size = new Size(randomSize1[dir], randomSize1[dir]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;


                }

                dir--;
            }
            ///TASK ! FINISHLINE



            //TASK TWO START LINE
            else if (i >= 32 && i < 48 && secondTask < 16)
            {
                if (secondTask % 2 == 0)
                {

                    Point location = new Point(randomDistance[secondTask] + 500, 274);
                    Size size = new Size(randomSize[secondTask], randomSize[secondTask]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                else if (secondTask % 2 != 0)
                {

                    Point location = new Point(500 - randomDistance[secondTask], 274);
                    Size size = new Size(randomSize[secondTask], randomSize[secondTask]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                secondTask++;
            }

            else if (i >= 48 && i < 64 && thirdTask >= 0)
            {

                if (thirdTask % 2 != 0)
                {

                    Point location = new Point(randomDistance1[thirdTask] + 500, 274);
                    Size size = new Size(randomSize1[thirdTask], randomSize1[thirdTask]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                else if (thirdTask % 2 == 0)
                {

                    Point location = new Point(500 - randomDistance1[thirdTask], 274);
                    Size size = new Size(randomSize1[thirdTask], randomSize1[thirdTask]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;


                }
                thirdTask--;

            }
            ////two TASK FINSIHES
            ///



            //third TASK START

            else if (i >= 64 && i < 80 && fourthTask < 16)
            {

                if (fourthTask % 2 == 0)
                {

                    Point location = new Point(randomDistance[fourthTask] + 500, 274);
                    Size size = new Size(randomSize[fourthTask], randomSize[fourthTask]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                else if (fourthTask % 2 != 0)
                {

                    Point location = new Point(500 - randomDistance[fourthTask], 274);
                    Size size = new Size(randomSize[fourthTask], randomSize[fourthTask]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                fourthTask++;
            }

            ///thirds finishes
            ///

            //fourthTask 
            else if (i >= 80 && i < 96 && fourthTask1 >= 0)
            {

                if (fourthTask1 % 2 != 0)
                {

                    Point location = new Point(randomDistance[fourthTask1] + 500, 274);
                    Size size = new Size(randomSize[fourthTask1], randomSize[fourthTask1]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                else if (fourthTask1 % 2 == 0)
                {

                    Point location = new Point(500 - randomDistance[fourthTask1], 274);
                    Size size = new Size(randomSize[fourthTask1], randomSize[fourthTask1]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                fourthTask1--;
            }

            else if (i >= 96 && i < 112 && fifthTask <16)
            {

                if (fifthTask % 2 == 0)
                {

                    Point location = new Point(randomDistance[fifthTask] + 500, 274);
                    Size size = new Size(randomSize[fifthTask], randomSize[fifthTask]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                else if (fifthTask % 2 != 0)
                {

                    Point location = new Point(500 - randomDistance[fifthTask], 274);
                    Size size = new Size(randomSize[fifthTask], randomSize[fifthTask]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                fifthTask++;
            }
            ///third TASK FINSISHESSS
            ///




            //fourth TASK START


            else if (i >= 96 && i < 112 && sixthTask >=0)
            {

                if (sixthTask % 2 != 0)
                {

                    Point location = new Point(randomDistance[sixthTask] + 500, 274);
                    Size size = new Size(randomSize[sixthTask], randomSize[sixthTask]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                else if (sixthTask % 2 == 0)
                {

                    Point location = new Point(500 - randomDistance[sixthTask], 274);
                    Size size = new Size(randomSize[sixthTask], randomSize[sixthTask]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                sixthTask--;
            }

            else if (i >= 112 && i < 128 && seventhTask <16)
            {

                if (seventhTask % 2 == 0)
                {

                    Point location = new Point(randomDistance[seventhTask] + 500, 274);
                    Size size = new Size(randomSize[seventhTask], randomSize[seventhTask]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                else if (seventhTask % 2 != 0)
                {

                    Point location = new Point(500 - randomDistance[seventhTask], 274);
                    Size size = new Size(randomSize[seventhTask], randomSize[seventhTask]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                seventhTask++;
            }

            ///fourth TASK FINISH
            ///

            else if (i >= 128 && i < 144 && seventhTask1 >= 0)
            {

                if (seventhTask1 % 2 != 0)
                {

                    Point location = new Point(randomDistance[seventhTask1] + 500, 274);
                    Size size = new Size(randomSize[seventhTask1], randomSize[seventhTask1]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                else if (seventhTask1 % 2 == 0)
                {

                    Point location = new Point(500 - randomDistance[seventhTask1], 274);
                    Size size = new Size(randomSize[seventhTask1], randomSize[seventhTask1]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                seventhTask1--;
            }

            //fifth TIME START
            else if (i >= 144 && i < 160 && eightTask >=0)
            {

                if (eightTask % 2 != 0)
                {

                    Point location = new Point(randomDistance[eightTask] + 500, 274);
                    Size size = new Size(randomSize[eightTask], randomSize[eightTask]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                else if (eightTask % 2 == 0)
                {

                    Point location = new Point(500 - randomDistance[eightTask], 274);
                    Size size = new Size(randomSize[eightTask], randomSize[eightTask]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                eightTask--;
            }

            else if (i >= 160 && i < 176 && nineTask <16 )
            {

                if (nineTask % 2 == 0)
                {

                    Point location = new Point(randomDistance[nineTask] + 500, 274);
                    Size size = new Size(randomSize[nineTask], randomSize[nineTask]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                else if (nineTask % 2 != 0)
                {

                    Point location = new Point(500 - randomDistance[nineTask], 274);
                    Size size = new Size(randomSize[nineTask], randomSize[nineTask]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                nineTask++;
            }
            //////
            ////////
            ////
            ////
            ////
            ////
            /// 
            else if (i >= 176 && i < 192 && nineTask1 >=0)
            {

                if (nineTask1 % 2 != 0)
                {

                    Point location = new Point(randomDistance[nineTask1] + 500, 274);
                    Size size = new Size(randomSize[nineTask1], randomSize[nineTask1]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                else if (nineTask1 % 2 == 0)
                {

                    Point location = new Point(500 - randomDistance[nineTask1], 274);
                    Size size = new Size(randomSize[nineTask1], randomSize[nineTask1]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                nineTask1--;
            }
            //fifth STOP
            else if (i >= 192 && i < 208 && nineTask2 <16)
            {

                if (nineTask2 % 2 == 0)
                {

                    Point location = new Point(randomDistance[nineTask2] + 500, 274);
                    Size size = new Size(randomSize[nineTask2], randomSize[nineTask2]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                else if (nineTask2 % 2 != 0)
                {

                    Point location = new Point(500 - randomDistance[nineTask2], 274);
                    Size size = new Size(randomSize[nineTask2], randomSize[nineTask2]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                nineTask2++;
            }



            //sixth TIME START
            else if (i >= 208 && i < 224 && task1 >=0)
            {

                if (task1 % 2 != 0)
                {

                    Point location = new Point(randomDistance[task1] + 500, 274);
                    Size size = new Size(randomSize[task1], randomSize[task1]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                else if (task1 % 2 == 0)
                {

                    Point location = new Point(500 - randomDistance[task1], 274);
                    Size size = new Size(randomSize[task1], randomSize[task1]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                task1--;
            }

            else if (i >= 224 && i < 240 && task2 <16)
            {

                if (task2 % 2 == 0)
                {

                    Point location = new Point(randomDistance[task2] + 500, 274);
                    Size size = new Size(randomSize[task2], randomSize[task2]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                else if (task2 % 2 != 0)
                {

                    Point location = new Point(500 - randomDistance[task2], 274);
                    Size size = new Size(randomSize[task2], randomSize[task2]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                task2++;
            }

            //sixth STOP






            //seventh TIME START
            else if (i >= 240 && i < 256 && task3 >= 0)
            {

                if (task3 % 2 != 0)
                {

                    Point location = new Point(randomDistance[task3] + 500, 274);
                    Size size = new Size(randomSize[task3], randomSize[task3]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                else if (task3 % 2 == 0)
                {

                    Point location = new Point(500 - randomDistance[task3], 274);
                    Size size = new Size(randomSize[task3], randomSize[task3]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                task3--;
            }

            else if (i >= 256 && i < 272 && task4 <16)
            {

                if (task4 % 2 == 0)
                {

                    Point location = new Point(randomDistance[task4] + 500, 274);
                    Size size = new Size(randomSize[task4], randomSize[task4]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                else if (task4 % 2 != 0)
                {

                    Point location = new Point(500 - randomDistance[task4], 274);
                    Size size = new Size(randomSize[task4], randomSize[task4]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                task4++;
            }

            //sevebth TIME finish


            //eigth time
            else if (i >= 272 && i < 288 && task5 >= 0)
            {

                if (task5 % 2 != 0)
                {

                    Point location = new Point(randomDistance[task5] + 500, 274);
                    Size size = new Size(randomSize[task5], randomSize[task5]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                else if (task5 % 2 == 0)
                {

                    Point location = new Point(500 - randomDistance[task5], 274);
                    Size size = new Size(randomSize[task5], randomSize[task5]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                task5--;
            }

            else if (i >= 288 && i < 304 && task6 <16)
            {

                if (task6 % 2 == 0)
                {

                    Point location = new Point(randomDistance[task6] + 500, 274);
                    Size size = new Size(randomSize[task6], randomSize[task6]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                else if (task6 % 2 != 0)
                {

                    Point location = new Point(500 - randomDistance[task6], 274);
                    Size size = new Size(randomSize[task6], randomSize[task6]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                task6++;
            }

            //eighth time fiish

            //ninth time start
            else if (i >= 304 && i < 320 && task7 >= 0)
            {

                if (task7 % 2 != 0)
                {

                    Point location = new Point(randomDistance[task7] + 500, 274);
                    Size size = new Size(randomSize[task7], randomSize[task7]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                else if (task7 % 2 == 0)
                {

                    Point location = new Point(500 - randomDistance[task7], 274);
                    Size size = new Size(randomSize[task7], randomSize[task7]);
                    roundButton1.Size = size;
                    roundButton1.Location = location;

                }
                task7--;
            }





            


            i++; //counting

            

            //text bos showing time
            textBox2.Text = sw.ElapsedMilliseconds.ToString();

            roundButton1.Visible = true;

        }

        private double distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }





        string timeTaken = "";
        //RoundButton Button
        private bool _loopRunning;


        /// <summary>
        /// roundButton where it will calculate most stuff to print
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        
        private void roundButton1_Click(object sender, EventArgs e)
        {

            var csv = new StringBuilder();
            //Remove mouse handler that accumulates cursor position and calculate total distance traveled, reset coords to empty
            taskOngoing = false;
            button1.Enabled = true;
            //time stops every 32 times

            if (i % 32 == 0 && i != 0)
            {
                sw.Stop();
                timeTaken = sw.Elapsed.ToString();
            
            }





            //diamameter\
            Size sizeOfCircle = roundButton1.Size;

            diameter = sizeOfCircle.Width;
            
            
            
            //distance for the mouse pointer 
            double totalDistanceTraveled = 0;
            for (int i = 0; i < coords.Count - 1; i++)
                totalDistanceTraveled += distance(coords[i], coords[i + 1]);
                
            Debug.WriteLine(totalDistanceTraveled);

            double stLine = 0;
            stLine = distance(coords[0], coords[coords.Count-1]);
            


            
            // shows the count
            textBox1.Text = i + "/320";

            if(i %32 == 0 && i != 0)
            {
                data.Add(new Tuple<double, float, int, string, string>(totalDistanceTraveled, diameter, 0, errorCount.ToString(), timeTaken + "Seconds"));

            }
            else
            {
                data.Add(new Tuple<double, float, int, string, string>(totalDistanceTraveled, diameter, 0, " ----", " ----"));
            }
            
            roundButton1.Hide();

            if (i == 320)
            {
                try
                {
                    for (int i = 0; i < data.Count - 1; i++)
                    {
                        var first = data[i].ToString();
                        csv.AppendLine(first);

                    }
                    
                    File.WriteAllText("C:\\test.txt", csv.ToString());

                }
                catch (Exception)
                {
                    throw new Exception ("Can't Access");
                }


                
                MessageBox.Show("Message", "Thank you for participating on this test.", MessageBoxButtons.OKCancel);
                if (MessageBox.Show("Message", "MessageBox Title", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }





        //4 round buttonswith different size ea


        //tracking the coordinates to find the distance travelled

        private void mouse_tracker(object sender, MouseEventArgs e)
        {
            if (taskOngoing)
            {
                Point p = new Point(e.X, e.Y);
                coords.Add(p);
                Debug.WriteLine(p);
            }
        }


        
        private void MouseMove_Click(object sender, EventArgs e)
        {
            errorCount++;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
    

    

        
        
   



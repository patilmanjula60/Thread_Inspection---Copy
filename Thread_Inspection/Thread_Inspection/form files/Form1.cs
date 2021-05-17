using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using EasyModbus;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Windows.Forms;

namespace Thread_Inspection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static readonly log4net.ILog log =
        log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        VideoCapture capture = new VideoCapture();
        ModbusClient plcmodule;
        Stopwatch sw = new Stopwatch();
        int count = 0;
        bool draw = false;
        Rectangle rect;
        OpenCvSharp.Point LocationXY;
        OpenCvSharp.Point LocationX1Y1;
        int tx, ty, th, tw;
        bool IsMouseDown = false;bool Hole_absent = false;bool Thread_absent = false;
        OpenCvSharp.Rect t;
        Mat temp = new Mat();

        OpenCvSharp.Point matchLoc, res_loc;
        Mat temp_match = new Mat();
        Mat templete = new Mat();
        Mat resizeimg = new Mat();
       

        FileInfo[] files;
        Mat Inputimg = new Mat();
        Mat outimg = new Mat();
        Mat crop = new Mat();
        Mat crop1 = new Mat();
        Mat outputimg = new Mat();
        Mat finalimg = new Mat();
        OpenCvSharp.Rect rect2 = new OpenCvSharp.Rect();

        string savepath,comma=",",appendtext;
        public static int Thread_Passcount = 0, Thread_Failcount = 0, Hole_Passcount = 0, Hole_Failcount = 0, Total_passcount, Total_failcount, total_count;
        int framecount, imagecount = 0, sno = 0, image_count=0;
        int x, y, threadcount = 0,Holecount=0,click,pixelcount=0;
        bool imgsave = false;
        double min, max;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                
                DateTime currentdate = DateTime.Now.Date;
                DateTime Expirydate = new DateTime(2021, 04, 01, 01, 04, 00); ;
                int res = currentdate.CompareTo(Expirydate);
                if (res == 1)
                {
                    MessageBox.Show("SOFTWARE EXPIRED");
                    Application.Exit();
                }
                else if(res==0)
                {
                    MessageBox.Show("1 day to expire");
                }
                datetime.Enabled = true;
                sw.Start();
                capture.Open(0);
                sw.Stop();
                framecount = 0; 
                loadsettings();
                
                //elapsingtime.Text = sw.ElapsedMilliseconds.ToString();
                savepath = string.Format("log result.csv");
                if (!File.Exists(savepath))
                {
                    string d = "S/NO" + comma+ DateTime.Now.ToShortDateString() +comma + "THREAD RESULT" + comma + "HOLE RESULT" + comma + "FINAL RESULT" + Environment.NewLine;
                    File.WriteAllText(savepath, d);
                }
                if (capture.IsOpened())
                {
                    camstatus.Text = "Camera connected";
                    camstatus.ForeColor = Color.Green;
                }
                else
                {
                    camstatus.Text = "Camera not connected";
                    camstatus.ForeColor = Color.Red;
                }
                plcmodule = new ModbusClient("COM4");
                plcmodule.Parity = System.IO.Ports.Parity.Even;
                plcmodule.Connect();
                bool[] plcdata = plcmodule.ReadDiscreteInputs(1024, 1);
                if ((plcdata == null))
                {
                    plcstatus.Text = "PLC is not connected";
                    plcstatus.ForeColor = Color.Red;
                }
                else
                {
                    plcstatus.Text = "PLC is connected";
                    plcstatus.ForeColor = Color.Green;
                }
               
                capture.Release(); //stop reading an image,erase parametrs(release)
            }
            catch (Exception Ex)
            {
                if (plcstatus.Text == "PLC Status")
                {
                    plcstatus.Text = "PLC is not connected";
                    plcstatus.ForeColor = Color.Red;
                }
                MessageBox.Show(Ex.Message.ToString());
                log.Error("Error Message: " + Ex.Message.ToString(), Ex);
                
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              //  DialogResult dg = MessageBox.Show(" Close the Application", "Conformatiom", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
               // if (dg == DialogResult.OK)
                {
                    plcmodule.WriteSingleCoil(1280, false);
                    plcmodule.WriteSingleCoil(1283, false);
                    capture.Dispose();
                    FileStorage fs = new FileStorage("count.yml", FileStorage.Mode.Write);
                    fs.Write("imagecount", imagecount);
                    fs.Write("sno", sno);
                    e.Cancel = false;

                }
               // else if (dg == DialogResult.Cancel)
                {
                  //  e.Cancel = true;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
                log.Error("Error Message: " + Ex.Message.ToString(), Ex);
            }
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            try
            {

                imagegrabtimer.Enabled = true;
                sw.Start();
                if (!capture.IsOpened())
                {
                    capture.Open(0);
                }
                Thread.Sleep(2000);

                //capture.Focus = 14;
                //Thread.Sleep(1000);
                //capture.FrameWidth = 1920;
                //capture.FrameHeight = 1080;
                ////for (int i = 0; i < 5; i++)
                ////{
                ////    if (capture.IsOpened())
                ////    {
                //capture.Read(Inputimg);
                ////    }
                ////}
                //framecount++;

                //Cv2.CvtColor(Inputimg, outimg, ColorConversionCodes.BGR2GRAY);
                //Cv2.NamedWindow("out", WindowMode.Normal);
                //Cv2.ImShow("out", Inputimg);
                //Cv2.ImWrite("original" + ".bmp", outimg);
                //Process_image();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
                log.Error("Error Message: " + Ex.Message.ToString(), Ex);
            }

        }
        private void stop_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                plcmodule.WriteSingleCoil(1280, false);
                plcmodule.WriteSingleCoil(1283, false);
                if (capture.IsOpened())
                {
                    capture.Release();
                }
                imagegrabtimer.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                log.Error("Error Message: " + ex.Message.ToString(), ex);
            }

        }
        private void loadsettings()
        {
            try
            {
                FileStorage fs = new FileStorage(@"temp.yml", FileStorage.Mode.Read);
                tx = fs["tx"].ReadInt();
                ty = fs["ty"].ReadInt();
                tw = fs["tw"].ReadInt();
                th = fs["th"].ReadInt();
                temp_match = fs["temp_match"].ReadMat();
                yml_path.Text = "temp.yml".ToString();
                FileStorage fs1 = new FileStorage(@"count.yml", FileStorage.Mode.Read);
                imagecount = fs1["imagecount"].ReadInt();
                sno = fs1["sno"].ReadInt();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
                log.Error("Error Message: " + Ex.Message.ToString(), Ex);
            }

        }
        private void browse_btn_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName == "")
                {
                    MessageBox.Show("File not found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                outimg = new Mat(openFileDialog1.FileName, ImreadModes.Grayscale);
                img_path.Text = openFileDialog1.FileName;
                img_disp.Image = outimg.ToBitmap();
                plcmodule.WriteSingleCoil(1280, false);
                plcmodule.WriteSingleCoil(1281, false);

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
                log.Error("Error Message: " + Ex.Message.ToString(), Ex);
            }

        }
        private void test_btn_Click(object sender, EventArgs e)
        {
            Process_image();
        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName == "")
                {
                    MessageBox.Show("file not selected", "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                yml_path.Text = saveFileDialog1.FileName;
                FileStorage fs = new FileStorage(yml_path.Text, FileStorage.Mode.Write);
                fs.Write("tx", tx);
                fs.Write("ty", ty);
                fs.Write("tw", tw);
                fs.Write("th", th);
                fs.Write("temp_match", temp_match);
               
                fs.Write("modified", DateTime.Now.ToString());
                fs.Release();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
                log.Error("Error Message: " + Ex.Message.ToString(), Ex);
            }

        }
        private void load_btn_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog2.ShowDialog();
                if (openFileDialog2.FileName == "")
                {
                    MessageBox.Show("No File selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                yml_path.Text = openFileDialog2.FileName;
                FileStorage fs = new FileStorage(yml_path.Text, FileStorage.Mode.Read);
                tx = fs["tx"].ReadInt();
                ty = fs["ty"].ReadInt();
                tw = fs["tw"].ReadInt();
                th = fs["th"].ReadInt();
                temp_match = fs["temp_match"].ReadMat();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
                log.Error("Error Message: " + Ex.Message.ToString(), Ex);
            }
        }
        private void log_btn_Click(object sender, EventArgs e)
        {
            //folderBrowserDialog1.ShowDialog();
            imgsave = true;
        }
        private void adjust_btn_Click(object sender, EventArgs e)
        {
           
        }
        private void img_disp_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (draw)
                {
                    IsMouseDown = true; 
                    LocationXY = new OpenCvSharp.Point(e.X, e.Y); 

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
                log.Error("Error Message: " + Ex.Message.ToString(), Ex);
            }

        }
        private void img_disp_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {

                if (draw)
                {
                    if (IsMouseDown == true)
                    {
                        LocationX1Y1 = new OpenCvSharp.Point(e.X, e.Y);   

                        IsMouseDown = false;

                        if (rect != null)
                        {
                            double scaleX = (double)crop.Width / img_disp.Size.Width;
                            double scaleY = (double)crop.Height / img_disp.Size.Height;
                            tx = (int)(rect.X * scaleX) + 5;
                            ty = (int)(rect.Y * scaleY) + 10;
                            tw = (int)(rect.Width * scaleX);
                            th = (int)(rect.Height * scaleY);
                            t = new Rect(tx, ty, tw, th);
                            temp = new Mat(crop, t);//205,72,725,968
                            temp.CopyTo(temp_match);
                            temp.CopyTo(templete);
                            Cv2.NamedWindow("roi", WindowMode.Normal);
                            Cv2.ImShow("roi", temp);
                            //pictureBox1.Image = temp.ToBitmap();
                            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        }

                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
                log.Error("Error Message: " + Ex.Message.ToString(), Ex);
            }

        }

        private void img_disp_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {

                if (draw)
                {
                    if (IsMouseDown == true)
                    {
                        LocationX1Y1 = new OpenCvSharp.Point(e.X, e.Y);

                        img_disp.Invalidate();

                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
                log.Error("Error Message: " + Ex.Message.ToString(), Ex);
            }

        }
        private Rectangle GetRect()
        {
            rect = new Rectangle(); 
            rect.X = Math.Min(LocationXY.X, LocationX1Y1.X);
            rect.Y = Math.Min(LocationXY.Y, LocationX1Y1.Y);
            rect.Width = Math.Abs(LocationXY.X - LocationX1Y1.X);
            rect.Height = Math.Abs(LocationXY.Y - LocationX1Y1.Y);
            return rect;
        }

        private void img_disp_Paint(object sender, PaintEventArgs e)
        {
            try
            {

                if (rect != null)
                {
                    e.Graphics.DrawRectangle(Pens.Green, GetRect());
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
                log.Error("Error Message: " + Ex.Message.ToString(), Ex);
            }

        }
        void Process_image()
        {
            try
            {
                crop_image(outimg);
               
                if ( /*pixelcount<800 &&*/ threadcount >=4)
                {
                    Thread_result.Text = "THREAD PRESENT";
                    Thread_result.BackColor = Color.LimeGreen;
                    Thread_Passcount++;
                    OpenCvSharp.Rect thread_rect = new OpenCvSharp.Rect(415, 487, 110 + 65, 85 + 85);
                    Cv2.Rectangle(finalimg, thread_rect, Scalar.LimeGreen, 5);

                }
                else
                {
                    Thread_result.Text = "THREAD ABSENT";
                    Thread_result.BackColor = Color.Red;
                    Thread_Failcount++;
                    OpenCvSharp.Rect thread_rect = new OpenCvSharp.Rect(415, 487, 110 + 65, 85 + 85);//415,487,110,85
                    Cv2.Rectangle(finalimg, thread_rect, Scalar.Red, 5);
                }
                
                if ((Holecount > 3))

                {
                    hole_result.Text = "4 HOLE PRESENT";
                    hole_result.BackColor = Color.LimeGreen;
                    Hole_Passcount++;

                }
                else
                {
                    hole_result.Text = 4 - Holecount + "HOLE is Missing".ToString();
                    hole_result.BackColor = Color.Red;
                    Hole_Failcount++;

                }
                if (Thread_result.Text == "THREAD PRESENT" && hole_result.Text == "4 HOLE PRESENT")
                {

                    Final_result.Text = "PASS";
                    Final_result.BackColor = Color.Lime;
                    Total_passcount++;
                    total_count++;
                    plcmodule.WriteSingleCoil(1280, true);
                }
                else
                {
                    Final_result.Text = "FAIL";
                    Final_result.BackColor = Color.Red;
                    Total_failcount++;
                    total_count++;
                    plcmodule.WriteSingleCoil(1280, true);
                }
                
                if (imgsave==true)
                {
                    if (Final_result.Text == "PASS")
                      Cv2.ImWrite(@"D:\log images\good images\" + imagecount + ".bmp", outimg);
                    else
                      Cv2.ImWrite(@"D:\log images\bad images\" + imagecount + ".bmp", outimg);

                    imagecount++;
                }
                
                Form3.start = false;
                //appendtext = sno.ToString() + DateTime.Now.ToShortDateString() + comma + Thread_result.Text + comma + hole_result.Text + comma + Final_result.Text + Environment.NewLine;
                //File.AppendAllText("log result.csv", appendtext);
                //sno++;
                img_disp.Image = finalimg.ToBitmap();

                sw.Stop();
                elapsingtime.Text = sw.ElapsedMilliseconds.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
                log.Error("Error Message: " + Ex.Message.ToString(), Ex);
            }
        }
        void crop_image(Mat outimg)
        {
            try
            {
                  Mat copy = new Mat();
                  outimg.CopyTo(copy);
                  OpenCvSharp.Rect rect = new OpenCvSharp.Rect(500,0,1100,1080);
                 // Cv2.Rectangle(copy, rect, Scalar.Blue, 3);//500,0,1100,1080
                  crop = new Mat(outimg, rect);
                  crop.CopyTo(outputimg);
                  //Cv2.NamedWindow("crop", WindowMode.FreeRatio);
                  //Cv2.ImShow("crop", crop);
                  Cv2.ImWrite("crop" + ".bmp", crop);
                  if (outputimg.Channels() == 1)
                    Cv2.CvtColor(outputimg, outputimg, ColorConversionCodes.GRAY2BGR);
                  thread(crop);
                //img_disp.Image = crop.ToBitmap();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
                log.Error("Error Message: " + Ex.Message.ToString(), Ex);
            }

        }
        private void thread(Mat inimg)
        {
            try
            {
                threadcount = 0;
                Mat thread = new Mat();
                OpenCvSharp.Size kksize = new OpenCvSharp.Size(1, 1);
                Mat element = Cv2.GetStructuringElement(MorphShapes.Cross, kksize);
                Holes1(crop);
                if (crop.Channels() > 1)
                   Cv2.CvtColor(crop, crop, ColorConversionCodes.BGR2GRAY);
                template_matching(crop, temp_match);
                resizeimg.CopyTo(thread);
                Cv2.NamedWindow("templete", WindowMode.FreeRatio);
                Cv2.ImShow("templete", resizeimg);
                if (thread.Channels() > 1)
                  Cv2.CvtColor(thread, thread, ColorConversionCodes.BGR2GRAY);
                OpenCvSharp.Rect thread_roi1 = new OpenCvSharp.Rect(0, 0, 20, 125);//0,0,20,125
                Cv2.Rectangle(thread, thread_roi1, Scalar.Black, -1);
                OpenCvSharp.Rect thread_roi2 = new OpenCvSharp.Rect(127, 0, 25, 125);//128,0,20,125
                Cv2.Rectangle(thread, thread_roi2, Scalar.Black, -1);
                OpenCvSharp.Rect thread_roi3 = new OpenCvSharp.Rect(0, 115, 140, 16);//0,113,130,13
                Cv2.Rectangle(thread, thread_roi3, Scalar.Black, -1);
                OpenCvSharp.Rect thread_roi4 = new OpenCvSharp.Rect(0, 0, 135, 25);//0,0,135,20
                Cv2.Rectangle(thread, thread_roi4, Scalar.Black, -1);
                OpenCvSharp.Rect thread_roi5 = new OpenCvSharp.Rect(48, 80, 33, 23);//50,80,30,23
                Cv2.Rectangle(thread, thread_roi5, Scalar.Black, -1);
                Cv2.NamedWindow("mask", WindowMode.FreeRatio);
                Cv2.ImShow("mask", thread);
                Cv2.Sobel(thread, thread, MatType.CV_8UC1, 0, 1, 1);
                if (Form3.start5==true)
                {
                    Cv2.Threshold(thread, thread, Form3.thread_value, 255, ThresholdTypes.Otsu);
                    Form3.start5 = false;
                }
                else
                {
                    Cv2.Threshold(thread, thread, 120, 255, ThresholdTypes.Otsu);
                }
               
               
                Cv2.NamedWindow("inrange", WindowMode.FreeRatio);
                Cv2.ImShow("inrange", thread);
                pixelcount = Cv2.CountNonZero(thread);
               
                OpenCvSharp.Point[][] contour1;
                HierarchyIndex[] hier1;
                OpenCvSharp.Rect rect3 = new OpenCvSharp.Rect();
                Cv2.FindContours(thread, out contour1, out hier1, RetrievalModes.Tree, ContourApproximationModes.ApproxSimple);
                if (resizeimg.Channels() == 1)
                   Cv2.CvtColor(resizeimg, resizeimg, ColorConversionCodes.GRAY2BGR);
                for (int i = 0; i < contour1.Length; i++)
                {
                    rect3 = Cv2.BoundingRect(contour1[i]);
                    if (Cv2.ContourArea(contour1[i]) > 10 && Cv2.ContourArea(contour1[i]) < 1000  )//60,500
                    {
                        if (rect3.Width > 20 && rect3.Width < 90 && rect3.Height < 26 && rect3.Height>3)//10,300,20,3  10,300,26,3
                        {
                            Cv2.DrawContours(resizeimg, contour1, i, Scalar.LimeGreen, 2);
                            threadcount++;
                       }
                    }
                }
                Cv2.NamedWindow("templete1", WindowMode.FreeRatio);
                Cv2.ImShow("templete1", resizeimg);
                Cv2.ImWrite("thread" + ".bmp", resizeimg);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
                log.Error("Error Message: " + Ex.Message.ToString(), Ex);
            }

        }
        private void Holes1(Mat cropped_image )
        {
          
            try
            {
                Holecount = 0;
                Mat hole_crop = new Mat();
                OpenCvSharp.Point[][] contour;
                HierarchyIndex[] hier;
                OpenCvSharp.Rect rect1 = new OpenCvSharp.Rect();
                OpenCvSharp.Size ksize = new OpenCvSharp.Size(3, 3);
                OpenCvSharp.Size kksize = new OpenCvSharp.Size(5,5);
                Mat element = Cv2.GetStructuringElement(MorphShapes.Cross, ksize);
                Mat element1 = Cv2.GetStructuringElement(MorphShapes.Cross, kksize);
                cropped_image.CopyTo(hole_crop);
                if (hole_crop.Channels() == 1)
                    Cv2.CvtColor(hole_crop,hole_crop, ColorConversionCodes.GRAY2BGR);

                OpenCvSharp.Rect roi1 = new OpenCvSharp.Rect(43, 340, 180, 220);//47,340,180,220
                Cv2.Rectangle(hole_crop, roi1, Scalar.Green, 3);
                OpenCvSharp.Point pnt1 = new OpenCvSharp.Point(roi1.X, roi1.Y);
                Cv2.PutText(hole_crop, 1.ToString(), pnt1, HersheyFonts.HersheyPlain, 8, Scalar.Red, 5);

                OpenCvSharp.Rect roi2 = new OpenCvSharp.Rect(430, 30, 200, 210);//370,25,200,200    //430,30,200,200
                Cv2.Rectangle(hole_crop, roi2, Scalar.Green, 3);
                OpenCvSharp.Point pnt2 = new OpenCvSharp.Point(roi2.X - 80, roi2.Y + 80);
                Cv2.PutText(hole_crop, 2.ToString(), pnt2, HersheyFonts.HersheyPlain, 8, Scalar.Red, 5);

                OpenCvSharp.Rect roi3 = new OpenCvSharp.Rect(877, 320, 195, 250);//870,320,200,250    //870,320,200,250
                Cv2.Rectangle(hole_crop, roi3, Scalar.Green, 4);
                OpenCvSharp.Point pnt3 = new OpenCvSharp.Point(roi3.X, roi3.Y);
                Cv2.PutText(hole_crop, 3.ToString(), pnt3, HersheyFonts.HersheyPlain, 8, Scalar.Red, 5);

                OpenCvSharp.Rect roi4 = new OpenCvSharp.Rect(550, 800, 170, 200);//580,800,200,200   //520,770,200,200   550, 800, 170, 200
                Cv2.Rectangle(hole_crop, roi4, Scalar.Green, 3);
                OpenCvSharp.Point pnt4 = new OpenCvSharp.Point(roi4.X, roi4.Y);
                Cv2.PutText(hole_crop, 4.ToString(), pnt4, HersheyFonts.HersheyPlain, 8, Scalar.Red, 5);

                hole_crop.CopyTo(crop1);
                if (crop1.Channels() > 1)
                    Cv2.CvtColor(crop1, crop1, ColorConversionCodes.BGR2GRAY);
                for (int a = 0; a < 4; a++)
                {
                    if (a == 0)
                    {
                        Mat tempcrop = new Mat(crop1, roi1);
                        if (Form3.start1 == true)
                        {
                            Cv2.AdaptiveThreshold(tempcrop, tempcrop, 255, AdaptiveThresholdTypes.MeanC, ThresholdTypes.Binary, 71, Form3.value1);//71,76
                            Form3.start1 = false;
                        }
                        else
                        {
                          //Cv2.Threshold(tempcrop, tempcrop, 95, 255, ThresholdTypes.Binary);//100
                           Cv2.AdaptiveThreshold(tempcrop, tempcrop, 255, AdaptiveThresholdTypes.MeanC, ThresholdTypes.Binary, 71, 56);//71,76
                          
                        }
                        Cv2.Dilate(tempcrop, tempcrop, element1, null, 1);//1
                        Cv2.Erode(tempcrop, tempcrop, element, null, 6);//8
                        Cv2.FindContours(tempcrop, out contour, out hier, RetrievalModes.Tree, ContourApproximationModes.ApproxSimple);
                        if (tempcrop.Channels() == 1)
                           Cv2.CvtColor(tempcrop, tempcrop, ColorConversionCodes.GRAY2BGR);
                        for (int b = 0; b < contour.Length; b++)
                        {
                            rect1 = Cv2.BoundingRect(contour[b]);
                            if (Cv2.ContourArea(contour[b]) > 300 && Cv2.ContourArea(contour[b]) < 4000)//200,6000
                            {
                                double aspectratio = Convert.ToDouble(rect1.Width) / Convert.ToDouble(rect1.Height);
                                if (aspectratio >0.83 && aspectratio < 1.80)  //1.10 0.80  0.83,1.80
                                {
                                    if (rect1.Height > 25 && rect1.Height < 250 & rect1.Width > 30  && rect1.Width < 200)//10,200,200,10//25,250,30,200
                                    {
                                        OpenCvSharp.Rect hole_rect = new OpenCvSharp.Rect(rect1.X + roi1.X, rect1.Y + roi1.Y, rect1.Width, rect1.Height);
                                        Cv2.Rectangle(hole_crop, hole_rect, Scalar.LimeGreen, 5);
                                        Cv2.DrawContours(tempcrop, contour, b, Scalar.Blue, 3);
                                        Holecount++;
                                        Hole_absent = true;
                                        break;
                                    }
                                }

                            }
                        }
                        if (!Hole_absent == true)
                        {
                            OpenCvSharp.Rect hole_rect = new OpenCvSharp.Rect(47, 340, 180, 220);
                            Cv2.Rectangle(hole_crop, hole_rect, Scalar.Red, 5);
                        }
                        Hole_absent = false;
                        Cv2.NamedWindow("color", WindowMode.FreeRatio);
                        Cv2.ImShow("color", tempcrop);
                    }

                    if (a == 1)
                    {
                        Mat tempcrop = new Mat(crop1, roi2);
                        if (Form3.start2 == true)
                        {
                            Cv2.AdaptiveThreshold(tempcrop, tempcrop, 255, AdaptiveThresholdTypes.MeanC, ThresholdTypes.Binary, 89, Form3.value2);//89,5
                            Form3.start2 = false;
                        }
                        else
                        {
                            //Cv2.Threshold(tempcrop, tempcrop, 76, 255, ThresholdTypes.Binary);//75
                            Cv2.AdaptiveThreshold(tempcrop, tempcrop, 255, AdaptiveThresholdTypes.MeanC, ThresholdTypes.Binary,89 , 58);//89,58
                           
                        }
                        Cv2.Erode(tempcrop, tempcrop, element1, null, 6);//6
                        Cv2.FindContours(tempcrop, out contour, out hier, RetrievalModes.Tree, ContourApproximationModes.ApproxSimple);
                        if (tempcrop.Channels() == 1)
                           Cv2.CvtColor(tempcrop, tempcrop, ColorConversionCodes.GRAY2BGR);
                        for (int b = 0; b < contour.Length; b++)
                        {
                            rect1 = Cv2.BoundingRect(contour[b]);
                            if (Cv2.ContourArea(contour[b]) > 600 && Cv2.ContourArea(contour[b]) < 12000)//100,6000  //600,12000
                            {
                                double aspectratio = Convert.ToDouble(rect1.Width) / Convert.ToDouble(rect1.Height);
                                if (aspectratio < 1.45 && aspectratio > 0.80) //1.38 0.80  1.45,0.80

                                    if (rect1.Height > 25 && rect1.Height < 80 & rect1.Width < 80 && rect1.Width > 25)//22,80,80,25
                                    {
                                        OpenCvSharp.Rect hole_rect = new OpenCvSharp.Rect(rect1.X + roi2.X, rect1.Y + roi2.Y, rect1.Width, rect1.Height);
                                        Cv2.Rectangle(hole_crop, hole_rect, Scalar.LimeGreen, 5);
                                        Cv2.DrawContours(tempcrop, contour, b, Scalar.Blue, 3);
                                        Holecount++;
                                        Hole_absent = true;
                                        break;
                                    }
                            }

                        }
                        if (!Hole_absent == true)
                        {
                            OpenCvSharp.Rect hole_rect = new OpenCvSharp.Rect(430, 30, 200, 210);
                            Cv2.Rectangle(hole_crop, hole_rect, Scalar.Red, 5);
                        }
                        Hole_absent = false;
                        Cv2.NamedWindow("color1", WindowMode.AutoSize);
                        Cv2.ImShow("color1", tempcrop);
                    }
                    if (a == 2)
                    {
                        Mat tempcrop = new Mat(crop1, roi3);
                        if (Form3.start3 == true)
                        {
                            Cv2.Threshold(tempcrop, tempcrop, Form3.value3, 255, ThresholdTypes.Binary);
                            Form3.start3 = false;
                        }
                        else
                        {
                            Cv2.Threshold(tempcrop, tempcrop, 75, 255, ThresholdTypes.Binary);//85
                            
                            //v2.Erode(tempcrop, tempcrop, element1, null, 9);//9
                            //Cv2.Dilate(tempcrop, tempcrop, element, null, 1);
                        }
                        Cv2.MorphologyEx(tempcrop, tempcrop, MorphTypes.Close, element);
                        Cv2.FindContours(tempcrop, out contour, out hier, RetrievalModes.Tree, ContourApproximationModes.ApproxSimple);
                        if (tempcrop.Channels() == 1)
                           Cv2.CvtColor(tempcrop, tempcrop, ColorConversionCodes.GRAY2BGR);
                        for (int b = 0; b < contour.Length; b++)
                        {
                            rect1 = Cv2.BoundingRect(contour[b]);
                            if (Cv2.ContourArea(contour[b]) > 300 && Cv2.ContourArea(contour[b]) < 6000)//300,4000  300,6000
                            {
                                double aspectratio = Convert.ToDouble(rect1.Width) / Convert.ToDouble(rect1.Height);
                                if (aspectratio < 1.30 && aspectratio > 0.75)//1.26,0.85   1.30,0.75
                                {
                                    if (rect1.Height > 28 && rect1.Height < 200 & rect1.Width < 300 && rect1.Width > 30)//30,200,300,30
                                    {
                                        OpenCvSharp.Rect hole_rect = new OpenCvSharp.Rect(rect1.X + roi3.X, rect1.Y + roi3.Y, rect1.Width, rect1.Height);
                                        Cv2.Rectangle(hole_crop, hole_rect, Scalar.LimeGreen, 5);
                                        Cv2.DrawContours(tempcrop, contour, b, Scalar.Blue, 3);
                                        Holecount++;
                                        Hole_absent = true;
                                        break;
                                    }

                                }

                            }

                        }
                        if (!Hole_absent == true)
                        {
                            OpenCvSharp.Rect hole_rect = new OpenCvSharp.Rect(875, 320, 195, 250);
                            Cv2.Rectangle(hole_crop, hole_rect, Scalar.Red, 5);

                        }
                        Hole_absent = false;
                        Cv2.NamedWindow("color2", WindowMode.AutoSize);
                        Cv2.ImShow("color2", tempcrop);
                    }
                    if (a == 3)
                    {
                        Mat tempcrop = new Mat(crop1, roi4);
                        if (Form3.start4 == true)
                        {
                            Cv2.Threshold(tempcrop, tempcrop, Form3.value4, 255, ThresholdTypes.Binary);
                            Form3.start4 = false;
                        }
                        else
                        {
                            Cv2.Threshold(tempcrop, tempcrop, 90, 255, ThresholdTypes.Binary);//60//98
                           
                        }
                        Cv2.Dilate(tempcrop, tempcrop, element1, null, 1);//1
                        Cv2.AdaptiveThreshold(tempcrop, tempcrop, 255, AdaptiveThresholdTypes.MeanC, ThresholdTypes.Binary, 75, 171); //71,171
                        Cv2.Erode(tempcrop, tempcrop, element1, null, 3);//4
                        Cv2.FindContours(tempcrop, out contour, out hier, RetrievalModes.Tree, ContourApproximationModes.ApproxSimple);
                        if (tempcrop.Channels() == 1)
                           Cv2.CvtColor(tempcrop, tempcrop, ColorConversionCodes.GRAY2BGR);
                       
                        for (int b = 0; b < contour.Length; b++)
                        {
                            rect1 = Cv2.BoundingRect(contour[b]);
                            if (Cv2.ContourArea(contour[b])>1000 && Cv2.ContourArea(contour[b]) < 4000)//1000,4000
                            {
                                double aspectratio = Convert.ToDouble(rect1.Width) / Convert.ToDouble(rect1.Height);
                                if (aspectratio > 0.40 && aspectratio < 1.40)//1.10 0.80 0.40,1.40
                                {
                                    if (rect1.Height > 30 && rect1.Height < 300 && rect1.Width >20 && rect1.Width < 200)//30,90,90,30  30,300,20,200
                                    {
                                        OpenCvSharp.Rect hole_rect = new OpenCvSharp.Rect(rect1.X + roi4.X, rect1.Y + roi4.Y, rect1.Width, rect1.Height);
                                        Cv2.Rectangle(hole_crop, hole_rect, Scalar.LimeGreen, 5);
                                        Cv2.DrawContours(tempcrop, contour, b, Scalar.Blue, 3);
                                        Holecount++;
                                        Hole_absent = true;
                                        break;
                                    }
                                }

                            }

                        }
                        if (!Hole_absent == true)
                        {
                            OpenCvSharp.Rect hole_rect = new OpenCvSharp.Rect(550, 800, 170, 200);
                            Cv2.Rectangle(hole_crop, hole_rect, Scalar.Red, 5);

                        }
                        Hole_absent = false;
                        Cv2.NamedWindow("color3", WindowMode.AutoSize);
                        Cv2.ImShow("color3", tempcrop);
                    }
                    hole_crop.CopyTo(finalimg);
                    //img_disp.Image = crop.ToBitmap();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
                log.Error("Error Message: " + Ex.Message.ToString(), Ex);
            }

        }
        private void Holes(Mat inimg)
        {
            try
            {
                Holecount = 0;
                Mat crop = new Mat();
                OpenCvSharp.Point[][] contour;
                HierarchyIndex[] hier;
                OpenCvSharp.Rect rect1 = new OpenCvSharp.Rect();
                OpenCvSharp.Size ksize = new OpenCvSharp.Size(3, 3);
                OpenCvSharp.Size kksize = new OpenCvSharp.Size(5, 5);
                Mat element = Cv2.GetStructuringElement(MorphShapes.Cross, ksize);
                Mat element1 = Cv2.GetStructuringElement(MorphShapes.Cross, kksize);
                inimg.CopyTo(crop);
                if (crop.Channels() > 1)
                    Cv2.CvtColor(crop, crop, ColorConversionCodes.BGR2GRAY);
                Cv2.GaussianBlur(crop, crop, kksize, 0, 0);
                Cv2.Threshold(crop, crop, 120, 255, ThresholdTypes.Binary);//130,255
                Cv2.AdaptiveThreshold(crop, crop, 255, AdaptiveThresholdTypes.GaussianC, ThresholdTypes.Binary, 67, 17);//67,17
                Cv2.MorphologyEx(crop, crop, MorphTypes.Close, element);

               

                Cv2.Erode(crop, crop, element1, null, 6);

                OpenCvSharp.Point pnt = new OpenCvSharp.Point(crop.Width / 2, crop.Height / 2 + 60);//50

                Cv2.Circle(crop, pnt, 280, Scalar.White, -1);
                
                List<int> list1 = new List<int>();
                Cv2.FindContours(crop, out contour, out hier, RetrievalModes.Tree, ContourApproximationModes.ApproxSimple);
                if (crop.Channels() == 1)
                {
                    Cv2.CvtColor(crop, crop, ColorConversionCodes.GRAY2BGR);
                }
                for (int a = 0; a < contour.Length; a++)
                {

                    rect1 = Cv2.BoundingRect(contour[a]);

                    if (Cv2.ContourArea(contour[a]) > 600 && Cv2.ContourArea(contour[a]) < 3000)  /*&& rect1.Height > 5 && rect1.Width > 30*/ /*&& rect1.Width > 30*/   //600,2500,20,70
                    {
                        double aspectratio = Convert.ToDouble(rect1.Width) / Convert.ToDouble(rect1.Height);
                        if (aspectratio > 1.02)
                        {
                            if (rect1.Height > 38 && rect1.Height < 100 && rect1.Width < 100 && rect1.Width > 38)//45,110,110,45
                            {
                                Cv2.DrawContours(crop, contour, a, Scalar.Blue, 3);
                                Holecount++;
                            }
                        }
                    }
                }
                Cv2.NamedWindow("color", WindowMode.FreeRatio);
                Cv2.ImShow("color", crop);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
                log.Error("Error Message: " + Ex.Message.ToString(), Ex);
            }

        }
       
        private void template_matching(Mat template, Mat n)
        {
            try
            {
                Mat master = new Mat();
                Mat match_output = new Mat();
                OpenCvSharp.Size kksize = new OpenCvSharp.Size(3,3);
                Mat element = Cv2.GetStructuringElement(MorphShapes.Cross, kksize);
                template.CopyTo(master);
                Mat train = new Mat();
                if (n.Channels() > 1)
                   Cv2.CvtColor(n, n, ColorConversionCodes.BGR2GRAY);
               
                n.CopyTo(train);
                Cv2.GaussianBlur(master, master, kksize,0,0);
                Mat result1 = new Mat();
                double minVal; double maxVal;
                OpenCvSharp.Point minLoc, maxLoc;
                int result1_cols = master.Cols - train.Cols + 1;
                int result1_rows = master.Rows - train.Rows + 1;
                result1.Create(result1_cols, result1_rows, MatType.CV_32FC1);
                Cv2.MatchTemplate(master, train, result1, TemplateMatchModes.CCoeffNormed);
                Cv2.MinMaxLoc(result1, out minVal, out maxVal, out minLoc, out maxLoc);
                matchLoc = maxLoc;
                min = minVal * 100;
                max = maxVal * 100;
                Cv2.NamedWindow("train", WindowMode.FreeRatio);
                Cv2.ImShow("train", train);
                res_loc = new OpenCvSharp.Point(matchLoc.X + train.Cols, matchLoc.Y + train.Rows);
                int mxi = Convert.ToInt32(matchLoc.X);
                int myi = Convert.ToInt32(matchLoc.Y);
                int rxi = Convert.ToInt32(res_loc.X);
                int ryi = Convert.ToInt32(res_loc.Y);
                int wi = rxi - mxi; int hei = ryi - myi;
                OpenCvSharp.Rect cro = new OpenCvSharp.Rect(mxi, myi, wi, hei);
                x = mxi;
                y = myi;
                rect2 = new OpenCvSharp.Rect(x, y, cro.Width, cro.Height);
                match_output = new Mat(master, rect2);
                match_output.CopyTo(resizeimg);
                //Cv2.ImWrite("resulttm" + ".bmp", resizeimg);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
                log.Error("Error Message: " + Ex.Message.ToString(), Ex);
            }
        }
        private void datetime_Tick(object sender, EventArgs e)
        {
            try
            {
                date_lbl.Text = DateTime.Now.ToShortDateString();
                time_lbl.Text = DateTime.Now.ToLongTimeString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
                log.Error("Error Message: " + Ex.Message.ToString(), Ex);
            }
        }
        private void imagegrabtimer_Tick(object sender, EventArgs e)
        {
            
            try
            {
                if (Form3.close == true)
                {
                    timer1.Enabled = false;
                    Form3.close = false;
                }
                bool[] data = plcmodule.ReadDiscreteInputs(1024, 1);
                draw = true;
                if (data[0] == true)
                {
                    plcmodule.WriteSingleCoil(1280, false);
                    plcmodule.WriteSingleCoil(1280, false);
                    // if (!capture.IsOpened())
                    //{
                    //capture.Open(0);
                    //}
                    //capture.Focus = 14;
                    Thread.Sleep(2000);
                    capture.FrameWidth = 1920;
                    capture.FrameHeight = 1080;
                    //for (int i = 0; i < 5; i++)
                    //{
                    //    if (capture.IsOpened())
                    //    {
                            capture.Read(Inputimg);
                    //    }
                    //}
                    framecount++;
                    Cv2.CvtColor(Inputimg, outimg, ColorConversionCodes.BGR2GRAY);
                   
                    img_disp.Image = outimg.ToBitmap();
                    img_disp.SizeMode = PictureBoxSizeMode.StretchImage;
                    frame_conut.Text = framecount.ToString();
                    Process_image();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("image is not good");
                MessageBox.Show(Ex.Message.ToString());
                log.Error("Error Message: " + Ex.Message.ToString(), Ex);
            }
        }
        private void redbot_logo_Click(object sender, EventArgs e)
        {

        }

        private void HEADING_LBL_Click(object sender, EventArgs e)
        {

        }

        private void img_disp_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
       
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            draw = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form3.start == true )
            {
                Process_image();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (click == 0)
            {
                MessageBox.Show("END");
            }
            else
            {
                string path = files[--click].FullName;
                outimg = Cv2.ImRead(path);
             Process_image(); //Image Processing starts  

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (click == files.Length)
            {
                MessageBox.Show("END");
            }
            else
            {
                string path = files[click++].FullName;
                outimg = Cv2.ImRead(path);

                Process_image(); //Image Processing starts  

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                button6.Enabled = true;
                button7.Enabled = true;
                string path_textBox = folderBrowserDialog1.SelectedPath;
                DirectoryInfo folder = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                files = folder.GetFiles();
                string path = files[click++].FullName;
                outimg = Cv2.ImRead(path);

                Process_image();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void result_lbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Width = 781;
            this.Height = 383;
            label1.Width = this.Width;
            label1.Height = this.Height;
            Form2 count_form = new Form2();
            count_form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            this.Width = 781;
            this.Height = 383;
            label1.Width = this.Width;
            label1.Height = this.Height;
            Form3 adjust_window = new Form3();
            adjust_window.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void img_path_TextChanged(object sender, EventArgs e)
        {

        }

    
        private void log_images_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

   

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void white_pixel_TextChanged(object sender, EventArgs e)
        {

        }

        private void black_pixel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_threshold_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Leave(object sender, EventArgs e)
        {

        }

       
        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }
        private void start_btn_EnabledChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GPL_application
{
    /// <summary>
    /// the main form_main class
    /// </summary>
    public partial class Form_main : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        /// <summary>
        /// main Form_main() method
        /// </summary>
        public Form_main()
        {
            InitializeComponent();
            label_thic_err.Visible = false;
            int x_canvas = pictureBox_canvas.Width / 2;
            int y_canvas = pictureBox_canvas.Height / 2;
            label_can_x.Text = x_canvas.ToString();
            label_can_y.Text = y_canvas.ToString();
            g = pictureBox_canvas.CreateGraphics();

        }
        //initializing the pen color as black
        Color pcolor = Color.Black;
        bool pens = false;
        Graphics g;

        //nullable int for storing Null value
        int? initX = null;
        int? initY = null;

        private void Form_main_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form_main_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form_main_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pictureBox_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_canvas_MouseMove(object sender, MouseEventArgs e)
        {
            //displaying the mouse coordinates for location inside the drawing space
            MouseEventArgs me = (MouseEventArgs)e;
            Point coords = me.Location;
            label_mouse_pos.Text = coords.ToString();
            try
            {
                if (Convert.ToInt16(textBox_thickness.Text) >= 1 && (Convert.ToInt16(textBox_thickness.Text) <= 200))
                {
                    label_thic_err.Visible = false;
                    if (pens == true && radioButton_pen.Checked)
                    {
                        //setting the pen color and line width
                        Pen p = new Pen(button_pen_color.BackColor, float.Parse(textBox_thickness.Text));
                        //Drawing line
                        g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                        initX = e.X;
                        initY = e.Y;
                    }
                }
                else
                    label_thic_err.Visible = true;
            }
            catch (Exception ex)
            {
            }
        }

        private void button_pen_color_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            //pcolor = c.Color;
            if (c.ShowDialog() == DialogResult.OK)
            {
                button_pen_color.BackColor = c.Color;
            }
        }

        private void pictureBox_canvas_MouseDown(object sender, MouseEventArgs e)
        {
            pens = true;
            if (radioButton_rec.Checked)
            {
                //Pen p = new Pen(button_pen_color.BackColor, float.Parse(textBox_thickness.Text));
                TextureBrush textb = new TextureBrush(pictureBox_texture.Image);
                textb.WrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
                g.FillRectangle(textb, e.X, e.Y, 2 * int.Parse(textBox_thickness.Text), int.Parse(textBox_thickness.Text));
                //setting pens value to false for creating one graphic on one click.
                pens = false;
            }
            if (radioButton_cir.Checked)
            {
                //SolidBrush sb = new SolidBrush(button_pen_color.BackColor);
                //Pen p = new Pen(button_pen_color.BackColor, float.Parse(textBox_thickness.Text));
                //g.DrawEllipse(p, e.X, e.Y, int.Parse(textBox_thickness.Text), int.Parse(textBox_thickness.Text));
                TextureBrush textb = new TextureBrush(pictureBox_texture.Image);
                textb.WrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
                g.FillEllipse (textb, e.X, e.Y, int.Parse(textBox_thickness.Text)*2, int.Parse(textBox_thickness.Text)*2);
                //setting pens value to false for creating one graphic on one click.
                pens = false;
            }
            
            
        }

        private void pictureBox_canvas_MouseUp(object sender, MouseEventArgs e)
        {
            pens = false;
            initX = null;
            initY = null;
        }

        private void button_clear_can_Click(object sender, EventArgs e)
        {
            pictureBox_canvas.Image = null;
            initX = null;
            initY = null;
        }

        private void richTextBox_comm_TextChanged(object sender, EventArgs e)
        {
            //color coding the text displayed in rich text box
            string[] comms1 = new string[] { "rectangle", "circle", "line","triangle","polygon" };
            string[] comms2 = new string[] { "drawto","moveto","repeat","radius" };
            foreach (string str in comms1)
            {
                Regex rx = new Regex(str);
                int index = richTextBox_comm.SelectionStart;
                foreach (Match m in rx.Matches(richTextBox_comm.Text))
                {
                    richTextBox_comm.Select(m.Index, m.Value.Length);
                    richTextBox_comm.SelectionColor = Color.LimeGreen;
                    richTextBox_comm.SelectionStart = index;
                    richTextBox_comm.SelectionColor = Color.White;
                }
            }
            foreach (string str in comms2)
            {
                Regex rx = new Regex(str);
                int index = richTextBox_comm.SelectionStart;
                foreach (Match m in rx.Matches(richTextBox_comm.Text))
                {
                    richTextBox_comm.Select(m.Index, m.Value.Length);
                    richTextBox_comm.SelectionColor = Color.Gold;
                    richTextBox_comm.SelectionStart = index;
                    richTextBox_comm.SelectionColor = Color.White;
                }
            }
        }


        public int size1, size2, size3, size4, size5, size6, size7, size8, size9, size10, size11, size12;

        private void button_texture_br_Click(object sender, EventArgs e)
        {
            OpenFileDialog opens = new OpenFileDialog();
            //opens.Filter = "BMP Image|.bmp|All Files|*.*";
            if (opens.ShowDialog() == DialogResult.OK)
            {
                pictureBox_texture.Image = Image.FromFile(opens.FileName);
            }
        }

        private void button_save_pic_Click(object sender, EventArgs e)
        {
            //pictureBox_canvas.Image.S
            Bitmap bmp = new Bitmap(pictureBox_canvas.Width, pictureBox_canvas.ClientSize.Height);
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Bitmap image|*.bmp";
            if(save.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(save.FileName);
            }
        }

        private void button_load_scr_Click(object sender, EventArgs e)
        {
            OpenFileDialog opens = new OpenFileDialog();
            if (opens.ShowDialog() == DialogResult.OK)
            {
                //richTextBox_comm.LoadFile(opens.ToString());
                string[] readtext = File.ReadAllLines(opens.FileName);
                richTextBox_comm.LoadFile(opens.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        public int xi1, yi1, xi2, yi2, xii1, yii1, xii2, yii2, xiii1, yiii1, xiii2, yiii2;

        private void button_save_scr_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Text Files|.txt|All Files|*.*";
            if(sv.ShowDialog() == DialogResult.OK)
            {
                richTextBox_comm.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);
                this.Text = sv.FileName;
            }
        }

        private void button_log_clear_Click(object sender, EventArgs e)
        {
            richTextBox_output.Text = "";
        }

        private void button_clear_comm_Click(object sender, EventArgs e)
        {
            richTextBox_comm.Text = "";
        }

        private void button_run_Click(object sender, EventArgs e)
        {
            try
            {
                //using regex to recognize commands along with their variables
                Regex regexmoveto = new Regex(@"moveto (.*[\d])([,])(.*[\d])");

                //for drawto
                Regex regex_drawtoline = new Regex(@"drawto (.*[\d])([,])(.*[\d]) line (.*[\d])([,])(.*[\d])");
                Regex regex_drawtorec = new Regex(@"drawto (.*[\d])([,])(.*[\d]) rectangle (.*[\d])([,])(.*[\d])");
                Regex regex_drawtocir = new Regex(@"drawto (.*[\d])([,])(.*[\d]) circle (.*[\d])");
                Regex regex_drawtotri = new Regex(@"drawto (.*[\d])([,])(.*[\d]) triangle (.*[\d])([,])(.*[\d])([,])(.*[\d])");
                Regex regex_drawtopol = new Regex(@"drawto (.*[\d])([,])(.*[\d]) polygon (.*[\d])([,])(.*[\d]) (.*[\d])([,])(.*[\d]) (.*[\d])([,])(.*[\d]) (.*[\d])([,])(.*[\d]) (.*[\d])([,])(.*[\d])");

                //for without drawto
                Regex regex_line = new Regex(@"line (.*[\d])([,])(.*[\d])");
                Regex regex_rec = new Regex(@"rectangle (.*[\d])([,])(.*[\d])");
                Regex regex_cir = new Regex(@"circle (.*[\d])");
                Regex regex_tri = new Regex(@"triangle (.*[\d])([,])(.*[\d])([,])(.*[\d])");
                Regex regex_pol = new Regex(@"polygon (.*[\d])([,])(.*[\d]) (.*[\d])([,])(.*[\d]) (.*[\d])([,])(.*[\d]) (.*[\d])([,])(.*[\d]) (.*[\d])([,])(.*[\d])");

                //Regex regex_repeat_c = new Regex(@"repeat (.*[\d]) circle radius ");
                Regex regex_repeat_c = new Regex(@"repeat (.*[\d])");

                //for moveto command

                Match matchmoveto = regexmoveto.Match(richTextBox_comm.Text.ToLower());
                Match matchdrawtoline = regex_drawtoline.Match(richTextBox_comm.Text.ToLower());
                Match matchdrawtorec = regex_drawtorec.Match(richTextBox_comm.Text.ToLower());
                Match matchdrawtocir = regex_drawtocir.Match(richTextBox_comm.Text.ToLower());
                Match matchdrawtotri = regex_drawtotri.Match(richTextBox_comm.Text.ToLower());
                Match matchdrawtopol = regex_drawtopol.Match(richTextBox_comm.Text.ToLower());

                Match matchline = regex_line.Match(richTextBox_comm.Text.ToLower());
                Match matchrec = regex_rec.Match(richTextBox_comm.Text.ToLower());
                Match matchcir = regex_cir.Match(richTextBox_comm.Text.ToLower());
                Match matchtri = regex_tri.Match(richTextBox_comm.Text.ToLower());
                Match matchpol = regex_pol.Match(richTextBox_comm.Text.ToLower());
                Match matchrepeat_c = regex_repeat_c.Match(richTextBox_comm.Text.ToLower());
                //Match regexdrawto = Regex.Match(richTextBox_comm.Text, @"drawto (.*[\d])([,])(.*[\d])", RegexOptions.Multiline);

                if (matchdrawtoline.Success)
                {
                    g = pictureBox_canvas.CreateGraphics();
                    size1 = int.Parse(matchdrawtoline.Groups[1].Value);
                    size2 = int.Parse(matchdrawtoline.Groups[3].Value);
                    size3 = int.Parse(matchdrawtoline.Groups[4].Value);
                    size4 = int.Parse(matchdrawtoline.Groups[6].Value);
                    try
                    {
                       
                    }
                    catch (Exception ex)
                    {
                        richTextBox_output.AppendText("drawtoline error: " + ex.Message + Environment.NewLine);
                    }
                }
                else if (matchdrawtorec.Success)
                {
                    g = pictureBox_canvas.CreateGraphics();
                    size1 = int.Parse(matchdrawtorec.Groups[1].Value);
                    size2 = int.Parse(matchdrawtorec.Groups[3].Value);
                    size3 = int.Parse(matchdrawtorec.Groups[4].Value);
                    size4 = int.Parse(matchdrawtorec.Groups[6].Value);
                    try
                    {
                        
                    }
                    catch (Exception ex)
                    {
                        richTextBox_output.AppendText("drawtorec error: " + ex.Message + Environment.NewLine);
                    }
                }
                else if (matchdrawtocir.Success)
                {
                    g = pictureBox_canvas.CreateGraphics();
                    size1 = int.Parse(matchdrawtocir.Groups[1].Value);
                    size2 = int.Parse(matchdrawtocir.Groups[3].Value);
                    size3 = int.Parse(matchdrawtocir.Groups[4].Value);
                    try
                    {
                        
                    }
                    catch (Exception ex)
                    {
                        richTextBox_output.AppendText("drawtocir error: " + ex.Message + Environment.NewLine);
                    }
                }
                else if (matchdrawtotri.Success)
                {
                    g = pictureBox_canvas.CreateGraphics();
                    size1 = int.Parse(matchdrawtotri.Groups[1].Value);
                    size2 = int.Parse(matchdrawtotri.Groups[3].Value);
                    size3 = int.Parse(matchdrawtotri.Groups[4].Value);
                    size4 = int.Parse(matchdrawtotri.Groups[6].Value);
                    size5 = int.Parse(matchdrawtotri.Groups[8].Value);
                    //size6 = int.Parse(matchdrawtotri.Groups[11].Value);
                    //size7 = int.Parse(matchdrawtotri.Groups[13].Value);

                    xi1 = size1;
                    yi1 = size2;
                    xi2 = size3;
                    yi2 = size2;

                    xii1 = size1;
                    yii1 = size2;
                    xii2 = size1;
                    yii2 = size4;

                    xiii1 = size3;
                    yiii1 = size2;
                    xiii2 = size1;
                    yiii2 = size4;

                    try
                    {
                        
                    }
                    catch (Exception ex)
                    {
                        richTextBox_output.AppendText("drawtotri error: " + ex.Message + Environment.NewLine);
                    }
                }
                else if (matchdrawtopol.Success)
                {
                    g = pictureBox_canvas.CreateGraphics();
                    size1 = int.Parse(matchdrawtopol.Groups[1].Value);
                    size2 = int.Parse(matchdrawtopol.Groups[3].Value);
                    size3 = int.Parse(matchdrawtopol.Groups[4].Value);
                    size4 = int.Parse(matchdrawtopol.Groups[6].Value);
                    size5 = int.Parse(matchdrawtopol.Groups[7].Value);
                    size6 = int.Parse(matchdrawtopol.Groups[9].Value);
                    size7 = int.Parse(matchdrawtopol.Groups[10].Value);
                    size8 = int.Parse(matchdrawtopol.Groups[12].Value);
                    size9 = int.Parse(matchdrawtopol.Groups[13].Value);
                    size10 = int.Parse(matchdrawtopol.Groups[15].Value);
                    size11 = int.Parse(matchdrawtopol.Groups[16].Value);
                    size12 = int.Parse(matchdrawtopol.Groups[18].Value);

                    try
                    {
                        
                    }
                    catch (Exception ex)
                    {
                        richTextBox_output.AppendText("drawtopol error: " + ex.Message + Environment.NewLine);
                    }
                }
                else if (matchline.Success)
                {
                    g = pictureBox_canvas.CreateGraphics();
                    size1 = int.Parse(label_can_x.Text);
                    size2 = int.Parse(label_can_y.Text);
                    size3 = int.Parse(matchline.Groups[1].Value);
                    size4 = int.Parse(matchline.Groups[3].Value);
                    try
                    {
                        
                    }
                    catch (Exception ex)
                    {
                        richTextBox_output.AppendText("line error: " + ex.Message + Environment.NewLine);
                    }
                }
                else if (matchrec.Success)
                {
                    g = pictureBox_canvas.CreateGraphics();
                    size1 = int.Parse(label_can_x.Text);
                    size2 = int.Parse(label_can_y.Text);
                    size3 = int.Parse(matchrec.Groups[1].Value);
                    size4 = int.Parse(matchrec.Groups[3].Value);
                    try
                    {
                        
                    }
                    catch (Exception ex)
                    {
                        richTextBox_output.AppendText("rec error: " + ex.Message + Environment.NewLine);
                    }
                }
                else if (matchcir.Success)
                {
                    g = pictureBox_canvas.CreateGraphics();
                    size1 = int.Parse(label_can_x.Text);
                    size2 = int.Parse(label_can_y.Text);
                    size3 = int.Parse(matchcir.Groups[1].Value);
                    try
                    {
                        
                    }
                    catch (Exception ex)
                    {
                        richTextBox_output.AppendText("cir error: " + ex.Message + Environment.NewLine);
                    }
                }
                else if (matchtri.Success)
                {
                    g = pictureBox_canvas.CreateGraphics();
                    size1 = int.Parse(label_can_x.Text);
                    size2 = int.Parse(label_can_y.Text);
                    size3 = int.Parse(matchdrawtotri.Groups[1].Value);
                    size4 = int.Parse(matchdrawtotri.Groups[3].Value);
                    size5 = int.Parse(matchdrawtotri.Groups[4].Value);
                    //size6 = int.Parse(matchdrawtotri.Groups[11].Value);
                    //size7 = int.Parse(matchdrawtotri.Groups[13].Value);

                    xi1 = size1;
                    yi1 = size2;
                    xi2 = size3;
                    yi2 = size2;

                    xii1 = size1;
                    yii1 = size2;
                    xii2 = size1;
                    yii2 = size4;

                    xiii1 = size3;
                    yiii1 = size2;
                    xiii2 = size1;
                    yiii2 = size4;

                    try
                    {
                        
                    }
                    catch (Exception ex)
                    {
                        richTextBox_output.AppendText("drawtotri error: " + ex.Message + Environment.NewLine);
                    }
                }
                else if (matchpol.Success)
                {
                    g = pictureBox_canvas.CreateGraphics();
                    size1 = int.Parse(matchdrawtopol.Groups[1].Value);
                    size2 = int.Parse(matchdrawtopol.Groups[3].Value);
                    size3 = int.Parse(matchdrawtopol.Groups[5].Value);
                    size4 = int.Parse(matchdrawtopol.Groups[7].Value);
                    size5 = int.Parse(matchdrawtopol.Groups[9].Value);
                    size6 = int.Parse(matchdrawtopol.Groups[11].Value);
                    size7 = int.Parse(matchdrawtopol.Groups[13].Value);
                    size8 = int.Parse(matchdrawtopol.Groups[15].Value);
                    size9 = int.Parse(matchdrawtopol.Groups[17].Value);
                    size10 = int.Parse(matchdrawtopol.Groups[19].Value);
                    size11 = int.Parse(matchdrawtopol.Groups[21].Value);
                    size12 = int.Parse(matchdrawtopol.Groups[23].Value);

                    try
                    {
                       
                    }
                    catch (Exception ex)
                    {
                        richTextBox_output.AppendText("drawtopol error: " + ex.Message + Environment.NewLine);
                    }
                }
                else if (matchmoveto.Success)
                {
                    size1 = int.Parse(matchmoveto.Groups[1].Value);
                    size2 = int.Parse(matchmoveto.Groups[3].Value);
                    int sx = pictureBox_canvas.Width;
                    int sy = pictureBox_canvas.Height;
                    if (size1 >= 0 && size2 >= 0 && size1 <= sx && size2 <= sy)
                    {
                        label_can_x.Text = size1.ToString();
                        label_can_y.Text = size2.ToString();
                        richTextBox_output.AppendText("Pointer moved to " + size1 + "," + size2 + Environment.NewLine);
                    }
                    else
                    {
                        richTextBox_output.AppendText("moveto error! Please input value between 0,0 and " + sx + "," + sy + Environment.NewLine);
                    }
                }
                else if (matchrepeat_c.Success)
                {
                    int repeatno = int.Parse(matchrepeat_c.Groups[1].Value);
                    Regex regexRepCircle = new Regex(@"cir radius (.*[\d])");
                    Match matchRepCircle = regexRepCircle.Match(richTextBox_comm.Text.ToLower());

                    if (matchRepCircle.Success)
                    {
                        int repeatAdd = 0;
                        size1 = int.Parse(label_can_x.Text);
                        size2 = int.Parse(label_can_y.Text);
                        size3 = 10;
                        repeatAdd = int.Parse(matchRepCircle.Groups[1].Value);


                        

                        for (int i = 0; i < repeatno; i++)
                        {

                            

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private int nguoiA = 160;
        private int nguoiB = 130;
        private int nguoiC = 120;
        private int nguoiD = 120;
        private int nguoiE = 140;
        private int nguoiF = 140;
        
        TimeSpan tg;
        TimeSpan tgs2;
        TimeSpan tgs3;
        TimeSpan tgs4;
        TimeSpan tgs5;
        TimeSpan tgs6;
        TimeSpan tgs7;
        int md1 = 10000;
        int md2 = 15000;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }
        public void goithoi()
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();
            timer6.Start();
            
        }
        
        
        public void lbgoitg()
        {
            tg = new TimeSpan(0);
            lbtg.Text = "Thời Gian:";
            tgs2 = new TimeSpan(0);
            tg2.Text = "Thời Gian:";
            tgs3 = new TimeSpan(0);
            tg3.Text = "Thời Gian:";
            tgs4 = new TimeSpan(0);
            tg4.Text = "Thời Gian:";
            tgs5 = new TimeSpan(0);
            tg55.Text = "Thời Gian:";
            tgs6 = new TimeSpan(0);
            tg6.Text = "Thời Gian:";

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = false;
            button5.Enabled = false;
            //danh sách ẩn ảnh
            anh1.Visible = false;
            anh2.Visible = false;
            anh3.Visible = false;
            anh4.Visible = false;
            anh5.Visible = false;
            anh6.Visible = false;
            //text ẩn thời gian
            lbtg.Visible = false;
            tg2.Visible = false;
            tg3.Visible = false;
            tg4.Visible = false;
            tg55.Visible = false;
            tg6.Visible = false;
            /// tới ai sẽ tô màu khung người dods
            /// 
            anh1.BorderStyle = BorderStyle.FixedSingle;
            anh2.BorderStyle = BorderStyle.FixedSingle;
            anh3.BorderStyle = BorderStyle.FixedSingle;
            anh4.BorderStyle = BorderStyle.FixedSingle;
            anh5.BorderStyle = BorderStyle.FixedSingle;
            anh6.BorderStyle = BorderStyle.FixedSingle;
        }

        private void cnx_ng_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cbx_ng.SelectedIndex== 0)
            {
                anh1.Visible = true;
                lbtg.Visible = true;
            }
            if (cbx_ng.SelectedIndex == 1)
            {
                anh1.Visible = true;
                anh2.Visible = true;
                lbtg.Visible = true;
                tg2.Visible = true;
            }
            if (cbx_ng.SelectedIndex == 2)
            {
                anh1.Visible = true;
                anh2.Visible = true;
                anh3.Visible = true;
                lbtg.Visible = true;
                tg2.Visible = true;
                tg3.Visible = true;
            }
            if (cbx_ng.SelectedIndex == 3)
            {
                anh1.Visible = true;
                anh2.Visible = true;
                anh3.Visible = true;
                anh4.Visible = true;
                lbtg.Visible = true;
                tg2.Visible = true;
                tg3.Visible = true;
                tg4.Visible = true;
            }
            if (cbx_ng.SelectedIndex == 4)
            {
                anh1.Visible = true;
                anh2.Visible = true;
                anh3.Visible = true;
                anh4.Visible = true;
                anh5.Visible = true;
                lbtg.Visible = true;
                tg2.Visible = true;
                tg3.Visible = true;
                tg4.Visible = true;
                tg55.Visible = true;
            }
            if (cbx_ng.SelectedIndex == 5)
            {
                anh1.Visible = true;
                anh2.Visible = true;
                anh3.Visible = true;
                anh4.Visible = true;
                anh5.Visible = true;
                anh6.Visible = true;
                lbtg.Visible = true;
                tg2.Visible = true;
                tg3.Visible = true;
                tg4.Visible = true;
                tg55.Visible = true;
                tg6.Visible = true;
            }
            cbx_ng.Visible = false;
            label2.Visible = false;
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_md.SelectedIndex == 0)
            {
                mondo.Visible = true;
                mondo1.Visible = false;
                gtmd2.Visible = true;
                gtmd1.Visible = false;
                this.gtang.Text = "100000";
            }
            if (cbx_md.SelectedIndex == 1)
            {
                mondo.Visible = false;
                mondo1.Visible = true;
                gtmd2.Visible = false;
                gtmd1.Visible = true;
                this.gtang.Text = "150000";
            }
            cbx_md.Visible = false;
            label4.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button6.Enabled = true;
            button5.Enabled = true;
            goithoi();
            lbtg.Text = nguoiA.ToString();
            tg2.Text = nguoiB.ToString();
            tg3.Text = nguoiC.ToString();
            tg4.Text = nguoiD.ToString();
            tg55.Text = nguoiE.ToString();
            tg6.Text = nguoiF.ToString();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {

            nguoiA--;
            if (nguoiA == 0)
            {
                timer1.Stop();
                MessageBox.Show("Người A là người chiến thắng trong phiên bảng đấu giá");
            }
            lbtg.Text = nguoiA.ToString(); ;
            
            //tg = tg.Add(new TimeSpan(0, 0, 1));
            //lbtg.Text = string.Format("Thời Gian: {0:00}:{1:00}:{2:00}", tg.Hours, tg.Minutes, tg.Seconds);
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            nguoiB--;
            if (nguoiB == 0)
            {
                timer2.Stop();
                
            }
            tg2.Text = nguoiB.ToString();
            //tgs2 = tgs2.Add(new TimeSpan(0, 0, 1));
            //tg2.Text = string.Format("Thời Gian: {0:00}:{1:00}:{2:00}", tg.Hours, tg.Minutes, tg.Seconds);
                  
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            nguoiC--;
            if (nguoiC == 0)
            {
                timer3.Stop();
                
            }
            tg3.Text = nguoiC.ToString();
            //tgs3 = tgs3.Add(new TimeSpan(0, 0, 1));
            //tg3.Text = string.Format("Thời Gian: {0:00}:{1:00}:{2:00}", tg.Hours, tg.Minutes, tg.Seconds);
                    
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            nguoiD--;
            if (nguoiD == 0)
            {
                timer4.Stop();
                
            }
            tg4.Text = nguoiD.ToString();
            //tgs4 = tgs4.Add(new TimeSpan(0, 0, 1));
            //tg4.Text = string.Format("Thời Gian: {0:00}:{1:00}:{2:00}", tg.Hours, tg.Minutes, tg.Seconds);
                   
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            nguoiF--;
            if (nguoiF == 0)
            {
                timer5.Stop();
                
            }
            tg55.Text = nguoiF.ToString();
            //tgs5 = tgs5.Add(new TimeSpan(0, 0, 1));
            //tg55.Text = string.Format("Thời Gian: {0:00}:{1:00}:{2:00}", tg.Hours, tg.Minutes, tg.Seconds);
            
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            nguoiE--;
            if (nguoiE == 0)
            {
                timer6.Stop();
                
            }
            tg6.Text = nguoiE.ToString();
            //tgs6 = tgs6.Add(new TimeSpan(0, 0, 1));
            //tg6.Text = string.Format("Thời Gian: {0:00}:{1:00}:{2:00}", tg.Hours, tg.Minutes, tg.Seconds);
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            //nguoiE--;
            //if (nguoiE == 0)
            //{
            //    timer1.Stop();
            //    lbtg.Text = nguoiA.ToString();
            //}
            //tgs7 = tgs7.Add(new TimeSpan(0, 0, 1));
            //tgkt.Text = string.Format("Thời Gian: {0:00}:{1:00}:{2:00}", tg.Hours, tg.Minutes, tg.Seconds);
           
        }
       
        public void nhan()
        {
            int kq = md1 * 3;
            timer2.Stop();
            gtang.Text = kq.ToString(); ;
        }
        private void button2_Click(object sender, EventArgs e)
        {

            int kq = Convert.ToInt32(gtang.Text);
            int kq2 = kq * 3;
            gtang.Text = kq2.ToString(); ;
            
        }
        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void button2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void button2_TabIndexChanged(object sender, EventArgs e)
        {
    
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kq = Convert.ToInt32(gtang.Text);
            int kq2 = kq + 50000;
           
            gtang.Text = kq2.ToString(); ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kq = Convert.ToInt32(gtang.Text);
            int kq2 = kq + 10000;
            
            gtang.Text = kq2.ToString(); ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int kq = Convert.ToInt32(gtang.Text);
            int kq2 = kq + 50000;
            
            gtang.Text = kq2.ToString(); ;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int kq = Convert.ToInt32(gtang.Text);
            int kq2 = kq *2;
            
            gtang.Text = kq2.ToString(); ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int kq = Convert.ToInt32(gtang.Text);
            int kq2 = kq * 3/2;
            
            gtang.Text = kq2.ToString(); 
        }

       

       
    }
}

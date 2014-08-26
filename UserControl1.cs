using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trackBar
{
    public partial class statusBar: UserControl
    {
        public statusBar()
        {
            InitializeComponent();
            fonLoad();
            this.Dock = DockStyle.Bottom;
            this.ResizeRedraw = false;
            this.AutoSize = true;
            this.lblKeys.Text = "";
            

        }


        enum tuslar { tNumlock, tUpperCase, tSmallCase, tInsert, tNone}
        tuslar basilanTus = tuslar.tNone;


        protected void fonLoad()
        {
            if (!timer1.Enabled)
            {
                timer1.Enabled = true;                
            }
            
        }


        private void statusBar_Load(object sender, EventArgs e)
        {
            basilanTus = tuslar.tNone;
        }


        private void saatOlaylari()
        {
            string hh = "", mm = "", ss = "";
            string dd = "", yyyy = "", mon = "";
            string saat ="", tarih ="";

            if (DateTime.Now.Hour.ToString().Length < 2)
                hh = "0" + DateTime.Now.Hour.ToString();
            else
                hh = DateTime.Now.Hour.ToString();

            if (DateTime.Now.Minute.ToString().Length < 2)
                mm = "0" + DateTime.Now.Minute.ToString();
            else
                mm = DateTime.Now.Minute.ToString();

            if (DateTime.Now.Second.ToString().Length < 2)
                ss = "0" + DateTime.Now.Second.ToString();
            else
                ss = DateTime.Now.Second.ToString();


            if (DateTime.Now.Day.ToString().Length < 2)
                dd = "0" + DateTime.Now.Day.ToString();
            else
                dd = DateTime.Now.Day.ToString();

            if (DateTime.Now.Month.ToString().Length < 2)
                mon = "0" + DateTime.Now.Month.ToString();
            else
                mon = DateTime.Now.Month.ToString();

            yyyy = DateTime.Now.Year.ToString();

            saat = hh + ":" + mm + ":" + ss;
            tarih = dd +":" + mon + ":" + yyyy;

            this.lblSaat.Text = saat;
            this.lblTarih.Text = tarih;

        }


        //void fKlavye()
        //{
        //    switch (basilanTus)
        //    {
        //        case tuslar.tNumlock:
        //            lblKeys.Text = "Num";
        //            break;
        //        case tuslar.tUpperCase:
        //            lblKeys.Text = "Ucase";
        //            break;
        //        case tuslar.tSmallCase:
        //            lblKeys.Text = "";
        //            break;
        //        case tuslar.tInsert:
        //            lblKeys.Text = "Ins";
        //            break;
        //        case tuslar.tNone:
        //            lblKeys.Text = "";
        //            break;
        //        default:
        //            lblKeys.Text = "";
        //            break;
        //    }

        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            saatOlaylari();
            //fKlavye();
        }

        private void statusBar_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                
                case Keys.CapsLock:
                    basilanTus = tuslar.tUpperCase;
                    break;

                case Keys.Insert:
                    basilanTus = tuslar.tInsert;
                    break;
                
                case Keys.NumLock:
                    basilanTus = tuslar.tNumlock;
                    break;

                default:
                    basilanTus = tuslar.tNone;
                    break;
            }


        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tunç Güleç \ntuncgulec@gmail.com"  );
        }

        

    }
}

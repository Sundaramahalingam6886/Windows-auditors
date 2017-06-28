using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Model
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sid = 1;
            int eid = 12;
            int totalauditors = 92;
            string schedule = "";
            for (int week = 1; week <= 12; week++)
            {
                schedule = sid + "-" + eid;

                if ((sid + 12) > totalauditors)
                {
                    int sid2 = 1;
                    int eid2 = eid - totalauditors;

                    schedule = sid + "-" + totalauditors;
                    schedule = schedule + "," + sid2 + "-" + eid2;
                    sid = eid2 + 1;
                    eid = sid + 11;
                }
                else
                {
                    sid = sid + 12;
                    eid = eid + 12;
                }
                schedule = "week :" + week + "=" + schedule;
                listBox1.Items.Add(schedule);
            }
        }
    }
}
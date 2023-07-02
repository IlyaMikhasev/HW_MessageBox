using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_MessageBox
{
    
    public partial class Form1 : Form
    {
        MessageBoxButtons _buttons ;
        MessageBoxIcon icon;
        Color[] _colors = {Color.White, Color.IndianRed, Color.LightGreen, Color.LightBlue };
        Random random = new Random();
        int i = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void rb_color_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void SelectedButtons(string item) {
            switch (item)
            {
                case "AbortRetryIgnore": _buttons = MessageBoxButtons.AbortRetryIgnore; break;
                case "OK": _buttons = MessageBoxButtons.OK; break;
                case "OKCancel": _buttons= MessageBoxButtons.OKCancel; break;
                case "RetryCancel": _buttons = MessageBoxButtons.RetryCancel; break;
                case "YesNo": _buttons = MessageBoxButtons.YesNo; break;
                case "YesNoCancel": _buttons = MessageBoxButtons.YesNoCancel; break;
                default: _buttons = MessageBoxButtons.OK; break;
            }
        
        }
        private void cb_button_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedButtons(cb_button.SelectedItem.ToString());
        }

        private void b_MBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tb_message.Text, "test", _buttons,icon);
        }
        private void SelectedIcon(string item) {
            switch (item)
            {
                case "warnning": icon = MessageBoxIcon.Warning; break;
                case "stop": icon = MessageBoxIcon.Stop; break;
                case "quest": icon = MessageBoxIcon.Question; break;
                case "information": icon= MessageBoxIcon.Information; break;
                default: icon = MessageBoxIcon.None; break;
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIcon(listBox1.SelectedItem.ToString());
        }

        private void rb_red_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.IndianRed;
        }

        private void rb_green_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor= Color.LightGreen;
        }

        private void rb_blue_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor= Color.LightBlue;
        }
        private void chb_rgb_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_rgb.Checked){
                timer1.Start();
                
            }
            else
                timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            if (i == _colors.Length )
                i = 0;            
            this.BackColor = _colors[i++];
        }
    }
}

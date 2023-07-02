namespace HW_MessageBox
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.l_messageText = new System.Windows.Forms.Label();
            this.l_countButton = new System.Windows.Forms.Label();
            this.cb_button = new System.Windows.Forms.ComboBox();
            this.l_icon = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.l_color = new System.Windows.Forms.Label();
            this.b_MBox = new System.Windows.Forms.Button();
            this.chb_rgb = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_red = new System.Windows.Forms.RadioButton();
            this.rb_green = new System.Windows.Forms.RadioButton();
            this.rb_blue = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_message
            // 
            this.tb_message.Location = new System.Drawing.Point(147, 41);
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(185, 20);
            this.tb_message.TabIndex = 0;
            // 
            // l_messageText
            // 
            this.l_messageText.AutoSize = true;
            this.l_messageText.Location = new System.Drawing.Point(19, 41);
            this.l_messageText.Name = "l_messageText";
            this.l_messageText.Size = new System.Drawing.Size(97, 13);
            this.l_messageText.TabIndex = 1;
            this.l_messageText.Text = "Текст сообщения";
            // 
            // l_countButton
            // 
            this.l_countButton.AutoSize = true;
            this.l_countButton.Location = new System.Drawing.Point(22, 88);
            this.l_countButton.Name = "l_countButton";
            this.l_countButton.Size = new System.Drawing.Size(74, 13);
            this.l_countButton.TabIndex = 2;
            this.l_countButton.Text = "Кнопки MBox";
            // 
            // cb_button
            // 
            this.cb_button.FormattingEnabled = true;
            this.cb_button.Items.AddRange(new object[] {
            "AbortRetryIgnore",
            "OK",
            "OKCancel",
            "RetryCancel",
            "YesNo",
            "YesNoCancel"});
            this.cb_button.Location = new System.Drawing.Point(147, 88);
            this.cb_button.Name = "cb_button";
            this.cb_button.Size = new System.Drawing.Size(185, 21);
            this.cb_button.TabIndex = 3;
            this.cb_button.SelectedIndexChanged += new System.EventHandler(this.cb_button_SelectedIndexChanged);
            // 
            // l_icon
            // 
            this.l_icon.AutoSize = true;
            this.l_icon.Location = new System.Drawing.Point(22, 133);
            this.l_icon.Name = "l_icon";
            this.l_icon.Size = new System.Drawing.Size(75, 13);
            this.l_icon.TabIndex = 4;
            this.l_icon.Text = "Иконка MBox";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "warnning",
            "stop",
            "quest",
            "information"});
            this.listBox1.Location = new System.Drawing.Point(147, 133);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 56);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // l_color
            // 
            this.l_color.AutoSize = true;
            this.l_color.Location = new System.Drawing.Point(25, 253);
            this.l_color.Name = "l_color";
            this.l_color.Size = new System.Drawing.Size(61, 13);
            this.l_color.TabIndex = 6;
            this.l_color.Text = "Цвет фона";
            // 
            // b_MBox
            // 
            this.b_MBox.Location = new System.Drawing.Point(173, 348);
            this.b_MBox.Name = "b_MBox";
            this.b_MBox.Size = new System.Drawing.Size(75, 23);
            this.b_MBox.TabIndex = 9;
            this.b_MBox.Text = "Message Box";
            this.b_MBox.UseVisualStyleBackColor = true;
            this.b_MBox.Click += new System.EventHandler(this.b_MBox_Click);
            // 
            // chb_rgb
            // 
            this.chb_rgb.AutoSize = true;
            this.chb_rgb.Location = new System.Drawing.Point(276, 258);
            this.chb_rgb.Name = "chb_rgb";
            this.chb_rgb.Size = new System.Drawing.Size(49, 17);
            this.chb_rgb.TabIndex = 10;
            this.chb_rgb.Text = "RGB";
            this.chb_rgb.UseVisualStyleBackColor = true;
            this.chb_rgb.CheckedChanged += new System.EventHandler(this.chb_rgb_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_blue);
            this.panel1.Controls.Add(this.rb_green);
            this.panel1.Controls.Add(this.rb_red);
            this.panel1.Location = new System.Drawing.Point(147, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 73);
            this.panel1.TabIndex = 11;
            // 
            // rb_red
            // 
            this.rb_red.AutoSize = true;
            this.rb_red.Location = new System.Drawing.Point(4, 4);
            this.rb_red.Name = "rb_red";
            this.rb_red.Size = new System.Drawing.Size(70, 17);
            this.rb_red.TabIndex = 0;
            this.rb_red.TabStop = true;
            this.rb_red.Text = "Красный";
            this.rb_red.UseVisualStyleBackColor = true;
            this.rb_red.CheckedChanged += new System.EventHandler(this.rb_red_CheckedChanged);
            // 
            // rb_green
            // 
            this.rb_green.AutoSize = true;
            this.rb_green.Location = new System.Drawing.Point(4, 27);
            this.rb_green.Name = "rb_green";
            this.rb_green.Size = new System.Drawing.Size(70, 17);
            this.rb_green.TabIndex = 1;
            this.rb_green.TabStop = true;
            this.rb_green.Text = "Зеленый";
            this.rb_green.UseVisualStyleBackColor = true;
            this.rb_green.CheckedChanged += new System.EventHandler(this.rb_green_CheckedChanged);
            // 
            // rb_blue
            // 
            this.rb_blue.AutoSize = true;
            this.rb_blue.Location = new System.Drawing.Point(4, 51);
            this.rb_blue.Name = "rb_blue";
            this.rb_blue.Size = new System.Drawing.Size(56, 17);
            this.rb_blue.TabIndex = 2;
            this.rb_blue.TabStop = true;
            this.rb_blue.Text = "Синий";
            this.rb_blue.UseVisualStyleBackColor = true;
            this.rb_blue.CheckedChanged += new System.EventHandler(this.rb_blue_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chb_rgb);
            this.Controls.Add(this.b_MBox);
            this.Controls.Add(this.l_color);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.l_icon);
            this.Controls.Add(this.cb_button);
            this.Controls.Add(this.l_countButton);
            this.Controls.Add(this.l_messageText);
            this.Controls.Add(this.tb_message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.Label l_messageText;
        private System.Windows.Forms.Label l_countButton;
        private System.Windows.Forms.ComboBox cb_button;
        private System.Windows.Forms.Label l_icon;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label l_color;
        private System.Windows.Forms.Button b_MBox;
        private System.Windows.Forms.CheckBox chb_rgb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rb_blue;
        private System.Windows.Forms.RadioButton rb_green;
        private System.Windows.Forms.RadioButton rb_red;
        private System.Windows.Forms.Timer timer1;
    }
}


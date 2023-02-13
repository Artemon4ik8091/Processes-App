namespace Processes_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label_start = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_copy = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.textBox_start = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(321, 469);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 508);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 23);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Типо диспетчер задач";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Информация о процессе:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "ProcessID:";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(441, 68);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(0, 15);
            this.label_id.TabIndex = 6;
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.Location = new System.Drawing.Point(441, 88);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(0, 15);
            this.label_start.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Start Time";
            // 
            // label_copy
            // 
            this.label_copy.AutoSize = true;
            this.label_copy.Location = new System.Drawing.Point(441, 169);
            this.label_copy.Name = "label_copy";
            this.label_copy.Size = new System.Drawing.Size(0, 15);
            this.label_copy.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Thread Count";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(441, 117);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(0, 15);
            this.label_time.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(348, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Processor Time";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(441, 144);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(0, 15);
            this.label_count.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(346, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "Processes Copy";
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(635, 508);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 15;
            this.button_close.Text = "End Task";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // textBox_start
            // 
            this.textBox_start.Location = new System.Drawing.Point(145, 4);
            this.textBox_start.Name = "textBox_start";
            this.textBox_start.Size = new System.Drawing.Size(371, 23);
            this.textBox_start.TabIndex = 16;
            this.textBox_start.TextChanged += new System.EventHandler(this.textBox_start_TextChanged);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(522, 4);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(116, 23);
            this.button_start.TabIndex = 17;
            this.button_start.Text = "Start new process";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 543);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.textBox_start);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_copy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_start);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label_id;
        private Label label_start;
        private Label label5;
        private Label label_copy;
        private Label label7;
        private Label label_time;
        private Label label9;
        private Label label_count;
        private Label label11;
        private Button button_close;
        private TextBox textBox_start;
        private Button button_start;
    }
}
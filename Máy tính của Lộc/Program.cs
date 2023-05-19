using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace Máy_Tính_Của_Lộc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_result = new System.Windows.Forms.Label();
            this.lbl_old = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            
            this.panel1.Controls.Add(this.lbl_result);
            this.panel1.Controls.Add(this.lbl_old);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 100);
            this.panel1.TabIndex = 0;

            this.lbl_result.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_result.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_result.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_result.Location = new System.Drawing.Point(0, 64);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(326, 36);
            this.lbl_result.TabIndex = 1;
            this.lbl_result.Text = "label2";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_old.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_old.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_old.Location = new System.Drawing.Point(0, 0);
            this.lbl_old.Name = "lbl_old";
            this.lbl_old.Size = new System.Drawing.Size(326, 64);
            this.lbl_old.TabIndex = 0;
            this.lbl_old.Text = "label1";
            this.lbl_old.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.button16);
            this.panel2.Controls.Add(this.button15);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 299);
            this.panel2.TabIndex = 1;

            this.button16.Location = new System.Drawing.Point(165, 222);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 67);
            this.button16.TabIndex = 15;
            this.button16.Text = "Delete";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.btn_delete);

            this.button15.Location = new System.Drawing.Point(246, 222);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 67);
            this.button15.TabIndex = 14;
            this.button15.Text = "/";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.click);

            this.button14.Location = new System.Drawing.Point(3, 222);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 67);
            this.button14.TabIndex = 13;
            this.button14.Text = ".";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.click);

            this.button13.Location = new System.Drawing.Point(246, 149);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 67);
            this.button13.TabIndex = 12;
            this.button13.Text = "*";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.click);

            this.button12.Location = new System.Drawing.Point(246, 76);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 67);
            this.button12.TabIndex = 11;
            this.button12.Text = "-";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.click);

            this.button11.Location = new System.Drawing.Point(246, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 67);
            this.button11.TabIndex = 10;
            this.button11.Text = "+";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.click);

            this.button10.Location = new System.Drawing.Point(84, 222);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 67);
            this.button10.TabIndex = 9;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.click);

            this.button9.Location = new System.Drawing.Point(165, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 67);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.click);

            this.button8.Location = new System.Drawing.Point(84, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 67);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.click);
            
            this.button7.Location = new System.Drawing.Point(3, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 67);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.click);
           
            this.button6.Location = new System.Drawing.Point(165, 76);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 67);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.click);
           
            this.button5.Location = new System.Drawing.Point(84, 76);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 67);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.click);
            
            this.button4.Location = new System.Drawing.Point(3, 76);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 67);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.click);
          
            this.button3.Location = new System.Drawing.Point(165, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 67);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.click);

            this.button2.Location = new System.Drawing.Point(84, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 67);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.click);

            this.button1.Location = new System.Drawing.Point(3, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 425);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Máy tính của Lộc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private Panel panel1;
        private Label lbl_result;
        private Label lbl_old;
        private Panel panel2;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            lbl_old.Text += btn.Text;
            action();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_old.Text = "";
            lbl_result.Text = "";
        }

        private double tinh(string contents)
        {
            DataTable tb = new DataTable();
            return Convert.ToDouble(tb.Compute(contents, String.Empty));
        }

        private void action()
        {
            try
            {
                var result = tinh(lbl_old.Text);
                lbl_result.Text = Convert.ToString(result);
            }
            catch
            {
                lbl_result.Text = "Mời nhập số tiếp theo";
            }
        }
        private void btn_delete(object sender, EventArgs e)
        {
            char[] str_c = lbl_old.Text.ToArray();
            str_c[str_c.Length - 1] = ' ';
            lbl_old.Text = "";
            foreach (char c in str_c)
            {
                lbl_old.Text += Convert.ToString(c);
            }
            lbl_old.Text = lbl_old.Text.Replace(" ", "");
            action();
        }
    }
}

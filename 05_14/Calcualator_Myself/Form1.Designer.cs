﻿namespace Calcualator_Myself
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumScreen2 = new System.Windows.Forms.Label();
            this.NumScreen1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumScreen2
            // 
            this.NumScreen2.BackColor = System.Drawing.Color.White;
            this.NumScreen2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NumScreen2.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NumScreen2.Location = new System.Drawing.Point(13, 6);
            this.NumScreen2.Name = "NumScreen2";
            this.NumScreen2.Size = new System.Drawing.Size(258, 23);
            this.NumScreen2.TabIndex = 0;
            this.NumScreen2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NumScreen1
            // 
            this.NumScreen1.BackColor = System.Drawing.Color.White;
            this.NumScreen1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NumScreen1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NumScreen1.Location = new System.Drawing.Point(12, 37);
            this.NumScreen1.Name = "NumScreen1";
            this.NumScreen1.Size = new System.Drawing.Size(259, 37);
            this.NumScreen1.TabIndex = 1;
            this.NumScreen1.Text = "0";
            this.NumScreen1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "%";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button20_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "CE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(145, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(211, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 57);
            this.button4.TabIndex = 2;
            this.button4.Text = "<-";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 140);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 57);
            this.button5.TabIndex = 2;
            this.button5.Text = "1/x";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(79, 140);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 57);
            this.button6.TabIndex = 2;
            this.button6.Text = "x^2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(145, 140);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 57);
            this.button7.TabIndex = 2;
            this.button7.Text = "sqrt(x)";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(211, 140);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 57);
            this.button8.TabIndex = 2;
            this.button8.Text = "/";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button20_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(13, 203);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 57);
            this.button9.TabIndex = 2;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button22_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(79, 203);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(60, 57);
            this.button10.TabIndex = 2;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button22_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(145, 203);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(60, 57);
            this.button11.TabIndex = 2;
            this.button11.Text = "9";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button22_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(211, 203);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(60, 57);
            this.button12.TabIndex = 2;
            this.button12.Text = "*";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button20_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(13, 266);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(60, 57);
            this.button13.TabIndex = 2;
            this.button13.Text = "4";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button22_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(79, 266);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(60, 57);
            this.button14.TabIndex = 2;
            this.button14.Text = "5";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button22_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(145, 266);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(60, 57);
            this.button15.TabIndex = 2;
            this.button15.Text = "6";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button22_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(211, 266);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(60, 57);
            this.button16.TabIndex = 2;
            this.button16.Text = "-";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button20_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(13, 329);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(60, 57);
            this.button17.TabIndex = 2;
            this.button17.Text = "1";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button22_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(79, 329);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(60, 57);
            this.button18.TabIndex = 2;
            this.button18.Text = "2";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button22_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(145, 329);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(60, 57);
            this.button19.TabIndex = 2;
            this.button19.Text = "3";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button22_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(211, 329);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(60, 57);
            this.button20.TabIndex = 2;
            this.button20.Text = "+";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(13, 392);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(60, 57);
            this.button21.TabIndex = 2;
            this.button21.Text = "button1";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(79, 392);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(60, 57);
            this.button22.TabIndex = 2;
            this.button22.Text = "0";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(145, 392);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(60, 57);
            this.button23.TabIndex = 2;
            this.button23.Text = ".";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(211, 392);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(60, 57);
            this.button24.TabIndex = 2;
            this.button24.Text = "=";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button20_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NumScreen1);
            this.Controls.Add(this.NumScreen2);
            this.MaximumSize = new System.Drawing.Size(300, 500);
            this.MinimumSize = new System.Drawing.Size(300, 500);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NumScreen2;
        private System.Windows.Forms.Label NumScreen1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
    }
}

namespace HelloCSharpWin
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.NumberBtn1 = new System.Windows.Forms.Button();
            this.NumScreen = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NumClear = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.NumMinus = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SmallNum = new System.Windows.Forms.Button();
            this.SqurNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumberBtn1
            // 
            this.NumberBtn1.Location = new System.Drawing.Point(19, 232);
            this.NumberBtn1.Name = "NumberBtn1";
            this.NumberBtn1.Size = new System.Drawing.Size(65, 51);
            this.NumberBtn1.TabIndex = 0;
            this.NumberBtn1.Text = "1";
            this.NumberBtn1.UseVisualStyleBackColor = true;
            this.NumberBtn1.Click += new System.EventHandler(this.NumberBtn1_Click);
            // 
            // NumScreen
            // 
            this.NumScreen.BackColor = System.Drawing.SystemColors.Window;
            this.NumScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NumScreen.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NumScreen.Location = new System.Drawing.Point(19, 13);
            this.NumScreen.Name = "NumScreen";
            this.NumScreen.Size = new System.Drawing.Size(278, 42);
            this.NumScreen.TabIndex = 1;
            this.NumScreen.Text = "0";
            this.NumScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumberBtn1_Click);
            // 
            // NumClear
            // 
            this.NumClear.Location = new System.Drawing.Point(161, 61);
            this.NumClear.Name = "NumClear";
            this.NumClear.Size = new System.Drawing.Size(65, 51);
            this.NumClear.TabIndex = 0;
            this.NumClear.Text = "C";
            this.NumClear.UseVisualStyleBackColor = true;
            this.NumClear.Click += new System.EventHandler(this.NumClear_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(19, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 51);
            this.button4.TabIndex = 0;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NumberBtn1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(90, 175);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 51);
            this.button5.TabIndex = 0;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NumberBtn1_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(161, 175);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 51);
            this.button7.TabIndex = 0;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NumberBtn1_Click);
            // 
            // NumMinus
            // 
            this.NumMinus.Location = new System.Drawing.Point(232, 175);
            this.NumMinus.Name = "NumMinus";
            this.NumMinus.Size = new System.Drawing.Size(65, 51);
            this.NumMinus.TabIndex = 0;
            this.NumMinus.Text = "-";
            this.NumMinus.UseVisualStyleBackColor = true;
            this.NumMinus.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(161, 232);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(65, 51);
            this.button12.TabIndex = 0;
            this.button12.Text = "3";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.NumberBtn1_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(232, 232);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(65, 51);
            this.button13.TabIndex = 0;
            this.button13.Text = "+";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 51);
            this.button3.TabIndex = 0;
            this.button3.Text = "7";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumberBtn1_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(90, 118);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(65, 51);
            this.button14.TabIndex = 0;
            this.button14.Text = "8";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.NumberBtn1_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(161, 118);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(65, 51);
            this.button15.TabIndex = 0;
            this.button15.Text = "9";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.NumberBtn1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(90, 289);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 51);
            this.button6.TabIndex = 0;
            this.button6.Text = "0";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NumberBtn1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 51);
            this.button2.TabIndex = 0;
            this.button2.Text = "=";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(232, 118);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(65, 51);
            this.button8.TabIndex = 0;
            this.button8.Text = "*";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(232, 61);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(65, 51);
            this.button9.TabIndex = 0;
            this.button9.Text = "/";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // SmallNum
            // 
            this.SmallNum.Location = new System.Drawing.Point(19, 61);
            this.SmallNum.Name = "SmallNum";
            this.SmallNum.Size = new System.Drawing.Size(65, 51);
            this.SmallNum.TabIndex = 0;
            this.SmallNum.Text = "1/x";
            this.SmallNum.UseVisualStyleBackColor = true;
            this.SmallNum.Click += new System.EventHandler(this.SmallNum_Click);
            // 
            // SqurNum
            // 
            this.SqurNum.Location = new System.Drawing.Point(90, 61);
            this.SqurNum.Name = "SqurNum";
            this.SqurNum.Size = new System.Drawing.Size(65, 51);
            this.SqurNum.TabIndex = 0;
            this.SqurNum.Text = "x^2";
            this.SqurNum.UseVisualStyleBackColor = true;
            this.SqurNum.Click += new System.EventHandler(this.SqurNum_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 355);
            this.Controls.Add(this.NumScreen);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.NumMinus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NumClear);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.SqurNum);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.SmallNum);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.NumberBtn1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = " Calculator v0.1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NumberBtn1;
        private System.Windows.Forms.Label NumScreen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button NumClear;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button NumMinus;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button SmallNum;
        private System.Windows.Forms.Button SqurNum;
    }
}


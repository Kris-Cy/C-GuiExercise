namespace CH13Num9GUI
{
    partial class PayCalc
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.NumberLbl = new System.Windows.Forms.Label();
            this.RateLbl = new System.Windows.Forms.Label();
            this.HoursLbl = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.HourBox = new System.Windows.Forms.TextBox();
            this.RateBox = new System.Windows.Forms.TextBox();
            this.NumBox = new System.Windows.Forms.TextBox();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.CalcLbl = new System.Windows.Forms.Label();
            this.Savebtn = new System.Windows.Forms.Button();
            this.RetrieveBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(39, 64);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(49, 17);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Name:";
            // 
            // NumberLbl
            // 
            this.NumberLbl.AutoSize = true;
            this.NumberLbl.Location = new System.Drawing.Point(39, 112);
            this.NumberLbl.Name = "NumberLbl";
            this.NumberLbl.Size = new System.Drawing.Size(98, 17);
            this.NumberLbl.TabIndex = 1;
            this.NumberLbl.Text = "Emp. Number:";
            // 
            // RateLbl
            // 
            this.RateLbl.AutoSize = true;
            this.RateLbl.Location = new System.Drawing.Point(39, 164);
            this.RateLbl.Name = "RateLbl";
            this.RateLbl.Size = new System.Drawing.Size(42, 17);
            this.RateLbl.TabIndex = 2;
            this.RateLbl.Text = "Rate:";
            // 
            // HoursLbl
            // 
            this.HoursLbl.AutoSize = true;
            this.HoursLbl.Location = new System.Drawing.Point(39, 217);
            this.HoursLbl.Name = "HoursLbl";
            this.HoursLbl.Size = new System.Drawing.Size(103, 17);
            this.HoursLbl.TabIndex = 3;
            this.HoursLbl.Text = "Hours Worked:";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(148, 59);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 22);
            this.NameBox.TabIndex = 4;
            // 
            // HourBox
            // 
            this.HourBox.Location = new System.Drawing.Point(148, 212);
            this.HourBox.Name = "HourBox";
            this.HourBox.Size = new System.Drawing.Size(100, 22);
            this.HourBox.TabIndex = 5;
            this.HourBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HourBox_KeyPress);
            // 
            // RateBox
            // 
            this.RateBox.Location = new System.Drawing.Point(148, 164);
            this.RateBox.Name = "RateBox";
            this.RateBox.Size = new System.Drawing.Size(100, 22);
            this.RateBox.TabIndex = 6;
            this.RateBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RateBox_KeyPress);
            // 
            // NumBox
            // 
            this.NumBox.Location = new System.Drawing.Point(148, 109);
            this.NumBox.Name = "NumBox";
            this.NumBox.Size = new System.Drawing.Size(100, 22);
            this.NumBox.TabIndex = 7;
            this.NumBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumBox_KeyPress);
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(157, 283);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(75, 23);
            this.CalcBtn.TabIndex = 8;
            this.CalcBtn.Text = "Calculate";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // CalcLbl
            // 
            this.CalcLbl.AutoSize = true;
            this.CalcLbl.Location = new System.Drawing.Point(176, 325);
            this.CalcLbl.Name = "CalcLbl";
            this.CalcLbl.Size = new System.Drawing.Size(0, 17);
            this.CalcLbl.TabIndex = 9;
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(42, 283);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 10;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // RetrieveBtn
            // 
            this.RetrieveBtn.Location = new System.Drawing.Point(278, 282);
            this.RetrieveBtn.Name = "RetrieveBtn";
            this.RetrieveBtn.Size = new System.Drawing.Size(75, 23);
            this.RetrieveBtn.TabIndex = 11;
            this.RetrieveBtn.Text = "Retrieve";
            this.RetrieveBtn.UseVisualStyleBackColor = true;
            this.RetrieveBtn.Click += new System.EventHandler(this.RetrieveBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(157, 365);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 12;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(86, 9);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(239, 39);
            this.TitleLbl.TabIndex = 13;
            this.TitleLbl.Text = "Pay Calculator";
            // 
            // PayCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.RetrieveBtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.CalcLbl);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.NumBox);
            this.Controls.Add(this.RateBox);
            this.Controls.Add(this.HourBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.HoursLbl);
            this.Controls.Add(this.RateLbl);
            this.Controls.Add(this.NumberLbl);
            this.Controls.Add(this.NameLbl);
            this.Name = "PayCalc";
            this.Text = "PayCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label NumberLbl;
        private System.Windows.Forms.Label RateLbl;
        private System.Windows.Forms.Label HoursLbl;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox HourBox;
        private System.Windows.Forms.TextBox RateBox;
        private System.Windows.Forms.TextBox NumBox;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Label CalcLbl;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button RetrieveBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label TitleLbl;
    }
}


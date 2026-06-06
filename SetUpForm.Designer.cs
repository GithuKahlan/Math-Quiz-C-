namespace Math_Quiz_C_
{
    partial class SetUpForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RoundsControl = new System.Windows.Forms.NumericUpDown();
            this.comboxOperation = new System.Windows.Forms.ComboBox();
            this.comboxDifficuity = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.RoundsControl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(294, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Math-Quiz";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(409, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "StartTheGame";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(1, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Number of Rounds?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(1, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(605, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Quiz Operation:[add[1], Sub[2], Multi[3], Div[4], Mix[5]?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(1, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(534, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter Quiz difficulty: [Easy[1], Mid[2], Hard[3], Mix[4]?";
            // 
            // RoundsControl
            // 
            this.RoundsControl.Location = new System.Drawing.Point(291, 136);
            this.RoundsControl.Name = "RoundsControl";
            this.RoundsControl.Size = new System.Drawing.Size(120, 22);
            this.RoundsControl.TabIndex = 5;
            // 
            // comboxOperation
            // 
            this.comboxOperation.FormattingEnabled = true;
            this.comboxOperation.Items.AddRange(new object[] {
            "Addition",
            "Substraction",
            "Multiplication",
            "Division",
            "Mix"});
            this.comboxOperation.Location = new System.Drawing.Point(658, 189);
            this.comboxOperation.Name = "comboxOperation";
            this.comboxOperation.Size = new System.Drawing.Size(121, 24);
            this.comboxOperation.TabIndex = 8;
            // 
            // comboxDifficuity
            // 
            this.comboxDifficuity.FormattingEnabled = true;
            this.comboxDifficuity.Items.AddRange(new object[] {
            "Easy",
            "Mid",
            "Hard",
            "Mix"});
            this.comboxDifficuity.Location = new System.Drawing.Point(580, 264);
            this.comboxDifficuity.Name = "comboxDifficuity";
            this.comboxDifficuity.Size = new System.Drawing.Size(121, 24);
            this.comboxDifficuity.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 618);
            this.Controls.Add(this.comboxDifficuity);
            this.Controls.Add(this.comboxOperation);
            this.Controls.Add(this.RoundsControl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "Form1";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoundsControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown RoundsControl;
        private System.Windows.Forms.ComboBox comboxOperation;
        private System.Windows.Forms.ComboBox comboxDifficuity;
    }
}


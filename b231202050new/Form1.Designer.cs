namespace b231202050new
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        /// 


        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCenterX = new System.Windows.Forms.TextBox();
            this.txtCenterY = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackRed = new System.Windows.Forms.TrackBar();
            this.trackGreen = new System.Windows.Forms.TrackBar();
            this.trackBlue = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEdge = new System.Windows.Forms.TextBox();
            this.chkCounterClockwise = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.lstEdgeCoordinates = new System.Windows.Forms.ListBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.BtnRotate = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Center(x,y)";
            // 
            // txtCenterX
            // 
            this.txtCenterX.Location = new System.Drawing.Point(581, 13);
            this.txtCenterX.Name = "txtCenterX";
            this.txtCenterX.Size = new System.Drawing.Size(100, 20);
            this.txtCenterX.TabIndex = 1;
            // 
            // txtCenterY
            // 
            this.txtCenterY.Location = new System.Drawing.Point(688, 12);
            this.txtCenterY.Name = "txtCenterY";
            this.txtCenterY.Size = new System.Drawing.Size(100, 20);
            this.txtCenterY.TabIndex = 2;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(652, 40);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Length";
            // 
            // trackRed
            // 
            this.trackRed.Location = new System.Drawing.Point(688, 67);
            this.trackRed.Maximum = 255;
            this.trackRed.Name = "trackRed";
            this.trackRed.Size = new System.Drawing.Size(104, 45);
            this.trackRed.TabIndex = 5;
            // 
            // trackGreen
            // 
            this.trackGreen.Location = new System.Drawing.Point(688, 108);
            this.trackGreen.Maximum = 255;
            this.trackGreen.Name = "trackGreen";
            this.trackGreen.Size = new System.Drawing.Size(104, 45);
            this.trackGreen.TabIndex = 6;
            // 
            // trackBlue
            // 
            this.trackBlue.Location = new System.Drawing.Point(688, 159);
            this.trackBlue.Maximum = 255;
            this.trackBlue.Name = "trackBlue";
            this.trackBlue.Size = new System.Drawing.Size(104, 45);
            this.trackBlue.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(617, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(620, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Green";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Blue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Edge";
            // 
            // txtEdge
            // 
            this.txtEdge.Location = new System.Drawing.Point(581, 199);
            this.txtEdge.Name = "txtEdge";
            this.txtEdge.Size = new System.Drawing.Size(100, 20);
            this.txtEdge.TabIndex = 12;
            // 
            // chkCounterClockwise
            // 
            this.chkCounterClockwise.AutoSize = true;
            this.chkCounterClockwise.Location = new System.Drawing.Point(688, 201);
            this.chkCounterClockwise.Name = "chkCounterClockwise";
            this.chkCounterClockwise.Size = new System.Drawing.Size(129, 17);
            this.chkCounterClockwise.TabIndex = 13;
            this.chkCounterClockwise.Text = "chkCounterClockwise";
            this.chkCounterClockwise.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(521, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Angle";
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(584, 228);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(100, 20);
            this.txtAngle.TabIndex = 15;
            // 
            // lstEdgeCoordinates
            // 
            this.lstEdgeCoordinates.FormattingEnabled = true;
            this.lstEdgeCoordinates.Location = new System.Drawing.Point(652, 254);
            this.lstEdgeCoordinates.Name = "lstEdgeCoordinates";
            this.lstEdgeCoordinates.Size = new System.Drawing.Size(120, 95);
            this.lstEdgeCoordinates.TabIndex = 16;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(36, 46);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(300, 327);
            this.PictureBox1.TabIndex = 17;
            this.PictureBox1.TabStop = false;
            // 
            // BtnDraw
            // 
            this.BtnDraw.Location = new System.Drawing.Point(605, 356);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(75, 23);
            this.BtnDraw.TabIndex = 18;
            this.BtnDraw.Text = "DRAW";
            this.BtnDraw.UseVisualStyleBackColor = true;
            this.BtnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // BtnRotate
            // 
            this.BtnRotate.Location = new System.Drawing.Point(605, 386);
            this.BtnRotate.Name = "BtnRotate";
            this.BtnRotate.Size = new System.Drawing.Size(75, 23);
            this.BtnRotate.TabIndex = 19;
            this.BtnRotate.Text = "ROTATE";
            this.BtnRotate.UseVisualStyleBackColor = true;
            this.BtnRotate.Click += new System.EventHandler(this.BtnRotate_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(605, 416);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 20;
            this.BtnReset.Text = "RESET";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnRotate);
            this.Controls.Add(this.BtnDraw);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.lstEdgeCoordinates);
            this.Controls.Add(this.txtAngle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkCounterClockwise);
            this.Controls.Add(this.txtEdge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBlue);
            this.Controls.Add(this.trackGreen);
            this.Controls.Add(this.trackRed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtCenterY);
            this.Controls.Add(this.txtCenterX);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCenterX;
        private System.Windows.Forms.TextBox txtCenterY;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackRed;
        private System.Windows.Forms.TrackBar trackGreen;
        private System.Windows.Forms.TrackBar trackBlue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEdge;
        private System.Windows.Forms.CheckBox chkCounterClockwise;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.ListBox lstEdgeCoordinates;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.Button BtnRotate;
        private System.Windows.Forms.Button BtnReset;
    }
}


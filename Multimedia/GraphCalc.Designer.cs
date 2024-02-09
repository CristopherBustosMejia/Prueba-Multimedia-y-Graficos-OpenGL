namespace Multimedia
{
    partial class GraphCalc
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
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtW = new System.Windows.Forms.TextBox();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbMap
            // 
            this.pbMap.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMap.Location = new System.Drawing.Point(12, 12);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(579, 426);
            this.pbMap.TabIndex = 0;
            this.pbMap.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalc);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(597, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 119);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma { f(x) = ax^2 + bx + c }";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "c = ";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(37, 34);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(56, 20);
            this.txtA.TabIndex = 3;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateKeys);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(38, 65);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(55, 20);
            this.txtB.TabIndex = 4;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateKeys);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(37, 91);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(56, 20);
            this.txtC.TabIndex = 5;
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateKeys);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(116, 32);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 79);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Graficar";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRect);
            this.groupBox2.Controls.Add(this.btnCircle);
            this.groupBox2.Controls.Add(this.txtW);
            this.groupBox2.Controls.Add(this.txtH);
            this.groupBox2.Controls.Add(this.txtY);
            this.groupBox2.Controls.Add(this.txtX);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(597, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 139);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Poligonos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "x = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "y = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "h = ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(113, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "w = ";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(36, 27);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(55, 20);
            this.txtX.TabIndex = 13;
            this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateKeys);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(36, 53);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(55, 20);
            this.txtY.TabIndex = 14;
            this.txtY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateKeys);
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(136, 27);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(55, 20);
            this.txtH.TabIndex = 17;
            this.txtH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateKeys);
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(136, 51);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(55, 20);
            this.txtW.TabIndex = 18;
            this.txtW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateKeys);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(18, 89);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(75, 23);
            this.btnCircle.TabIndex = 19;
            this.btnCircle.Text = "Circulo";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnRect
            // 
            this.btnRect.Location = new System.Drawing.Point(116, 89);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(75, 23);
            this.btnRect.TabIndex = 20;
            this.btnRect.Text = "Rectangulo";
            this.btnRect.UseVisualStyleBackColor = true;
            this.btnRect.Click += new System.EventHandler(this.btnRect_Click);
            // 
            // GraphCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbMap);
            this.Name = "GraphCalc";
            this.Text = "GraphCalc";
            this.Load += new System.EventHandler(this.Graph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Button btnRect;
        private System.Windows.Forms.Button btnCircle;
    }
}
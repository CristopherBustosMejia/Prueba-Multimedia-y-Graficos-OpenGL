namespace Multimedia
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnGraph = new System.Windows.Forms.Button();
            this.btn3d = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(12, 37);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 53);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Abrir Reproductor";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenfileClick);
            // 
            // btnGraph
            // 
            this.btnGraph.Location = new System.Drawing.Point(109, 37);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(75, 53);
            this.btnGraph.TabIndex = 3;
            this.btnGraph.Text = "Abrir Graficador";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // btn3d
            // 
            this.btn3d.Location = new System.Drawing.Point(206, 37);
            this.btn3d.Name = "btn3d";
            this.btn3d.Size = new System.Drawing.Size(75, 53);
            this.btn3d.TabIndex = 4;
            this.btn3d.Text = "Abrir Animacion 3d";
            this.btn3d.UseVisualStyleBackColor = true;
            this.btn3d.Click += new System.EventHandler(this.btn3d_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 127);
            this.Controls.Add(this.btn3d);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "Main";
            this.Text = "Multimedia";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Button btn3d;
    }
}


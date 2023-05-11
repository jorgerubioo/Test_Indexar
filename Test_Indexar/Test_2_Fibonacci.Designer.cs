namespace Test_Indexar
{
    partial class Test_2_Fibonacci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test_2_Fibonacci));
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.btn_Show = new System.Windows.Forms.Button();
            this.txt_Sequence = new System.Windows.Forms.TextBox();
            this.lbl_Indicacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Siguiente = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(184, 137);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(129, 22);
            this.txt_Number.TabIndex = 0;
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(184, 175);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(129, 30);
            this.btn_Show.TabIndex = 1;
            this.btn_Show.Text = "Mostrar";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // txt_Sequence
            // 
            this.txt_Sequence.Enabled = false;
            this.txt_Sequence.Location = new System.Drawing.Point(49, 81);
            this.txt_Sequence.Name = "txt_Sequence";
            this.txt_Sequence.Size = new System.Drawing.Size(447, 22);
            this.txt_Sequence.TabIndex = 2;
            // 
            // lbl_Indicacion
            // 
            this.lbl_Indicacion.AutoSize = true;
            this.lbl_Indicacion.Location = new System.Drawing.Point(46, 140);
            this.lbl_Indicacion.Name = "lbl_Indicacion";
            this.lbl_Indicacion.Size = new System.Drawing.Size(119, 16);
            this.lbl_Indicacion.TabIndex = 3;
            this.lbl_Indicacion.Text = "Indique parametro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sucesión de Fibonacci";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Siguiente
            // 
            this.btn_Siguiente.Location = new System.Drawing.Point(412, 313);
            this.btn_Siguiente.Name = "btn_Siguiente";
            this.btn_Siguiente.Size = new System.Drawing.Size(83, 23);
            this.btn_Siguiente.TabIndex = 6;
            this.btn_Siguiente.Text = "Siguiente";
            this.btn_Siguiente.UseVisualStyleBackColor = true;
            this.btn_Siguiente.Click += new System.EventHandler(this.btn_Siguiente_Click);
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(22, 313);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(83, 23);
            this.btn_Volver.TabIndex = 7;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // Test_2_Fibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 353);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_Siguiente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Indicacion);
            this.Controls.Add(this.txt_Sequence);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.txt_Number);
            this.Name = "Test_2_Fibonacci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test_2_Fibonacci";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Number;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.TextBox txt_Sequence;
        private System.Windows.Forms.Label lbl_Indicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Siguiente;
        private System.Windows.Forms.Button btn_Volver;
    }
}
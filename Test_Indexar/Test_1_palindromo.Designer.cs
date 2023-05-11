namespace Test_Indexar
{
    partial class Test_1_palindromo
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
            this.lbl_Result = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_Check = new System.Windows.Forms.Button();
            this.btn_Siguiente = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(195, 66);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(116, 16);
            this.lbl_Result.TabIndex = 0;
            this.lbl_Result.Text = "Ingrese la palabra";
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(185, 108);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(132, 22);
            this.txt_input.TabIndex = 1;
            // 
            // btn_Check
            // 
            this.btn_Check.Location = new System.Drawing.Point(212, 163);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(75, 23);
            this.btn_Check.TabIndex = 2;
            this.btn_Check.Text = "Revisar";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // btn_Siguiente
            // 
            this.btn_Siguiente.Location = new System.Drawing.Point(212, 207);
            this.btn_Siguiente.Name = "btn_Siguiente";
            this.btn_Siguiente.Size = new System.Drawing.Size(81, 26);
            this.btn_Siguiente.TabIndex = 3;
            this.btn_Siguiente.Text = "Siguiente";
            this.btn_Siguiente.UseVisualStyleBackColor = true;
            this.btn_Siguiente.Click += new System.EventHandler(this.btn_Siguiente_Click);
            // 
            // Test_1_palindromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 395);
            this.Controls.Add(this.btn_Siguiente);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lbl_Result);
            this.Name = "Test_1_palindromo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test1 - Palindromo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Button btn_Siguiente;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}


namespace _02_ReviewExtension
{
    partial class Form1
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
            this.LstView = new System.Windows.Forms.ListView();
            this.BtnExercise1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstView
            // 
            this.LstView.Location = new System.Drawing.Point(295, 38);
            this.LstView.Name = "LstView";
            this.LstView.Size = new System.Drawing.Size(292, 268);
            this.LstView.TabIndex = 0;
            this.LstView.UseCompatibleStateImageBehavior = false;
            // 
            // BtnExercise1
            // 
            this.BtnExercise1.Location = new System.Drawing.Point(16, 40);
            this.BtnExercise1.Name = "BtnExercise1";
            this.BtnExercise1.Size = new System.Drawing.Size(209, 45);
            this.BtnExercise1.TabIndex = 1;
            this.BtnExercise1.Text = "Exercise 1";
            this.BtnExercise1.UseVisualStyleBackColor = true;
            this.BtnExercise1.Click += new System.EventHandler(this.BtnExercise1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 380);
            this.Controls.Add(this.BtnExercise1);
            this.Controls.Add(this.LstView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LstView;
        private System.Windows.Forms.Button BtnExercise1;
    }
}


namespace Pokedex.Controles
{
    partial class StatControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.myProgressbAr1 = new Pokedex.Controles.MyProgressBAr();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // myProgressbAr1
            // 
            this.myProgressbAr1.Dock = System.Windows.Forms.DockStyle.Right;
            this.myProgressbAr1.Location = new System.Drawing.Point(158, 0);
            this.myProgressbAr1.MaxValue = 100;
            this.myProgressbAr1.MinValue = 0;
            this.myProgressbAr1.Name = "myProgressbAr1";
            this.myProgressbAr1.ProgressColor = System.Drawing.Color.LightBlue;
            this.myProgressbAr1.Size = new System.Drawing.Size(423, 41);
            this.myProgressbAr1.TabIndex = 1;
            this.myProgressbAr1.Text = "myProgressbAr1";
            this.myProgressbAr1.Value = 0;
            // 
            // StatControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myProgressbAr1);
            this.Controls.Add(this.label1);
            this.Name = "StatControl";
            this.Size = new System.Drawing.Size(581, 41);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private MyProgressBAr myProgressbAr1;
    }
}

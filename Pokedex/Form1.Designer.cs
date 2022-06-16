namespace Pokedex
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listMoves = new System.Windows.Forms.ListBox();
            this.groupStats = new System.Windows.Forms.GroupBox();
            this.statsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backImage = new System.Windows.Forms.PictureBox();
            this.frontImage = new System.Windows.Forms.PictureBox();
            this.mainImage = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearchPokemon = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.abilitiesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TypeElementPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupStats.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupStats, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1263, 721);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1015, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 3);
            this.panel1.Size = new System.Drawing.Size(243, 711);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listMoves);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(243, 711);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movimientos";
            // 
            // listMoves
            // 
            this.listMoves.BackColor = System.Drawing.Color.White;
            this.listMoves.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMoves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMoves.FormattingEnabled = true;
            this.listMoves.ItemHeight = 23;
            this.listMoves.Location = new System.Drawing.Point(5, 29);
            this.listMoves.Margin = new System.Windows.Forms.Padding(10);
            this.listMoves.Name = "listMoves";
            this.listMoves.ScrollAlwaysVisible = true;
            this.listMoves.Size = new System.Drawing.Size(233, 677);
            this.listMoves.TabIndex = 0;
            // 
            // groupStats
            // 
            this.groupStats.Controls.Add(this.statsPanel);
            this.groupStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupStats.Location = new System.Drawing.Point(510, 293);
            this.groupStats.Margin = new System.Windows.Forms.Padding(5);
            this.groupStats.Name = "groupStats";
            this.groupStats.Padding = new System.Windows.Forms.Padding(5);
            this.groupStats.Size = new System.Drawing.Size(495, 242);
            this.groupStats.TabIndex = 3;
            this.groupStats.TabStop = false;
            this.groupStats.Text = "Estadisticas";
            // 
            // statsPanel
            // 
            this.statsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statsPanel.Location = new System.Drawing.Point(5, 29);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(485, 208);
            this.statsPanel.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.backImage);
            this.groupBox2.Controls.Add(this.frontImage);
            this.groupBox2.Controls.Add(this.mainImage);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(510, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(495, 278);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imagenes";
            // 
            // backImage
            // 
            this.backImage.Location = new System.Drawing.Point(306, 159);
            this.backImage.Margin = new System.Windows.Forms.Padding(5);
            this.backImage.Name = "backImage";
            this.backImage.Size = new System.Drawing.Size(134, 114);
            this.backImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backImage.TabIndex = 2;
            this.backImage.TabStop = false;
            // 
            // frontImage
            // 
            this.frontImage.Location = new System.Drawing.Point(306, 29);
            this.frontImage.Margin = new System.Windows.Forms.Padding(5);
            this.frontImage.Name = "frontImage";
            this.frontImage.Size = new System.Drawing.Size(134, 114);
            this.frontImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frontImage.TabIndex = 1;
            this.frontImage.TabStop = false;
            // 
            // mainImage
            // 
            this.mainImage.Location = new System.Drawing.Point(42, 29);
            this.mainImage.Margin = new System.Windows.Forms.Padding(5);
            this.mainImage.Name = "mainImage";
            this.mainImage.Size = new System.Drawing.Size(240, 244);
            this.mainImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainImage.TabIndex = 0;
            this.mainImage.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblExperience);
            this.groupBox3.Controls.Add(this.lblWeight);
            this.groupBox3.Controls.Add(this.lblHeight);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lblName);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(5, 293);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(495, 242);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Experiencia :";
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Location = new System.Drawing.Point(140, 195);
            this.lblExperience.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(17, 23);
            this.lblExperience.TabIndex = 8;
            this.lblExperience.Text = "-";
            this.lblExperience.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(140, 152);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(17, 23);
            this.lblWeight.TabIndex = 7;
            this.lblWeight.Text = "-";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(140, 109);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(17, 23);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "-";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Peso :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Altura :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(167, 47);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(24, 33);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "-";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtSearchPokemon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 282);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Busqueda por ID o Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Pokedex.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 192);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = global::Pokedex.Properties.Resources.buscar;
            this.button1.Location = new System.Drawing.Point(344, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 56);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearchPokemon
            // 
            this.txtSearchPokemon.Font = new System.Drawing.Font("Constantia", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSearchPokemon.Location = new System.Drawing.Point(54, 222);
            this.txtSearchPokemon.Name = "txtSearchPokemon";
            this.txtSearchPokemon.Size = new System.Drawing.Size(284, 53);
            this.txtSearchPokemon.TabIndex = 0;
            this.txtSearchPokemon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.abilitiesPanel);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(508, 543);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(499, 175);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Habilidades";
            // 
            // abilitiesPanel
            // 
            this.abilitiesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abilitiesPanel.Location = new System.Drawing.Point(3, 27);
            this.abilitiesPanel.Name = "abilitiesPanel";
            this.abilitiesPanel.Padding = new System.Windows.Forms.Padding(10);
            this.abilitiesPanel.Size = new System.Drawing.Size(493, 145);
            this.abilitiesPanel.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TypeElementPanel);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 543);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(499, 175);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tipo de Pokemon";
            // 
            // TypeElementPanel
            // 
            this.TypeElementPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TypeElementPanel.Location = new System.Drawing.Point(3, 27);
            this.TypeElementPanel.Name = "TypeElementPanel";
            this.TypeElementPanel.Padding = new System.Windows.Forms.Padding(10);
            this.TypeElementPanel.Size = new System.Drawing.Size(493, 145);
            this.TypeElementPanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1263, 721);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1279, 760);
            this.MinimumSize = new System.Drawing.Size(1279, 760);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupStats.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox frontImage;
        private PictureBox mainImage;
        private GroupBox groupBox3;
        private Label lblName;
        private Label label1;
        private GroupBox groupStats;
        private Label lblWeight;
        private Label lblHeight;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private Button button1;
        private TextBox txtSearchPokemon;
        private ListBox listMoves;
        private GroupBox groupBox4;
        private FlowLayoutPanel abilitiesPanel;
        private PictureBox backImage;
        private FlowLayoutPanel statsPanel;
        private GroupBox groupBox5;
        private FlowLayoutPanel TypeElementPanel;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label5;
        private Label lblExperience;
    }
}
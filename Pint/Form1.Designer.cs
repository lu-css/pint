namespace Pint
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.btnDesf = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnPensil = new System.Windows.Forms.Button();
            this.tbSize = new System.Windows.Forms.TrackBar();
            this.pbQuadro = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pnlNav.SuspendLayout();
            this.pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuadro)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.Black;
            this.pnlNav.Controls.Add(this.btnSave);
            this.pnlNav.Controls.Add(this.lblTitle);
            this.pnlNav.Controls.Add(this.btnExit);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(800, 34);
            this.pnlNav.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(12, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 28);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(134, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(205, 17);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Pint - Você pinta como eu pinto";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(766, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 34);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.Black;
            this.pnlBar.Controls.Add(this.btnDesf);
            this.pnlBar.Controls.Add(this.button1);
            this.pnlBar.Controls.Add(this.btnEraser);
            this.pnlBar.Controls.Add(this.btnPensil);
            this.pnlBar.Controls.Add(this.tbSize);
            this.pnlBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBar.Location = new System.Drawing.Point(0, 34);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(133, 416);
            this.pnlBar.TabIndex = 1;
            // 
            // btnDesf
            // 
            this.btnDesf.BackColor = System.Drawing.Color.Black;
            this.btnDesf.FlatAppearance.BorderSize = 0;
            this.btnDesf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnDesf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesf.ForeColor = System.Drawing.Color.White;
            this.btnDesf.Location = new System.Drawing.Point(3, 291);
            this.btnDesf.Name = "btnDesf";
            this.btnDesf.Size = new System.Drawing.Size(130, 48);
            this.btnDesf.TabIndex = 3;
            this.btnDesf.Text = "Limpar";
            this.btnDesf.UseVisualStyleBackColor = false;
            this.btnDesf.Click += new System.EventHandler(this.btnDesf_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 96);
            this.button1.TabIndex = 3;
            this.button1.Text = "Selecionar Cor";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.BackColor = System.Drawing.Color.White;
            this.btnEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEraser.Location = new System.Drawing.Point(73, 108);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(30, 30);
            this.btnEraser.TabIndex = 2;
            this.btnEraser.UseVisualStyleBackColor = false;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnPensil
            // 
            this.btnPensil.BackColor = System.Drawing.Color.White;
            this.btnPensil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPensil.Location = new System.Drawing.Point(73, 28);
            this.btnPensil.Name = "btnPensil";
            this.btnPensil.Size = new System.Drawing.Size(30, 30);
            this.btnPensil.TabIndex = 2;
            this.btnPensil.UseVisualStyleBackColor = false;
            this.btnPensil.Click += new System.EventHandler(this.btnPensil_Click);
            // 
            // tbSize
            // 
            this.tbSize.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.tbSize.Location = new System.Drawing.Point(12, 6);
            this.tbSize.Maximum = 20;
            this.tbSize.Minimum = 1;
            this.tbSize.Name = "tbSize";
            this.tbSize.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbSize.Size = new System.Drawing.Size(45, 144);
            this.tbSize.TabIndex = 2;
            this.tbSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbSize.Value = 1;
            this.tbSize.Scroll += new System.EventHandler(this.tbSize_Scroll);
            // 
            // pbQuadro
            // 
            this.pbQuadro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbQuadro.Location = new System.Drawing.Point(133, 34);
            this.pbQuadro.Name = "pbQuadro";
            this.pbQuadro.Size = new System.Drawing.Size(667, 416);
            this.pbQuadro.TabIndex = 2;
            this.pbQuadro.TabStop = false;
            this.pbQuadro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbQuadro_MouseDown);
            this.pbQuadro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbQuadro_MouseMove);
            this.pbQuadro.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbQuadro_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbQuadro);
            this.Controls.Add(this.pnlBar);
            this.Controls.Add(this.pnlNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pint - Você pinta como eu pinto";
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            this.pnlBar.ResumeLayout(false);
            this.pnlBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuadro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnPensil;
        private System.Windows.Forms.TrackBar tbSize;
        private System.Windows.Forms.PictureBox pbQuadro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnDesf;
    }
}


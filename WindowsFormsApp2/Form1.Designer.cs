namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.a1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaGraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetujWynikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.remisLabel = new System.Windows.Forms.Label();
            this.oCount = new System.Windows.Forms.Label();
            this.remisCount = new System.Windows.Forms.Label();
            this.xCount = new System.Windows.Forms.Label();
            this.gracz1 = new System.Windows.Forms.TextBox();
            this.gracz2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // a1
            // 
            this.a1.Cursor = System.Windows.Forms.Cursors.Default;
            this.a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.a1.Location = new System.Drawing.Point(12, 34);
            this.a1.Margin = new System.Windows.Forms.Padding(0);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(75, 75);
            this.a1.TabIndex = 0;
            this.a1.TabStop = false;
            this.a1.UseVisualStyleBackColor = true;
            this.a1.Click += new System.EventHandler(this.OnButtonClick);
            this.a1.MouseEnter += new System.EventHandler(this.onMouseEnterButton);
            this.a1.MouseLeave += new System.EventHandler(this.onMouseLeaveButton);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(262, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaGraToolStripMenuItem,
            this.resetujWynikiToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // nowaGraToolStripMenuItem
            // 
            this.nowaGraToolStripMenuItem.Name = "nowaGraToolStripMenuItem";
            this.nowaGraToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.nowaGraToolStripMenuItem.Text = "Nowa gra";
            this.nowaGraToolStripMenuItem.Click += new System.EventHandler(this.nowaGraToolStripMenuItem_Click);
            // 
            // resetujWynikiToolStripMenuItem
            // 
            this.resetujWynikiToolStripMenuItem.Name = "resetujWynikiToolStripMenuItem";
            this.resetujWynikiToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.resetujWynikiToolStripMenuItem.Text = "Resetuj wyniki";
            this.resetujWynikiToolStripMenuItem.Click += new System.EventHandler(this.resetujWynikiToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // a2
            // 
            this.a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.a2.Location = new System.Drawing.Point(93, 34);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(75, 75);
            this.a2.TabIndex = 10;
            this.a2.TabStop = false;
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Click += new System.EventHandler(this.OnButtonClick);
            this.a2.MouseEnter += new System.EventHandler(this.onMouseEnterButton);
            this.a2.MouseLeave += new System.EventHandler(this.onMouseLeaveButton);
            // 
            // a3
            // 
            this.a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.a3.Location = new System.Drawing.Point(174, 34);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(75, 75);
            this.a3.TabIndex = 11;
            this.a3.TabStop = false;
            this.a3.UseVisualStyleBackColor = true;
            this.a3.Click += new System.EventHandler(this.OnButtonClick);
            this.a3.MouseEnter += new System.EventHandler(this.onMouseEnterButton);
            this.a3.MouseLeave += new System.EventHandler(this.onMouseLeaveButton);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b3.Location = new System.Drawing.Point(174, 115);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 75);
            this.b3.TabIndex = 14;
            this.b3.TabStop = false;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.OnButtonClick);
            this.b3.MouseEnter += new System.EventHandler(this.onMouseEnterButton);
            this.b3.MouseLeave += new System.EventHandler(this.onMouseLeaveButton);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b2.Location = new System.Drawing.Point(93, 115);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 75);
            this.b2.TabIndex = 13;
            this.b2.TabStop = false;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.OnButtonClick);
            this.b2.MouseEnter += new System.EventHandler(this.onMouseEnterButton);
            this.b2.MouseLeave += new System.EventHandler(this.onMouseLeaveButton);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b1.Location = new System.Drawing.Point(12, 115);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 75);
            this.b1.TabIndex = 12;
            this.b1.TabStop = false;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.OnButtonClick);
            this.b1.MouseEnter += new System.EventHandler(this.onMouseEnterButton);
            this.b1.MouseLeave += new System.EventHandler(this.onMouseLeaveButton);
            // 
            // c3
            // 
            this.c3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.c3.Location = new System.Drawing.Point(174, 196);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(75, 75);
            this.c3.TabIndex = 17;
            this.c3.TabStop = false;
            this.c3.UseVisualStyleBackColor = true;
            this.c3.Click += new System.EventHandler(this.OnButtonClick);
            this.c3.MouseEnter += new System.EventHandler(this.onMouseEnterButton);
            this.c3.MouseLeave += new System.EventHandler(this.onMouseLeaveButton);
            // 
            // c2
            // 
            this.c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.c2.Location = new System.Drawing.Point(93, 196);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(75, 75);
            this.c2.TabIndex = 16;
            this.c2.TabStop = false;
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Click += new System.EventHandler(this.OnButtonClick);
            this.c2.MouseEnter += new System.EventHandler(this.onMouseEnterButton);
            this.c2.MouseLeave += new System.EventHandler(this.onMouseLeaveButton);
            // 
            // c1
            // 
            this.c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.c1.Location = new System.Drawing.Point(12, 196);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(75, 75);
            this.c1.TabIndex = 15;
            this.c1.TabStop = false;
            this.c1.UseVisualStyleBackColor = true;
            this.c1.Click += new System.EventHandler(this.OnButtonClick);
            this.c1.MouseEnter += new System.EventHandler(this.onMouseEnterButton);
            this.c1.MouseLeave += new System.EventHandler(this.onMouseLeaveButton);
            // 
            // remisLabel
            // 
            this.remisLabel.AutoSize = true;
            this.remisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.remisLabel.Location = new System.Drawing.Point(111, 278);
            this.remisLabel.Name = "remisLabel";
            this.remisLabel.Size = new System.Drawing.Size(41, 13);
            this.remisLabel.TabIndex = 19;
            this.remisLabel.Text = "Remis";
            // 
            // oCount
            // 
            this.oCount.AutoSize = true;
            this.oCount.Location = new System.Drawing.Point(204, 296);
            this.oCount.Name = "oCount";
            this.oCount.Size = new System.Drawing.Size(13, 13);
            this.oCount.TabIndex = 23;
            this.oCount.Text = "0";
            // 
            // remisCount
            // 
            this.remisCount.AutoSize = true;
            this.remisCount.Location = new System.Drawing.Point(125, 296);
            this.remisCount.Name = "remisCount";
            this.remisCount.Size = new System.Drawing.Size(13, 13);
            this.remisCount.TabIndex = 22;
            this.remisCount.Text = "0";
            // 
            // xCount
            // 
            this.xCount.AutoSize = true;
            this.xCount.Location = new System.Drawing.Point(44, 296);
            this.xCount.Name = "xCount";
            this.xCount.Size = new System.Drawing.Size(13, 13);
            this.xCount.TabIndex = 21;
            this.xCount.Text = "0";
            // 
            // gracz1
            // 
            this.gracz1.Location = new System.Drawing.Point(12, 275);
            this.gracz1.Name = "gracz1";
            this.gracz1.Size = new System.Drawing.Size(75, 20);
            this.gracz1.TabIndex = 24;
            this.gracz1.Text = "Gracz1";
            // 
            // gracz2
            // 
            this.gracz2.Location = new System.Drawing.Point(174, 275);
            this.gracz2.Name = "gracz2";
            this.gracz2.Size = new System.Drawing.Size(75, 20);
            this.gracz2.TabIndex = 25;
            this.gracz2.Text = "Gracz2";
            this.gracz2.TextChanged += new System.EventHandler(this.Gracz2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 318);
            this.Controls.Add(this.gracz2);
            this.Controls.Add(this.gracz1);
            this.Controls.Add(this.oCount);
            this.Controls.Add(this.remisCount);
            this.Controls.Add(this.xCount);
            this.Controls.Add(this.remisLabel);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kółko - krzyżyk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowaGraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Label remisLabel;
        private System.Windows.Forms.Label oCount;
        private System.Windows.Forms.Label remisCount;
        private System.Windows.Forms.Label xCount;
        private System.Windows.Forms.ToolStripMenuItem resetujWynikiToolStripMenuItem;
        private System.Windows.Forms.TextBox gracz1;
        private System.Windows.Forms.TextBox gracz2;
    }
}


namespace Cleaner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.LöschenButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.ErfolgLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // textLabel
            // 
            this.textLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textLabel.Font = new System.Drawing.Font("MS Gothic", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.Location = new System.Drawing.Point(0, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(414, 62);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "Löschen";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LöschenButton
            // 
            this.LöschenButton.Font = new System.Drawing.Font("MS Gothic", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LöschenButton.Location = new System.Drawing.Point(12, 389);
            this.LöschenButton.Name = "LöschenButton";
            this.LöschenButton.Size = new System.Drawing.Size(390, 74);
            this.LöschenButton.TabIndex = 2;
            this.LöschenButton.Text = "Löschen";
            this.LöschenButton.UseVisualStyleBackColor = true;
            this.LöschenButton.Click += new System.EventHandler(this.LöschenButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Font = new System.Drawing.Font("MS Gothic", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenButton.Location = new System.Drawing.Point(12, 309);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(390, 74);
            this.OpenButton.TabIndex = 3;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // ErfolgLabel
            // 
            this.ErfolgLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ErfolgLabel.Location = new System.Drawing.Point(107, 110);
            this.ErfolgLabel.Name = "ErfolgLabel";
            this.ErfolgLabel.Size = new System.Drawing.Size(200, 138);
            this.ErfolgLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(414, 475);
            this.Controls.Add(this.ErfolgLabel);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.LöschenButton);
            this.Controls.Add(this.textLabel);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Button LöschenButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Label ErfolgLabel;
    }
}


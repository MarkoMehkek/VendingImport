namespace SelectaImport
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.lblNumberOfDevices = new System.Windows.Forms.Label();
            this.pctb1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctb1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOpenFile.ForeColor = System.Drawing.Color.Blue;
            this.btnOpenFile.Location = new System.Drawing.Point(12, 12);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(182, 64);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Import Excel File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lblNumberOfDevices
            // 
            this.lblNumberOfDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumberOfDevices.ForeColor = System.Drawing.Color.Blue;
            this.lblNumberOfDevices.Location = new System.Drawing.Point(12, 88);
            this.lblNumberOfDevices.Name = "lblNumberOfDevices";
            this.lblNumberOfDevices.Size = new System.Drawing.Size(275, 23);
            this.lblNumberOfDevices.TabIndex = 1;
            this.lblNumberOfDevices.Text = "Number of Devices proccesed:  ";
            this.lblNumberOfDevices.Visible = false;
            // 
            // pctb1
            // 
            this.pctb1.Image = ((System.Drawing.Image)(resources.GetObject("pctb1.Image")));
            this.pctb1.Location = new System.Drawing.Point(360, 12);
            this.pctb1.Name = "pctb1";
            this.pctb1.Size = new System.Drawing.Size(324, 246);
            this.pctb1.TabIndex = 2;
            this.pctb1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(15, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 64);
            this.button1.TabIndex = 3;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 270);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pctb1);
            this.Controls.Add(this.lblNumberOfDevices);
            this.Controls.Add(this.btnOpenFile);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label lblNumberOfDevices;
        private System.Windows.Forms.PictureBox pctb1;
        private System.Windows.Forms.Button button1;
    }
}


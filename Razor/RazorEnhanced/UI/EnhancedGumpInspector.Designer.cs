namespace RazorEnhanced.UI
{
    partial class EnhancedGumpInspector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnhancedGumpInspector));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.close = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.razorButton1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(533, 384);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 25);
            this.close.TabIndex = 2;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.closeGumpInspector_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(19, 20);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 25);
            this.clear.TabIndex = 4;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.razorButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 401);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gump Log";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.razorButton1);
            this.groupBox2.Controls.Add(this.clear);
            this.groupBox2.Location = new System.Drawing.Point(514, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 93);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Command";
            // 
            // razorButton1
            // 
            this.razorButton1.Location = new System.Drawing.Point(19, 52);
            this.razorButton1.Name = "razorButton1";
            this.razorButton1.Size = new System.Drawing.Size(75, 34);
            this.razorButton1.TabIndex = 5;
            this.razorButton1.Text = "Copy value to Clipboard";
            this.razorButton1.UseVisualStyleBackColor = true;
            this.razorButton1.Click += new System.EventHandler(this.razorButton1_Click_1);
            // 
            // EnhancedGumpInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 422);
            this.Controls.Add(this.close);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnhancedGumpInspector";
            this.Text = "Enhanced Gump Inspector";
            this.Load += new System.EventHandler(this.EnhancedGumpInspector_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button razorButton1;



    }
}
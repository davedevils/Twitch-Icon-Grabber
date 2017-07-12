namespace Twitch_Icon_Grabber
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.needselected = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.size2 = new System.Windows.Forms.ComboBox();
            this.needall = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iconnumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.size1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // needselected
            // 
            this.needselected.Location = new System.Drawing.Point(261, 90);
            this.needselected.Name = "needselected";
            this.needselected.Size = new System.Drawing.Size(89, 23);
            this.needselected.TabIndex = 0;
            this.needselected.Text = "I Need this icon";
            this.needselected.UseVisualStyleBackColor = true;
            this.needselected.Click += new System.EventHandler(this.needselected_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.size2);
            this.groupBox1.Controls.Add(this.needall);
            this.groupBox1.Location = new System.Drawing.Point(5, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 119);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Twitch Grab ALL";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Size Of Icon";
            // 
            // size2
            // 
            this.size2.FormattingEnabled = true;
            this.size2.Location = new System.Drawing.Point(6, 49);
            this.size2.Name = "size2";
            this.size2.Size = new System.Drawing.Size(344, 21);
            this.size2.TabIndex = 3;
            // 
            // needall
            // 
            this.needall.Location = new System.Drawing.Point(261, 90);
            this.needall.Name = "needall";
            this.needall.Size = new System.Drawing.Size(89, 23);
            this.needall.TabIndex = 1;
            this.needall.Text = "I Need ALL";
            this.needall.UseVisualStyleBackColor = true;
            this.needall.Click += new System.EventHandler(this.needall_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.iconnumber);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.size1);
            this.groupBox2.Controls.Add(this.needselected);
            this.groupBox2.Location = new System.Drawing.Point(5, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 119);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Twitch Grab one icone";
            // 
            // iconnumber
            // 
            this.iconnumber.Location = new System.Drawing.Point(251, 32);
            this.iconnumber.Name = "iconnumber";
            this.iconnumber.Size = new System.Drawing.Size(100, 20);
            this.iconnumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Icon Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Size Of Icon";
            // 
            // size1
            // 
            this.size1.FormattingEnabled = true;
            this.size1.Location = new System.Drawing.Point(7, 63);
            this.size1.Name = "size1";
            this.size1.Size = new System.Drawing.Size(344, 21);
            this.size1.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 331);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(376, 358);
            this.MinimumSize = new System.Drawing.Size(376, 358);
            this.Name = "Main";
            this.Text = "Twitch Icon Grabber";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button needselected;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button needall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox size2;
        private System.Windows.Forms.ComboBox size1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iconnumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}


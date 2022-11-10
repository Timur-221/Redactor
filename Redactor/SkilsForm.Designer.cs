namespace Redactor
{
    partial class SkilsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkilsForm));
            this.Skill_one = new System.Windows.Forms.Button();
            this.Skill_two = new System.Windows.Forms.Button();
            this.Skill_three = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Skill_one
            // 
            this.Skill_one.Location = new System.Drawing.Point(65, 161);
            this.Skill_one.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Skill_one.Name = "Skill_one";
            this.Skill_one.Size = new System.Drawing.Size(56, 19);
            this.Skill_one.TabIndex = 0;
            this.Skill_one.Text = "Add";
            this.Skill_one.UseVisualStyleBackColor = true;
            this.Skill_one.Click += new System.EventHandler(this.Skill_one_Click);
            // 
            // Skill_two
            // 
            this.Skill_two.Location = new System.Drawing.Point(268, 161);
            this.Skill_two.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Skill_two.Name = "Skill_two";
            this.Skill_two.Size = new System.Drawing.Size(56, 19);
            this.Skill_two.TabIndex = 1;
            this.Skill_two.Text = "Add";
            this.Skill_two.UseVisualStyleBackColor = true;
            this.Skill_two.Click += new System.EventHandler(this.Skill_two_Click);
            // 
            // Skill_three
            // 
            this.Skill_three.Location = new System.Drawing.Point(475, 161);
            this.Skill_three.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Skill_three.Name = "Skill_three";
            this.Skill_three.Size = new System.Drawing.Size(56, 19);
            this.Skill_three.TabIndex = 2;
            this.Skill_three.Text = "Add";
            this.Skill_three.UseVisualStyleBackColor = true;
            this.Skill_three.Click += new System.EventHandler(this.Skill_three_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 132);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(242, 24);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 119);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(426, 24);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(172, 132);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // SkilsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 224);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Skill_three);
            this.Controls.Add(this.Skill_two);
            this.Controls.Add(this.Skill_one);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SkilsForm";
            this.Text = "SkilsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Skill_one;
        private System.Windows.Forms.Button Skill_two;
        private System.Windows.Forms.Button Skill_three;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
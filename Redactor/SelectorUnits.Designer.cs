namespace Redactor
{
    partial class SelectorUnits
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
            this.listUnit = new System.Windows.Forms.ListBox();
            this.Team1 = new System.Windows.Forms.ListBox();
            this.Team2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listUnit
            // 
            this.listUnit.FormattingEnabled = true;
            this.listUnit.ItemHeight = 16;
            this.listUnit.Location = new System.Drawing.Point(16, 57);
            this.listUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listUnit.Name = "listUnit";
            this.listUnit.Size = new System.Drawing.Size(227, 388);
            this.listUnit.TabIndex = 0;
            // 
            // Team1
            // 
            this.Team1.FormattingEnabled = true;
            this.Team1.ItemHeight = 16;
            this.Team1.Location = new System.Drawing.Point(361, 89);
            this.Team1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Team1.Name = "Team1";
            this.Team1.Size = new System.Drawing.Size(236, 308);
            this.Team1.TabIndex = 1;
            // 
            // Team2
            // 
            this.Team2.FormattingEnabled = true;
            this.Team2.ItemHeight = 16;
            this.Team2.Location = new System.Drawing.Point(811, 89);
            this.Team2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Team2.Name = "Team2";
            this.Team2.Size = new System.Drawing.Size(209, 308);
            this.Team2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 458);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create Team";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(90, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Units";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(439, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Team 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(886, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Team 2";
            // 
            // SelectorUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Team2);
            this.Controls.Add(this.Team1);
            this.Controls.Add(this.listUnit);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SelectorUnits";
            this.Text = "SelectorUnits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listUnit;
        private System.Windows.Forms.ListBox Team1;
        private System.Windows.Forms.ListBox Team2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
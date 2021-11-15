
namespace ServerConfigForm_P5_090
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
            this.buttonOn = new System.Windows.Forms.Button();
            this.buttonOff = new System.Windows.Forms.Button();
            this.labelOnOff = new System.Windows.Forms.Label();
            this.labelket = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOn
            // 
            this.buttonOn.Location = new System.Drawing.Point(255, 205);
            this.buttonOn.Name = "buttonOn";
            this.buttonOn.Size = new System.Drawing.Size(75, 23);
            this.buttonOn.TabIndex = 0;
            this.buttonOn.Text = "ON";
            this.buttonOn.UseVisualStyleBackColor = true;
            this.buttonOn.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOff
            // 
            this.buttonOff.Location = new System.Drawing.Point(374, 205);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(75, 23);
            this.buttonOff.TabIndex = 1;
            this.buttonOff.Text = "OFF";
            this.buttonOff.UseVisualStyleBackColor = true;
            this.buttonOff.Click += new System.EventHandler(this.buttonOff_Click);
            // 
            // labelOnOff
            // 
            this.labelOnOff.AutoSize = true;
            this.labelOnOff.Location = new System.Drawing.Point(334, 105);
            this.labelOnOff.Name = "labelOnOff";
            this.labelOnOff.Size = new System.Drawing.Size(0, 17);
            this.labelOnOff.TabIndex = 3;
            // 
            // labelket
            // 
            this.labelket.AutoSize = true;
            this.labelket.Location = new System.Drawing.Point(334, 142);
            this.labelket.Name = "labelket";
            this.labelket.Size = new System.Drawing.Size(0, 17);
            this.labelket.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelket);
            this.Controls.Add(this.labelOnOff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOff);
            this.Controls.Add(this.buttonOn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOn;
        private System.Windows.Forms.Button buttonOff;
        private System.Windows.Forms.Label labelOnOff;
        private System.Windows.Forms.Label labelket;
        private System.Windows.Forms.Label label1;
    }
}


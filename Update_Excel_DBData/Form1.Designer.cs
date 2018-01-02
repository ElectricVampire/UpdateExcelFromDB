namespace Update_Excel_DBData
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
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.lbldatefrom = new System.Windows.Forms.Label();
            this.lbldateto = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpto
            // 
            this.dtpto.CustomFormat = "yyyy-MM-dd";
            this.dtpto.Location = new System.Drawing.Point(98, 87);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(200, 20);
            this.dtpto.TabIndex = 0;
            // 
            // dtpfrom
            // 
            this.dtpfrom.CustomFormat = "yyyy-MM-dd";
            this.dtpfrom.Location = new System.Drawing.Point(98, 42);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(200, 20);
            this.dtpfrom.TabIndex = 1;
            // 
            // lbldatefrom
            // 
            this.lbldatefrom.AutoSize = true;
            this.lbldatefrom.Location = new System.Drawing.Point(29, 48);
            this.lbldatefrom.Name = "lbldatefrom";
            this.lbldatefrom.Size = new System.Drawing.Size(33, 13);
            this.lbldatefrom.TabIndex = 2;
            this.lbldatefrom.Text = "From:";
            // 
            // lbldateto
            // 
            this.lbldateto.AutoSize = true;
            this.lbldateto.Location = new System.Drawing.Point(29, 93);
            this.lbldateto.Name = "lbldateto";
            this.lbldateto.Size = new System.Drawing.Size(20, 13);
            this.lbldateto.TabIndex = 3;
            this.lbldateto.Text = "To";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(32, 140);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 4;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 238);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.lbldateto);
            this.Controls.Add(this.lbldatefrom);
            this.Controls.Add(this.dtpfrom);
            this.Controls.Add(this.dtpto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpto;
        private System.Windows.Forms.DateTimePicker dtpfrom;
        private System.Windows.Forms.Label lbldatefrom;
        private System.Windows.Forms.Label lbldateto;
        private System.Windows.Forms.Button btnsubmit;
    }
}


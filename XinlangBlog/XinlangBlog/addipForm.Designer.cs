namespace XinlangBlog
{
    partial class addipForm
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
            this.btn1 = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.ip = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(106, 214);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "确认";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(27, 46);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(35, 12);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "地区:";
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(81, 37);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(175, 21);
            this.area.TabIndex = 2;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(27, 89);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(23, 12);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "IP:";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(27, 123);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(35, 12);
            this.lb3.TabIndex = 1;
            this.lb3.Text = "端口:";
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(81, 80);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(175, 21);
            this.ip.TabIndex = 2;
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(81, 123);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(175, 21);
            this.port.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "状态:";
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(81, 167);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(175, 21);
            this.status.TabIndex = 2;
            // 
            // addipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.status);
            this.Controls.Add(this.port);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.area);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addipForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加IP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox status;
    }
}
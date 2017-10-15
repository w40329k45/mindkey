namespace mindkeyboard2._0
{
    partial class enactment_page
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
            this.confirm_btm = new System.Windows.Forms.Button();
            this.gear_comport_lab = new System.Windows.Forms.Label();
            this.bluetooth_lab = new System.Windows.Forms.Label();
            this.ime_lab = new System.Windows.Forms.Label();
            this.gearcoomport_cb = new System.Windows.Forms.ComboBox();
            this.bluetooth_cb = new System.Windows.Forms.ComboBox();
            this.ime_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.complete_rb = new System.Windows.Forms.RadioButton();
            this.simple_rb = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // confirm_btm
            // 
            this.confirm_btm.Location = new System.Drawing.Point(15, 182);
            this.confirm_btm.Name = "confirm_btm";
            this.confirm_btm.Size = new System.Drawing.Size(75, 23);
            this.confirm_btm.TabIndex = 0;
            this.confirm_btm.Text = "確認";
            this.confirm_btm.UseVisualStyleBackColor = true;
            // 
            // gear_comport_lab
            // 
            this.gear_comport_lab.AutoSize = true;
            this.gear_comport_lab.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gear_comport_lab.Location = new System.Drawing.Point(12, 28);
            this.gear_comport_lab.Name = "gear_comport_lab";
            this.gear_comport_lab.Size = new System.Drawing.Size(96, 16);
            this.gear_comport_lab.TabIndex = 1;
            this.gear_comport_lab.Text = "腦機comport:";
            // 
            // bluetooth_lab
            // 
            this.bluetooth_lab.AutoSize = true;
            this.bluetooth_lab.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bluetooth_lab.Location = new System.Drawing.Point(12, 56);
            this.bluetooth_lab.Name = "bluetooth_lab";
            this.bluetooth_lab.Size = new System.Drawing.Size(112, 16);
            this.bluetooth_lab.TabIndex = 2;
            this.bluetooth_lab.Text = "控制器comport:";
            // 
            // ime_lab
            // 
            this.ime_lab.AutoSize = true;
            this.ime_lab.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ime_lab.Location = new System.Drawing.Point(12, 88);
            this.ime_lab.Name = "ime_lab";
            this.ime_lab.Size = new System.Drawing.Size(104, 16);
            this.ime_lab.TabIndex = 3;
            this.ime_lab.Text = "預設輸入法：";
            // 
            // gearcoomport_cb
            // 
            this.gearcoomport_cb.FormattingEnabled = true;
            this.gearcoomport_cb.Location = new System.Drawing.Point(114, 24);
            this.gearcoomport_cb.Name = "gearcoomport_cb";
            this.gearcoomport_cb.Size = new System.Drawing.Size(121, 20);
            this.gearcoomport_cb.TabIndex = 4;
            this.gearcoomport_cb.Text = "選擇腦機comport";
            // 
            // bluetooth_cb
            // 
            this.bluetooth_cb.FormattingEnabled = true;
            this.bluetooth_cb.Location = new System.Drawing.Point(127, 52);
            this.bluetooth_cb.Name = "bluetooth_cb";
            this.bluetooth_cb.Size = new System.Drawing.Size(126, 20);
            this.bluetooth_cb.TabIndex = 5;
            this.bluetooth_cb.Text = "選擇控制器comport";
            // 
            // ime_cb
            // 
            this.ime_cb.FormattingEnabled = true;
            this.ime_cb.Location = new System.Drawing.Point(114, 84);
            this.ime_cb.Name = "ime_cb";
            this.ime_cb.Size = new System.Drawing.Size(134, 20);
            this.ime_cb.TabIndex = 6;
            this.ime_cb.Text = "選擇電腦預設輸入法";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "介面樣式：";
            // 
            // complete_rb
            // 
            this.complete_rb.AutoSize = true;
            this.complete_rb.Checked = true;
            this.complete_rb.Location = new System.Drawing.Point(106, 117);
            this.complete_rb.Name = "complete_rb";
            this.complete_rb.Size = new System.Drawing.Size(47, 16);
            this.complete_rb.TabIndex = 8;
            this.complete_rb.TabStop = true;
            this.complete_rb.Text = "完整";
            this.complete_rb.UseVisualStyleBackColor = true;
            // 
            // simple_rb
            // 
            this.simple_rb.AutoSize = true;
            this.simple_rb.Location = new System.Drawing.Point(159, 117);
            this.simple_rb.Name = "simple_rb";
            this.simple_rb.Size = new System.Drawing.Size(47, 16);
            this.simple_rb.TabIndex = 9;
            this.simple_rb.TabStop = true;
            this.simple_rb.Text = "簡易";
            this.simple_rb.UseVisualStyleBackColor = true;
            // 
            // enactment_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 226);
            this.Controls.Add(this.simple_rb);
            this.Controls.Add(this.complete_rb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ime_cb);
            this.Controls.Add(this.bluetooth_cb);
            this.Controls.Add(this.gearcoomport_cb);
            this.Controls.Add(this.ime_lab);
            this.Controls.Add(this.bluetooth_lab);
            this.Controls.Add(this.gear_comport_lab);
            this.Controls.Add(this.confirm_btm);
            this.Name = "enactment_page";
            this.Text = "設置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.enactment_page_FormClosing);
            this.Load += new System.EventHandler(this.enactment_page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirm_btm;
        private System.Windows.Forms.Label gear_comport_lab;
        private System.Windows.Forms.Label bluetooth_lab;
        private System.Windows.Forms.Label ime_lab;
        private System.Windows.Forms.ComboBox gearcoomport_cb;
        private System.Windows.Forms.ComboBox bluetooth_cb;
        private System.Windows.Forms.ComboBox ime_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton complete_rb;
        private System.Windows.Forms.RadioButton simple_rb;
    }
}
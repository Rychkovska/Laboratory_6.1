namespace Laboratory_6._1
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbWidth = new System.Windows.Forms.TextBox();
            this.txbHeight = new System.Windows.Forms.TextBox();
            this.btnResultrectsolid = new System.Windows.Forms.Button();
            this.btnResetrectsolid = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbVolume = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbVolumecube = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnResetcube = new System.Windows.Forms.Button();
            this.btnResultcube = new System.Windows.Forms.Button();
            this.txbRiblength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть довжину основи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введіть ширину основи";
            // 
            // txbWidth
            // 
            this.txbWidth.Location = new System.Drawing.Point(199, 60);
            this.txbWidth.Name = "txbWidth";
            this.txbWidth.Size = new System.Drawing.Size(100, 22);
            this.txbWidth.TabIndex = 2;
            // 
            // txbHeight
            // 
            this.txbHeight.Location = new System.Drawing.Point(198, 23);
            this.txbHeight.Name = "txbHeight";
            this.txbHeight.Size = new System.Drawing.Size(100, 22);
            this.txbHeight.TabIndex = 3;
            // 
            // btnResultrectsolid
            // 
            this.btnResultrectsolid.Location = new System.Drawing.Point(40, 133);
            this.btnResultrectsolid.Name = "btnResultrectsolid";
            this.btnResultrectsolid.Size = new System.Drawing.Size(75, 23);
            this.btnResultrectsolid.TabIndex = 4;
            this.btnResultrectsolid.Text = "Result";
            this.btnResultrectsolid.UseVisualStyleBackColor = true;
            this.btnResultrectsolid.Click += new System.EventHandler(this.btnResultrectsolid_Click);
            // 
            // btnResetrectsolid
            // 
            this.btnResetrectsolid.Location = new System.Drawing.Point(143, 133);
            this.btnResetrectsolid.Name = "btnResetrectsolid";
            this.btnResetrectsolid.Size = new System.Drawing.Size(75, 23);
            this.btnResetrectsolid.TabIndex = 5;
            this.btnResetrectsolid.Text = "Reset";
            this.btnResetrectsolid.UseVisualStyleBackColor = true;
            this.btnResetrectsolid.Click += new System.EventHandler(this.btnResetrectsolid_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbVolume);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbLength);
            this.groupBox1.Controls.Add(this.btnResetrectsolid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnResultrectsolid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbHeight);
            this.groupBox1.Controls.Add(this.txbWidth);
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 197);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Паралелепіпед";
            // 
            // txbVolume
            // 
            this.txbVolume.Location = new System.Drawing.Point(73, 164);
            this.txbVolume.Name = "txbVolume";
            this.txbVolume.Size = new System.Drawing.Size(100, 22);
            this.txbVolume.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Об\'єм";
            // 
            // txbLength
            // 
            this.txbLength.Location = new System.Drawing.Point(198, 97);
            this.txbLength.Name = "txbLength";
            this.txbLength.Size = new System.Drawing.Size(100, 22);
            this.txbLength.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введіть висоту ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbVolumecube);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnResetcube);
            this.groupBox2.Controls.Add(this.btnResultcube);
            this.groupBox2.Controls.Add(this.txbRiblength);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(1, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 120);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Куб";
            // 
            // txbVolumecube
            // 
            this.txbVolumecube.Location = new System.Drawing.Point(73, 91);
            this.txbVolumecube.Name = "txbVolumecube";
            this.txbVolumecube.Size = new System.Drawing.Size(100, 22);
            this.txbVolumecube.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Об\'єм";
            // 
            // btnResetcube
            // 
            this.btnResetcube.Location = new System.Drawing.Point(143, 62);
            this.btnResetcube.Name = "btnResetcube";
            this.btnResetcube.Size = new System.Drawing.Size(75, 23);
            this.btnResetcube.TabIndex = 3;
            this.btnResetcube.Text = "Reset";
            this.btnResetcube.UseVisualStyleBackColor = true;
            this.btnResetcube.Click += new System.EventHandler(this.btnResetcube_Click);
            // 
            // btnResultcube
            // 
            this.btnResultcube.Location = new System.Drawing.Point(40, 62);
            this.btnResultcube.Name = "btnResultcube";
            this.btnResultcube.Size = new System.Drawing.Size(75, 23);
            this.btnResultcube.TabIndex = 2;
            this.btnResultcube.Text = "Result";
            this.btnResultcube.UseVisualStyleBackColor = true;
            this.btnResultcube.Click += new System.EventHandler(this.btnResultcube_Click);
            // 
            // txbRiblength
            // 
            this.txbRiblength.Location = new System.Drawing.Point(198, 26);
            this.txbRiblength.Name = "txbRiblength";
            this.txbRiblength.Size = new System.Drawing.Size(100, 22);
            this.txbRiblength.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Введіть довжину ребра";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 338);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fMain";
            this.Text = "6_1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbWidth;
        private System.Windows.Forms.TextBox txbHeight;
        private System.Windows.Forms.Button btnResultrectsolid;
        private System.Windows.Forms.Button btnResetrectsolid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnResetcube;
        private System.Windows.Forms.Button btnResultcube;
        private System.Windows.Forms.TextBox txbRiblength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbVolume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbVolumecube;
        private System.Windows.Forms.Label label6;
    }
}


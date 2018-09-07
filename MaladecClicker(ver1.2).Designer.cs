namespace WindowsFormsApplication4
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
            this.button1 = new System.Windows.Forms.Button();
            this.Counter = new System.Windows.Forms.Label();
            this.howm = new System.Windows.Forms.Label();
            this.click = new System.Windows.Forms.Label();
            this.vk = new System.Windows.Forms.Button();
            this.vkg = new System.Windows.Forms.Button();
            this.ver = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(212, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "Я МалАдеЦ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.Font = new System.Drawing.Font("Motorwerk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Counter.Location = new System.Drawing.Point(387, 99);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(50, 11);
            this.Counter.TabIndex = 1;
            this.Counter.Text = "label1";
            this.Counter.Click += new System.EventHandler(this.Counter_Click);
            // 
            // howm
            // 
            this.howm.AutoSize = true;
            this.howm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.howm.Location = new System.Drawing.Point(148, 97);
            this.howm.Name = "howm";
            this.howm.Size = new System.Drawing.Size(241, 13);
            this.howm.TabIndex = 2;
            this.howm.Text = "До следующего звания тебе осталось:";
            this.howm.Click += new System.EventHandler(this.howm_Click);
            // 
            // click
            // 
            this.click.AutoSize = true;
            this.click.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.click.Location = new System.Drawing.Point(434, 97);
            this.click.Name = "click";
            this.click.Size = new System.Drawing.Size(57, 13);
            this.click.TabIndex = 3;
            this.click.Text = "нажатий";
            this.click.Click += new System.EventHandler(this.click_Click);
            // 
            // vk
            // 
            this.vk.Image = ((System.Drawing.Image)(resources.GetObject("vk.Image")));
            this.vk.Location = new System.Drawing.Point(212, 168);
            this.vk.Name = "vk";
            this.vk.Size = new System.Drawing.Size(75, 23);
            this.vk.TabIndex = 4;
            this.vk.Text = "vk dev page";
            this.vk.UseVisualStyleBackColor = true;
            this.vk.Click += new System.EventHandler(this.button2_Click);
            // 
            // vkg
            // 
            this.vkg.Image = ((System.Drawing.Image)(resources.GetObject("vkg.Image")));
            this.vkg.Location = new System.Drawing.Point(388, 168);
            this.vkg.Name = "vkg";
            this.vkg.Size = new System.Drawing.Size(75, 23);
            this.vkg.TabIndex = 5;
            this.vkg.Text = "vk dev group";
            this.vkg.UseVisualStyleBackColor = true;
            this.vkg.Click += new System.EventHandler(this.vkg_Click);
            // 
            // ver
            // 
            this.ver.AutoSize = true;
            this.ver.Location = new System.Drawing.Point(684, 274);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(37, 13);
            this.ver.TabIndex = 6;
            this.ver.Text = "ver1.2";
            this.ver.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 293);
            this.Controls.Add(this.ver);
            this.Controls.Add(this.vkg);
            this.Controls.Add(this.vk);
            this.Controls.Add(this.click);
            this.Controls.Add(this.howm);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Maladec Clicker ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Counter;
        private System.Windows.Forms.Label howm;
        private System.Windows.Forms.Label click;
        private System.Windows.Forms.Button vk;
        private System.Windows.Forms.Button vkg;
        private System.Windows.Forms.Label ver;
    }
}


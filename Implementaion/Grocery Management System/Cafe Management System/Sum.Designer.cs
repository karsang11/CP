namespace Cafe_Management_System
{
    partial class Sum
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtf = new System.Windows.Forms.TextBox();
            this.txts = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbadd = new System.Windows.Forms.RadioButton();
            this.rbsub = new System.Windows.Forms.RadioButton();
            this.rbmulti = new System.Windows.Forms.RadioButton();
            this.rbdiv = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second";
            // 
            // txtf
            // 
            this.txtf.Location = new System.Drawing.Point(213, 62);
            this.txtf.Name = "txtf";
            this.txtf.Size = new System.Drawing.Size(100, 22);
            this.txtf.TabIndex = 2;
            // 
            // txts
            // 
            this.txts.Location = new System.Drawing.Point(213, 115);
            this.txts.Name = "txts";
            this.txts.Size = new System.Drawing.Size(100, 22);
            this.txts.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(153, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbadd
            // 
            this.rbadd.AutoSize = true;
            this.rbadd.Location = new System.Drawing.Point(101, 185);
            this.rbadd.Name = "rbadd";
            this.rbadd.Size = new System.Drawing.Size(53, 21);
            this.rbadd.TabIndex = 5;
            this.rbadd.TabStop = true;
            this.rbadd.Text = "add";
            this.rbadd.UseVisualStyleBackColor = true;
            // 
            // rbsub
            // 
            this.rbsub.AutoSize = true;
            this.rbsub.Location = new System.Drawing.Point(271, 188);
            this.rbsub.Name = "rbsub";
            this.rbsub.Size = new System.Drawing.Size(80, 21);
            this.rbsub.TabIndex = 6;
            this.rbsub.TabStop = true;
            this.rbsub.Text = "subtract";
            this.rbsub.UseVisualStyleBackColor = true;
            // 
            // rbmulti
            // 
            this.rbmulti.AutoSize = true;
            this.rbmulti.Location = new System.Drawing.Point(101, 237);
            this.rbmulti.Name = "rbmulti";
            this.rbmulti.Size = new System.Drawing.Size(76, 21);
            this.rbmulti.TabIndex = 7;
            this.rbmulti.TabStop = true;
            this.rbmulti.Text = "multiply";
            this.rbmulti.UseVisualStyleBackColor = true;
            // 
            // rbdiv
            // 
            this.rbdiv.AutoSize = true;
            this.rbdiv.Location = new System.Drawing.Point(271, 234);
            this.rbdiv.Name = "rbdiv";
            this.rbdiv.Size = new System.Drawing.Size(76, 21);
            this.rbdiv.TabIndex = 8;
            this.rbdiv.TabStop = true;
            this.rbdiv.Text = "division";
            this.rbdiv.UseVisualStyleBackColor = true;
            // 
            // Sum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 347);
            this.Controls.Add(this.rbdiv);
            this.Controls.Add(this.rbmulti);
            this.Controls.Add(this.rbsub);
            this.Controls.Add(this.rbadd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txts);
            this.Controls.Add(this.txtf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Sum";
            this.Text = "`";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtf;
        private System.Windows.Forms.TextBox txts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbadd;
        private System.Windows.Forms.RadioButton rbsub;
        private System.Windows.Forms.RadioButton rbmulti;
        private System.Windows.Forms.RadioButton rbdiv;
    }
}
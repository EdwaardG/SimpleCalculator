namespace WindowsFormsApp1
{
    partial class frm_calculator
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
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txtbox_num1 = new System.Windows.Forms.TextBox();
            this.txtbox_num2 = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_sub
            // 
            this.btn_sub.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sub.Location = new System.Drawing.Point(12, 173);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(316, 55);
            this.btn_sub.TabIndex = 9;
            this.btn_sub.Text = "Get the Difference";
            this.btn_sub.UseVisualStyleBackColor = false;
            this.btn_sub.Click += new System.EventHandler(this.button10_Click);
            // 
            // btn_div
            // 
            this.btn_div.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_div.Location = new System.Drawing.Point(12, 295);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(316, 55);
            this.btn_div.TabIndex = 10;
            this.btn_div.Text = "Get the Quotient";
            this.btn_div.UseVisualStyleBackColor = false;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mul.Location = new System.Drawing.Point(12, 234);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(316, 55);
            this.btn_mul.TabIndex = 11;
            this.btn_mul.Text = "Get the Product";
            this.btn_mul.UseVisualStyleBackColor = false;
            this.btn_mul.Click += new System.EventHandler(this.btn_mul_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(12, 112);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(316, 55);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Get the Sum";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txtbox_num1
            // 
            this.txtbox_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_num1.Location = new System.Drawing.Point(12, 12);
            this.txtbox_num1.Name = "txtbox_num1";
            this.txtbox_num1.Size = new System.Drawing.Size(315, 44);
            this.txtbox_num1.TabIndex = 18;
            this.txtbox_num1.Text = "0";
            this.txtbox_num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtbox_num2
            // 
            this.txtbox_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_num2.Location = new System.Drawing.Point(12, 62);
            this.txtbox_num2.Name = "txtbox_num2";
            this.txtbox_num2.Size = new System.Drawing.Size(315, 44);
            this.txtbox_num2.TabIndex = 19;
            this.txtbox_num2.Text = "0";
            this.txtbox_num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(205, 359);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(122, 13);
            this.lbl_name.TabIndex = 20;
            this.lbl_name.Text = "Enejosa, Edward Gen L.";
            // 
            // frm_calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(340, 381);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txtbox_num2);
            this.Controls.Add(this.txtbox_num1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_sub);
            this.Name = "frm_calculator";
            this.Text = "Simple Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txtbox_num1;
        private System.Windows.Forms.TextBox txtbox_num2;
        private System.Windows.Forms.Label lbl_name;
    }
}


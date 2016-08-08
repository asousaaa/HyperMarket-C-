namespace HyberMarket
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
            this.label1 = new System.Windows.Forms.Label();
            this.Insert_funcation = new System.Windows.Forms.Button();
            this.sim_select_function = new System.Windows.Forms.Button();
            this.Update_function = new System.Windows.Forms.Button();
            this.Delete_function = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Pristina", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Hyper Super Market";
            // 
            // Insert_funcation
            // 
            this.Insert_funcation.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_funcation.Location = new System.Drawing.Point(74, 83);
            this.Insert_funcation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Insert_funcation.Name = "Insert_funcation";
            this.Insert_funcation.Size = new System.Drawing.Size(83, 51);
            this.Insert_funcation.TabIndex = 1;
            this.Insert_funcation.Text = "Insert";
            this.Insert_funcation.UseVisualStyleBackColor = true;
            this.Insert_funcation.Click += new System.EventHandler(this.Insert_funcation_Click);
            // 
            // sim_select_function
            // 
            this.sim_select_function.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sim_select_function.Location = new System.Drawing.Point(91, 162);
            this.sim_select_function.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sim_select_function.Name = "sim_select_function";
            this.sim_select_function.Size = new System.Drawing.Size(87, 51);
            this.sim_select_function.TabIndex = 2;
            this.sim_select_function.Text = "Simple select";
            this.sim_select_function.UseVisualStyleBackColor = true;
            this.sim_select_function.Click += new System.EventHandler(this.button1_Click);
            // 
            // Update_function
            // 
            this.Update_function.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_function.Location = new System.Drawing.Point(202, 83);
            this.Update_function.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Update_function.Name = "Update_function";
            this.Update_function.Size = new System.Drawing.Size(85, 50);
            this.Update_function.TabIndex = 3;
            this.Update_function.Text = "Update";
            this.Update_function.UseVisualStyleBackColor = true;
            this.Update_function.Click += new System.EventHandler(this.Update_function_Click);
            // 
            // Delete_function
            // 
            this.Delete_function.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_function.Location = new System.Drawing.Point(309, 82);
            this.Delete_function.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Delete_function.Name = "Delete_function";
            this.Delete_function.Size = new System.Drawing.Size(78, 52);
            this.Delete_function.TabIndex = 4;
            this.Delete_function.Text = "Delete";
            this.Delete_function.UseVisualStyleBackColor = true;
            this.Delete_function.Click += new System.EventHandler(this.Delete_function_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(287, 167);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cmplex select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(168, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 54);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cyrstal Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(452, 313);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Delete_function);
            this.Controls.Add(this.Update_function);
            this.Controls.Add(this.sim_select_function);
            this.Controls.Add(this.Insert_funcation);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Buxton Sketch", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Insert_funcation;
        private System.Windows.Forms.Button sim_select_function;
        private System.Windows.Forms.Button Update_function;
        private System.Windows.Forms.Button Delete_function;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


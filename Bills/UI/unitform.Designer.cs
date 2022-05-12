namespace Bills.UI
{
    partial class unitform
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_unitName = new System.Windows.Forms.TextBox();
            this.txt_unitNotes = new System.Windows.Forms.RichTextBox();
            this.btn_unitCancel = new System.Windows.Forms.Button();
            this.btn_unitsave = new System.Windows.Forms.Button();
            this.label_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Units Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unit Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Notes :";
            // 
            // txt_unitName
            // 
            this.txt_unitName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unitName.Location = new System.Drawing.Point(280, 130);
            this.txt_unitName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_unitName.Name = "txt_unitName";
            this.txt_unitName.Size = new System.Drawing.Size(344, 32);
            this.txt_unitName.TabIndex = 5;
            // 
            // txt_unitNotes
            // 
            this.txt_unitNotes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unitNotes.Location = new System.Drawing.Point(280, 213);
            this.txt_unitNotes.Margin = new System.Windows.Forms.Padding(4);
            this.txt_unitNotes.Name = "txt_unitNotes";
            this.txt_unitNotes.Size = new System.Drawing.Size(344, 119);
            this.txt_unitNotes.TabIndex = 6;
            this.txt_unitNotes.Text = "";
            // 
            // btn_unitCancel
            // 
            this.btn_unitCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_unitCancel.Image = global::Bills.Properties.Resources.cancle;
            this.btn_unitCancel.Location = new System.Drawing.Point(146, 374);
            this.btn_unitCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_unitCancel.Name = "btn_unitCancel";
            this.btn_unitCancel.Size = new System.Drawing.Size(151, 49);
            this.btn_unitCancel.TabIndex = 8;
            this.btn_unitCancel.UseVisualStyleBackColor = true;
            this.btn_unitCancel.Click += new System.EventHandler(this.btn_unitCancel_Click);
            // 
            // btn_unitsave
            // 
            this.btn_unitsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_unitsave.Image = global::Bills.Properties.Resources.save;
            this.btn_unitsave.Location = new System.Drawing.Point(492, 374);
            this.btn_unitsave.Margin = new System.Windows.Forms.Padding(4);
            this.btn_unitsave.Name = "btn_unitsave";
            this.btn_unitsave.Size = new System.Drawing.Size(116, 49);
            this.btn_unitsave.TabIndex = 10;
            this.btn_unitsave.UseVisualStyleBackColor = true;
            this.btn_unitsave.Click += new System.EventHandler(this.btn_unitsave_Click);
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Location = new System.Drawing.Point(442, 348);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 16);
            this.label_error.TabIndex = 11;
            // 
            // unitform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.btn_unitsave);
            this.Controls.Add(this.btn_unitCancel);
            this.Controls.Add(this.txt_unitNotes);
            this.Controls.Add(this.txt_unitName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "unitform";
            this.Text = "unitform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_unitName;
        private System.Windows.Forms.RichTextBox txt_unitNotes;
        private System.Windows.Forms.Button btn_unitCancel;
        private System.Windows.Forms.Button btn_unitsave;
        private System.Windows.Forms.Label label_error;
    }
}
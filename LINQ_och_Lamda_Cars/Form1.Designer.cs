
namespace LINQ_och_Lamda_Cars
{
    partial class Car_Tracker
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
            this.lib_CarList = new System.Windows.Forms.ListBox();
            this.lib_Kvitto = new System.Windows.Forms.ListBox();
            this.btn_AmountCollor = new System.Windows.Forms.Button();
            this.btn_Age = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lib_CarList
            // 
            this.lib_CarList.FormattingEnabled = true;
            this.lib_CarList.ItemHeight = 16;
            this.lib_CarList.Location = new System.Drawing.Point(54, 12);
            this.lib_CarList.Name = "lib_CarList";
            this.lib_CarList.Size = new System.Drawing.Size(312, 212);
            this.lib_CarList.TabIndex = 0;
            // 
            // lib_Kvitto
            // 
            this.lib_Kvitto.FormattingEnabled = true;
            this.lib_Kvitto.ItemHeight = 16;
            this.lib_Kvitto.Location = new System.Drawing.Point(54, 363);
            this.lib_Kvitto.Name = "lib_Kvitto";
            this.lib_Kvitto.Size = new System.Drawing.Size(444, 148);
            this.lib_Kvitto.TabIndex = 1;
            // 
            // btn_AmountCollor
            // 
            this.btn_AmountCollor.Location = new System.Drawing.Point(54, 253);
            this.btn_AmountCollor.Name = "btn_AmountCollor";
            this.btn_AmountCollor.Size = new System.Drawing.Size(89, 44);
            this.btn_AmountCollor.TabIndex = 2;
            this.btn_AmountCollor.Text = "button1";
            this.btn_AmountCollor.UseVisualStyleBackColor = true;
            this.btn_AmountCollor.Click += new System.EventHandler(this.btn_AmountCollor_Click);
            // 
            // btn_Age
            // 
            this.btn_Age.Location = new System.Drawing.Point(214, 253);
            this.btn_Age.Name = "btn_Age";
            this.btn_Age.Size = new System.Drawing.Size(152, 44);
            this.btn_Age.TabIndex = 3;
            this.btn_Age.Text = "button1";
            this.btn_Age.UseVisualStyleBackColor = true;
            this.btn_Age.Click += new System.EventHandler(this.btn_Age_Click);
            // 
            // Car_Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 550);
            this.Controls.Add(this.btn_Age);
            this.Controls.Add(this.btn_AmountCollor);
            this.Controls.Add(this.lib_Kvitto);
            this.Controls.Add(this.lib_CarList);
            this.Name = "Car_Tracker";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lib_CarList;
        private System.Windows.Forms.ListBox lib_Kvitto;
        private System.Windows.Forms.Button btn_AmountCollor;
        private System.Windows.Forms.Button btn_Age;
    }
}


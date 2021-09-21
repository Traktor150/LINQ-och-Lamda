
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
            this.SuspendLayout();
            // 
            // lib_CarList
            // 
            this.lib_CarList.FormattingEnabled = true;
            this.lib_CarList.ItemHeight = 16;
            this.lib_CarList.Location = new System.Drawing.Point(176, 12);
            this.lib_CarList.Name = "lib_CarList";
            this.lib_CarList.Size = new System.Drawing.Size(437, 212);
            this.lib_CarList.TabIndex = 0;
            // 
            // Car_Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 661);
            this.Controls.Add(this.lib_CarList);
            this.Name = "Car_Tracker";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lib_CarList;
    }
}


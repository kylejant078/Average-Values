
namespace Average_Values
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
            this.title = new System.Windows.Forms.Label();
            this.introduction = new System.Windows.Forms.Label();
            this.fineDetails = new System.Windows.Forms.Label();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.numberAdded = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.SlateGray;
            this.title.Font = new System.Drawing.Font("Dutch801 XBd BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(-2, -1);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(491, 68);
            this.title.TabIndex = 0;
            this.title.Text = "Average Number Solver";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // introduction
            // 
            this.introduction.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introduction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.introduction.Location = new System.Drawing.Point(102, 80);
            this.introduction.Name = "introduction";
            this.introduction.Size = new System.Drawing.Size(285, 33);
            this.introduction.TabIndex = 1;
            this.introduction.Text = "Enter a Number and Press Add";
            this.introduction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fineDetails
            // 
            this.fineDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fineDetails.Location = new System.Drawing.Point(103, 124);
            this.fineDetails.Name = "fineDetails";
            this.fineDetails.Size = new System.Drawing.Size(279, 23);
            this.fineDetails.TabIndex = 2;
            this.fineDetails.Text = "(enter 0 and press Add to calculate average)";
            // 
            // numberInput
            // 
            this.numberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberInput.Location = new System.Drawing.Point(159, 178);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(65, 35);
            this.numberInput.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(230, 178);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(74, 35);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // numberAdded
            // 
            this.numberAdded.BackColor = System.Drawing.Color.White;
            this.numberAdded.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberAdded.Location = new System.Drawing.Point(102, 277);
            this.numberAdded.Name = "numberAdded";
            this.numberAdded.Size = new System.Drawing.Size(248, 104);
            this.numberAdded.TabIndex = 5;
            this.numberAdded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(488, 457);
            this.Controls.Add(this.numberAdded);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.fineDetails);
            this.Controls.Add(this.introduction);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Values";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label introduction;
        private System.Windows.Forms.Label fineDetails;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label numberAdded;
    }
}


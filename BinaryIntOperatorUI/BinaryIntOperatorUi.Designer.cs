namespace BinaryIntOperatorUI
{
    partial class BinaryIntOperatorUi
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
            this.ui_textBoxX = new System.Windows.Forms.TextBox();
            this.ui_labelX = new System.Windows.Forms.Label();
            this.ui_labelY = new System.Windows.Forms.Label();
            this.ui_textBoxY = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ui_textBoxResult = new System.Windows.Forms.TextBox();
            this.ui_labelOperator = new System.Windows.Forms.Label();
            this.ui_radioButtonAddition = new System.Windows.Forms.RadioButton();
            this.ui_radioButtonSubtraction = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ui_textBoxX
            // 
            this.ui_textBoxX.Location = new System.Drawing.Point(69, 132);
            this.ui_textBoxX.Name = "ui_textBoxX";
            this.ui_textBoxX.Size = new System.Drawing.Size(100, 20);
            this.ui_textBoxX.TabIndex = 0;
            // 
            // ui_labelX
            // 
            this.ui_labelX.AutoSize = true;
            this.ui_labelX.Location = new System.Drawing.Point(69, 113);
            this.ui_labelX.Name = "ui_labelX";
            this.ui_labelX.Size = new System.Drawing.Size(14, 13);
            this.ui_labelX.TabIndex = 1;
            this.ui_labelX.Text = "X";
            // 
            // ui_labelY
            // 
            this.ui_labelY.AutoSize = true;
            this.ui_labelY.Location = new System.Drawing.Point(228, 113);
            this.ui_labelY.Name = "ui_labelY";
            this.ui_labelY.Size = new System.Drawing.Size(14, 13);
            this.ui_labelY.TabIndex = 3;
            this.ui_labelY.Text = "Y";
            // 
            // ui_textBoxY
            // 
            this.ui_textBoxY.Location = new System.Drawing.Point(231, 132);
            this.ui_textBoxY.Name = "ui_textBoxY";
            this.ui_textBoxY.Size = new System.Drawing.Size(100, 20);
            this.ui_textBoxY.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ui_textBoxResult
            // 
            this.ui_textBoxResult.Location = new System.Drawing.Point(484, 130);
            this.ui_textBoxResult.Name = "ui_textBoxResult";
            this.ui_textBoxResult.ReadOnly = true;
            this.ui_textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.ui_textBoxResult.TabIndex = 5;
            // 
            // ui_labelOperator
            // 
            this.ui_labelOperator.AutoSize = true;
            this.ui_labelOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_labelOperator.Location = new System.Drawing.Point(185, 128);
            this.ui_labelOperator.Name = "ui_labelOperator";
            this.ui_labelOperator.Size = new System.Drawing.Size(24, 25);
            this.ui_labelOperator.TabIndex = 6;
            this.ui_labelOperator.Text = "+";
            // 
            // ui_radioButtonAddition
            // 
            this.ui_radioButtonAddition.AutoSize = true;
            this.ui_radioButtonAddition.Checked = true;
            this.ui_radioButtonAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_radioButtonAddition.Location = new System.Drawing.Point(16, 19);
            this.ui_radioButtonAddition.Name = "ui_radioButtonAddition";
            this.ui_radioButtonAddition.Size = new System.Drawing.Size(42, 29);
            this.ui_radioButtonAddition.TabIndex = 7;
            this.ui_radioButtonAddition.TabStop = true;
            this.ui_radioButtonAddition.Text = "+";
            this.ui_radioButtonAddition.UseVisualStyleBackColor = true;
            this.ui_radioButtonAddition.CheckedChanged += new System.EventHandler(this.ui_radioButton_CheckedChanged);
            // 
            // ui_radioButtonSubtraction
            // 
            this.ui_radioButtonSubtraction.AutoSize = true;
            this.ui_radioButtonSubtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_radioButtonSubtraction.Location = new System.Drawing.Point(16, 43);
            this.ui_radioButtonSubtraction.Name = "ui_radioButtonSubtraction";
            this.ui_radioButtonSubtraction.Size = new System.Drawing.Size(39, 33);
            this.ui_radioButtonSubtraction.TabIndex = 8;
            this.ui_radioButtonSubtraction.Text = "-";
            this.ui_radioButtonSubtraction.UseVisualStyleBackColor = true;
            this.ui_radioButtonSubtraction.CheckedChanged += new System.EventHandler(this.ui_radioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ui_radioButtonAddition);
            this.groupBox1.Controls.Add(this.ui_radioButtonSubtraction);
            this.groupBox1.Location = new System.Drawing.Point(69, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 83);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operators";
            // 
            // BinaryIntOperatorUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 234);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ui_labelOperator);
            this.Controls.Add(this.ui_textBoxResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ui_labelY);
            this.Controls.Add(this.ui_textBoxY);
            this.Controls.Add(this.ui_labelX);
            this.Controls.Add(this.ui_textBoxX);
            this.Name = "BinaryIntOperatorUi";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ui_textBoxX;
        private System.Windows.Forms.Label ui_labelX;
        private System.Windows.Forms.Label ui_labelY;
        private System.Windows.Forms.TextBox ui_textBoxY;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ui_textBoxResult;
        private System.Windows.Forms.Label ui_labelOperator;
        private System.Windows.Forms.RadioButton ui_radioButtonAddition;
        private System.Windows.Forms.RadioButton ui_radioButtonSubtraction;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


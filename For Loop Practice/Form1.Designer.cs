namespace For_Loop_Practice
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private System.Windows.Forms.GroupBox grpConversions;
        private System.Windows.Forms.RadioButton rbInches;
        private System.Windows.Forms.RadioButton rbFeet;
        private System.Windows.Forms.RadioButton rbYards;
        private System.Windows.Forms.RadioButton rbMiles;
        private System.Windows.Forms.Label lblPromptChoice;
        private System.Windows.Forms.Label lblPromptValue;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpConversions = new System.Windows.Forms.GroupBox();
            this.rbMiles = new System.Windows.Forms.RadioButton();
            this.rbYards = new System.Windows.Forms.RadioButton();
            this.rbFeet = new System.Windows.Forms.RadioButton();
            this.rbInches = new System.Windows.Forms.RadioButton();
            this.lblPromptChoice = new System.Windows.Forms.Label();
            this.lblPromptValue = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpConversions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConversions
            // 
            this.grpConversions.Controls.Add(this.rbMiles);
            this.grpConversions.Controls.Add(this.rbYards);
            this.grpConversions.Controls.Add(this.rbFeet);
            this.grpConversions.Controls.Add(this.rbInches);
            this.grpConversions.Location = new System.Drawing.Point(18, 38);
            this.grpConversions.Name = "grpConversions";
            this.grpConversions.Size = new System.Drawing.Size(300, 110);
            this.grpConversions.TabIndex = 0;
            this.grpConversions.TabStop = false;
            this.grpConversions.Text = "Linear Conversion";
            // 
            // rbMiles
            // 
            this.rbMiles.AutoSize = true;
            this.rbMiles.Location = new System.Drawing.Point(16, 82);
            this.rbMiles.Name = "rbMiles";
            this.rbMiles.Size = new System.Drawing.Size(106, 17);
            this.rbMiles.TabIndex = 3;
            this.rbMiles.TabStop = true;
            this.rbMiles.Text = "4. Miles to Km";
            this.rbMiles.UseVisualStyleBackColor = true;
            // 
            // rbYards
            // 
            this.rbYards.AutoSize = true;
            this.rbYards.Location = new System.Drawing.Point(16, 59);
            this.rbYards.Name = "rbYards";
            this.rbYards.Size = new System.Drawing.Size(105, 17);
            this.rbYards.TabIndex = 2;
            this.rbYards.TabStop = true;
            this.rbYards.Text = "3. Yards to Metres";
            this.rbYards.UseVisualStyleBackColor = true;
            // 
            // rbFeet
            // 
            this.rbFeet.AutoSize = true;
            this.rbFeet.Location = new System.Drawing.Point(16, 36);
            this.rbFeet.Name = "rbFeet";
            this.rbFeet.Size = new System.Drawing.Size(116, 17);
            this.rbFeet.TabIndex = 1;
            this.rbFeet.TabStop = true;
            this.rbFeet.Text = "2. Feet to Centimetres";
            this.rbFeet.UseVisualStyleBackColor = true;
            // 
            // rbInches
            // 
            this.rbInches.AutoSize = true;
            this.rbInches.Location = new System.Drawing.Point(16, 16);
            this.rbInches.Name = "rbInches";
            this.rbInches.Size = new System.Drawing.Size(128, 17);
            this.rbInches.TabIndex = 0;
            this.rbInches.TabStop = true;
            this.rbInches.Text = "1. Inches to Centimetres";
            this.rbInches.UseVisualStyleBackColor = true;
            this.rbInches.Checked = true;
            // 
            // lblPromptChoice
            // 
            this.lblPromptChoice.AutoSize = true;
            this.lblPromptChoice.Location = new System.Drawing.Point(15, 18);
            this.lblPromptChoice.Name = "lblPromptChoice";
            this.lblPromptChoice.Size = new System.Drawing.Size(130, 13);
            this.lblPromptChoice.TabIndex = 1;
            this.lblPromptChoice.Text = "Choose conversion (1-4):";
            // 
            // lblPromptValue
            // 
            this.lblPromptValue.AutoSize = true;
            this.lblPromptValue.Location = new System.Drawing.Point(330, 38);
            this.lblPromptValue.Name = "lblPromptValue";
            this.lblPromptValue.Size = new System.Drawing.Size(110, 13);
            this.lblPromptValue.TabIndex = 2;
            this.lblPromptValue.Text = "Enter value to convert:";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(333, 58);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(120, 20);
            this.txtValue.TabIndex = 4;
            this.txtValue.Text = "100";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(333, 88);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(120, 25);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(333, 119);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 25);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(18, 160);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(435, 40);
            this.lblResult.TabIndex = 7;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 221);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblPromptValue);
            this.Controls.Add(this.lblPromptChoice);
            this.Controls.Add(this.grpConversions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(490, 260);
            this.Name = "Form1";
            this.Text = "Unit Converter";
            this.grpConversions.ResumeLayout(false);
            this.grpConversions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

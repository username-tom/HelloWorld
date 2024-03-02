namespace HelloWorld
{
    partial class RollADice
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ButtonRoll = new Button();
            LabelOutput = new Label();
            ComboSides = new ComboBox();
            SuspendLayout();
            // 
            // ButtonRoll
            // 
            ButtonRoll.Anchor = AnchorStyles.Top;
            ButtonRoll.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonRoll.Location = new Point(42, 133);
            ButtonRoll.Name = "ButtonRoll";
            ButtonRoll.Size = new Size(250, 90);
            ButtonRoll.TabIndex = 0;
            ButtonRoll.Text = "Roll Dice";
            ButtonRoll.UseVisualStyleBackColor = true;
            ButtonRoll.Click += ButtonRoll_Click;
            // 
            // LabelOutput
            // 
            LabelOutput.Anchor = AnchorStyles.Top;
            LabelOutput.AutoSize = true;
            LabelOutput.FlatStyle = FlatStyle.Flat;
            LabelOutput.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelOutput.Location = new Point(139, 29);
            LabelOutput.Name = "LabelOutput";
            LabelOutput.Size = new Size(56, 65);
            LabelOutput.TabIndex = 1;
            LabelOutput.Text = "6";
            LabelOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ComboSides
            // 
            ComboSides.FormattingEnabled = true;
            ComboSides.Items.AddRange(new object[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            ComboSides.Location = new Point(42, 235);
            ComboSides.Name = "ComboSides";
            ComboSides.Size = new Size(250, 23);
            ComboSides.TabIndex = 2;
            ComboSides.Text = "6";
            ComboSides.SelectedValueChanged += ComboSides_SelectedIndexChanged;
            // 
            // RollADice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(334, 286);
            Controls.Add(ComboSides);
            Controls.Add(LabelOutput);
            Controls.Add(ButtonRoll);
            Name = "RollADice";
            Text = "Roll A Dice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonRoll;
        private Label LabelOutput;
        private ComboBox ComboSides;
    }
}

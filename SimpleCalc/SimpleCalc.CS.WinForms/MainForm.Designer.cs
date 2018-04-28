namespace SimpleCalc.CS.WinForms
{
  partial class MainForm
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
      this.AnswerTextBox = new System.Windows.Forms.TextBox();
      this.CalculateButton = new System.Windows.Forms.Button();
      this.Number2TextBox = new System.Windows.Forms.TextBox();
      this.OperatorComboBox = new System.Windows.Forms.ComboBox();
      this.Number1TextBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // AnswerTextBox
      // 
      this.AnswerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.AnswerTextBox.Location = new System.Drawing.Point(432, 12);
      this.AnswerTextBox.Name = "AnswerTextBox";
      this.AnswerTextBox.Size = new System.Drawing.Size(100, 29);
      this.AnswerTextBox.TabIndex = 19;
      this.AnswerTextBox.Text = "0";
      this.AnswerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.AnswerTextBox.TextChanged += new System.EventHandler(this.AnswerTextBox_TextChanged);
      // 
      // CalculateButton
      // 
      this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CalculateButton.Location = new System.Drawing.Point(351, 11);
      this.CalculateButton.Name = "CalculateButton";
      this.CalculateButton.Size = new System.Drawing.Size(75, 32);
      this.CalculateButton.TabIndex = 18;
      this.CalculateButton.Text = "=";
      this.CalculateButton.UseVisualStyleBackColor = true;
      this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
      // 
      // Number2TextBox
      // 
      this.Number2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Number2TextBox.Location = new System.Drawing.Point(245, 12);
      this.Number2TextBox.Name = "Number2TextBox";
      this.Number2TextBox.Size = new System.Drawing.Size(100, 29);
      this.Number2TextBox.TabIndex = 17;
      this.Number2TextBox.Text = "10";
      this.Number2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.Number2TextBox.TextChanged += new System.EventHandler(this.Number2TextBox_TextChanged);
      // 
      // OperatorComboBox
      // 
      this.OperatorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.OperatorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.OperatorComboBox.FormattingEnabled = true;
      this.OperatorComboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
      this.OperatorComboBox.Location = new System.Drawing.Point(118, 11);
      this.OperatorComboBox.Name = "OperatorComboBox";
      this.OperatorComboBox.Size = new System.Drawing.Size(121, 32);
      this.OperatorComboBox.TabIndex = 16;
      this.OperatorComboBox.SelectedIndexChanged += new System.EventHandler(this.OperatorComboBox_SelectedIndexChanged);
      // 
      // Number1TextBox
      // 
      this.Number1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Number1TextBox.Location = new System.Drawing.Point(12, 12);
      this.Number1TextBox.Name = "Number1TextBox";
      this.Number1TextBox.Size = new System.Drawing.Size(100, 29);
      this.Number1TextBox.TabIndex = 15;
      this.Number1TextBox.Text = "10";
      this.Number1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.Number1TextBox.TextChanged += new System.EventHandler(this.Number1TextBox_TextChanged);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(546, 59);
      this.Controls.Add(this.AnswerTextBox);
      this.Controls.Add(this.CalculateButton);
      this.Controls.Add(this.Number2TextBox);
      this.Controls.Add(this.OperatorComboBox);
      this.Controls.Add(this.Number1TextBox);
      this.Name = "MainForm";
      this.Text = "SimpleCalc - CS - WinForms";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.TextBox AnswerTextBox;
    internal System.Windows.Forms.Button CalculateButton;
    internal System.Windows.Forms.TextBox Number2TextBox;
    internal System.Windows.Forms.ComboBox OperatorComboBox;
    internal System.Windows.Forms.TextBox Number1TextBox;
  }
}


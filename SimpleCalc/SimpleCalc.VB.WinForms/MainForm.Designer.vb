<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.AnswerTextBox = New System.Windows.Forms.TextBox()
    Me.CalculateButton = New System.Windows.Forms.Button()
    Me.Number2TextBox = New System.Windows.Forms.TextBox()
    Me.OperatorComboBox = New System.Windows.Forms.ComboBox()
    Me.Number1TextBox = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'AnswerTextBox
    '
    Me.AnswerTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.AnswerTextBox.Location = New System.Drawing.Point(432, 12)
    Me.AnswerTextBox.Name = "AnswerTextBox"
    Me.AnswerTextBox.Size = New System.Drawing.Size(100, 29)
    Me.AnswerTextBox.TabIndex = 24
    Me.AnswerTextBox.Text = "0"
    Me.AnswerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'CalculateButton
    '
    Me.CalculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.CalculateButton.Location = New System.Drawing.Point(351, 11)
    Me.CalculateButton.Name = "CalculateButton"
    Me.CalculateButton.Size = New System.Drawing.Size(75, 32)
    Me.CalculateButton.TabIndex = 23
    Me.CalculateButton.Text = "="
    Me.CalculateButton.UseVisualStyleBackColor = True
    '
    'Number2TextBox
    '
    Me.Number2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Number2TextBox.Location = New System.Drawing.Point(245, 12)
    Me.Number2TextBox.Name = "Number2TextBox"
    Me.Number2TextBox.Size = New System.Drawing.Size(100, 29)
    Me.Number2TextBox.TabIndex = 22
    Me.Number2TextBox.Text = "10"
    Me.Number2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'OperatorComboBox
    '
    Me.OperatorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.OperatorComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.OperatorComboBox.FormattingEnabled = True
    Me.OperatorComboBox.Items.AddRange(New Object() {"+", "-", "*", "/"})
    Me.OperatorComboBox.Location = New System.Drawing.Point(118, 11)
    Me.OperatorComboBox.Name = "OperatorComboBox"
    Me.OperatorComboBox.Size = New System.Drawing.Size(121, 32)
    Me.OperatorComboBox.TabIndex = 21
    '
    'Number1TextBox
    '
    Me.Number1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Number1TextBox.Location = New System.Drawing.Point(12, 12)
    Me.Number1TextBox.Name = "Number1TextBox"
    Me.Number1TextBox.Size = New System.Drawing.Size(100, 29)
    Me.Number1TextBox.TabIndex = 20
    Me.Number1TextBox.Text = "10"
    Me.Number1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'MainForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(546, 59)
    Me.Controls.Add(Me.AnswerTextBox)
    Me.Controls.Add(Me.CalculateButton)
    Me.Controls.Add(Me.Number2TextBox)
    Me.Controls.Add(Me.OperatorComboBox)
    Me.Controls.Add(Me.Number1TextBox)
    Me.Name = "MainForm"
    Me.Text = "SimpleCalc - VB - WinForms"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents AnswerTextBox As System.Windows.Forms.TextBox
  Friend WithEvents CalculateButton As System.Windows.Forms.Button
  Friend WithEvents Number2TextBox As System.Windows.Forms.TextBox
  Friend WithEvents OperatorComboBox As System.Windows.Forms.ComboBox
  Friend WithEvents Number1TextBox As System.Windows.Forms.TextBox

End Class

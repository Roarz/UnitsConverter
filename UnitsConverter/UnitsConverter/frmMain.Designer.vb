<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.cboConversionChoice = New System.Windows.Forms.ComboBox()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.btnProduceTable = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboDecimalPlaces = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConvertValue = New System.Windows.Forms.Button()
        Me.txtStart = New System.Windows.Forms.TextBox()
        Me.txtIncrement = New System.Windows.Forms.TextBox()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboConversionChoice
        '
        Me.cboConversionChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConversionChoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConversionChoice.FormattingEnabled = True
        Me.cboConversionChoice.Location = New System.Drawing.Point(15, 23)
        Me.cboConversionChoice.Name = "cboConversionChoice"
        Me.cboConversionChoice.Size = New System.Drawing.Size(276, 24)
        Me.cboConversionChoice.TabIndex = 0
        '
        'txtValue
        '
        Me.txtValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValue.Location = New System.Drawing.Point(118, 57)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(64, 22)
        Me.txtValue.TabIndex = 3
        Me.txtValue.Text = "1"
        '
        'btnProduceTable
        '
        Me.btnProduceTable.AccessibleDescription = ""
        Me.btnProduceTable.AccessibleName = ""
        Me.btnProduceTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduceTable.Location = New System.Drawing.Point(189, 170)
        Me.btnProduceTable.Name = "btnProduceTable"
        Me.btnProduceTable.Size = New System.Drawing.Size(101, 84)
        Me.btnProduceTable.TabIndex = 8
        Me.btnProduceTable.Text = "Produce Table!"
        Me.btnProduceTable.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Decimal places:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Start:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Increment:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 234)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "End:"
        '
        'cboDecimalPlaces
        '
        Me.cboDecimalPlaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDecimalPlaces.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDecimalPlaces.FormattingEnabled = True
        Me.cboDecimalPlaces.Location = New System.Drawing.Point(118, 83)
        Me.cboDecimalPlaces.Name = "cboDecimalPlaces"
        Me.cboDecimalPlaces.Size = New System.Drawing.Size(64, 24)
        Me.cboDecimalPlaces.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Value:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Result:"
        '
        'btnConvertValue
        '
        Me.btnConvertValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertValue.Location = New System.Drawing.Point(188, 57)
        Me.btnConvertValue.Name = "btnConvertValue"
        Me.btnConvertValue.Size = New System.Drawing.Size(102, 50)
        Me.btnConvertValue.TabIndex = 26
        Me.btnConvertValue.Text = "Convert Value"
        Me.btnConvertValue.UseVisualStyleBackColor = True
        '
        'txtStart
        '
        Me.txtStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStart.Location = New System.Drawing.Point(118, 171)
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(64, 22)
        Me.txtStart.TabIndex = 27
        Me.txtStart.Text = "5"
        '
        'txtIncrement
        '
        Me.txtIncrement.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncrement.Location = New System.Drawing.Point(118, 201)
        Me.txtIncrement.Name = "txtIncrement"
        Me.txtIncrement.Size = New System.Drawing.Size(64, 22)
        Me.txtIncrement.TabIndex = 28
        Me.txtIncrement.Text = "5"
        '
        'txtEnd
        '
        Me.txtEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnd.Location = New System.Drawing.Point(118, 231)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(64, 22)
        Me.txtEnd.TabIndex = 29
        Me.txtEnd.Text = "20"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(118, 110)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(172, 22)
        Me.lblResult.TabIndex = 5
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 270)
        Me.Controls.Add(Me.txtEnd)
        Me.Controls.Add(Me.txtIncrement)
        Me.Controls.Add(Me.txtStart)
        Me.Controls.Add(Me.btnConvertValue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboDecimalPlaces)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnProduceTable)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.cboConversionChoice)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.Text = "Metric units converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboConversionChoice As System.Windows.Forms.ComboBox
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents btnProduceTable As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboDecimalPlaces As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnConvertValue As System.Windows.Forms.Button
    Friend WithEvents txtStart As System.Windows.Forms.TextBox
    Friend WithEvents txtIncrement As System.Windows.Forms.TextBox
    Friend WithEvents txtEnd As System.Windows.Forms.TextBox
    Friend WithEvents lblResult As System.Windows.Forms.Label

End Class

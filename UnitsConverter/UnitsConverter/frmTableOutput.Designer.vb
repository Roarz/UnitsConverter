<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTableOutput
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
        Me.lvwTableOutput = New System.Windows.Forms.ListView()
        Me.btnClearResults = New System.Windows.Forms.Button()
        Me.lblConversionChoice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lvwTableOutput
        '
        Me.lvwTableOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwTableOutput.GridLines = True
        Me.lvwTableOutput.HideSelection = False
        Me.lvwTableOutput.Location = New System.Drawing.Point(12, 28)
        Me.lvwTableOutput.MultiSelect = False
        Me.lvwTableOutput.Name = "lvwTableOutput"
        Me.lvwTableOutput.Size = New System.Drawing.Size(256, 284)
        Me.lvwTableOutput.TabIndex = 1
        Me.lvwTableOutput.UseCompatibleStateImageBehavior = False
        Me.lvwTableOutput.View = System.Windows.Forms.View.Details
        '
        'btnClearResults
        '
        Me.btnClearResults.Location = New System.Drawing.Point(193, 318)
        Me.btnClearResults.Name = "btnClearResults"
        Me.btnClearResults.Size = New System.Drawing.Size(75, 23)
        Me.btnClearResults.TabIndex = 2
        Me.btnClearResults.Text = "Clear"
        Me.btnClearResults.UseVisualStyleBackColor = True
        '
        'lblConversionChoice
        '
        Me.lblConversionChoice.AutoSize = True
        Me.lblConversionChoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConversionChoice.Location = New System.Drawing.Point(13, 9)
        Me.lblConversionChoice.Name = "lblConversionChoice"
        Me.lblConversionChoice.Size = New System.Drawing.Size(109, 16)
        Me.lblConversionChoice.TabIndex = 3
        Me.lblConversionChoice.Text = "Selection Choice"
        '
        'frmTableOutput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 353)
        Me.Controls.Add(Me.lblConversionChoice)
        Me.Controls.Add(Me.btnClearResults)
        Me.Controls.Add(Me.lvwTableOutput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmTableOutput"
        Me.Text = "Table Output"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvwTableOutput As System.Windows.Forms.ListView
    Friend WithEvents btnClearResults As System.Windows.Forms.Button
    Friend WithEvents lblConversionChoice As System.Windows.Forms.Label
End Class

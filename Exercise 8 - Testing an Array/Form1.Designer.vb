<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnTest = New System.Windows.Forms.Button()
        Me.txtbxData = New System.Windows.Forms.TextBox()
        Me.lblRandom = New System.Windows.Forms.Label()
        Me.lblItems = New System.Windows.Forms.Label()
        Me.txtbxReport = New System.Windows.Forms.TextBox()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(40, 211)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 23)
        Me.btnTest.TabIndex = 0
        Me.btnTest.Text = "TEST"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'txtbxData
        '
        Me.txtbxData.Location = New System.Drawing.Point(12, 49)
        Me.txtbxData.Multiline = True
        Me.txtbxData.Name = "txtbxData"
        Me.txtbxData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtbxData.Size = New System.Drawing.Size(136, 141)
        Me.txtbxData.TabIndex = 1
        '
        'lblRandom
        '
        Me.lblRandom.AutoSize = True
        Me.lblRandom.Location = New System.Drawing.Point(13, 30)
        Me.lblRandom.Name = "lblRandom"
        Me.lblRandom.Size = New System.Drawing.Size(92, 13)
        Me.lblRandom.TabIndex = 2
        Me.lblRandom.Text = "Random Numbers"
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        Me.lblItems.Location = New System.Drawing.Point(172, 90)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(107, 13)
        Me.lblItems.TabIndex = 3
        Me.lblItems.Text = "Number of ITEMS >>"
        '
        'txtbxReport
        '
        Me.txtbxReport.Location = New System.Drawing.Point(312, 49)
        Me.txtbxReport.Multiline = True
        Me.txtbxReport.Name = "txtbxReport"
        Me.txtbxReport.Size = New System.Drawing.Size(161, 141)
        Me.txtbxReport.TabIndex = 4
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(172, 50)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(103, 13)
        Me.lblMin.TabIndex = 7
        Me.lblMin.Text = "Minimum Number >>"
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Location = New System.Drawing.Point(172, 70)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(106, 13)
        Me.lblMax.TabIndex = 8
        Me.lblMax.Text = "Maximum Number >>"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(172, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Average of the first 500 >>"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(355, 211)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Buxton Sketch", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(8, 277)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 45)
        Me.lblName.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 337)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.txtbxReport)
        Me.Controls.Add(Me.lblItems)
        Me.Controls.Add(Me.lblRandom)
        Me.Controls.Add(Me.txtbxData)
        Me.Controls.Add(Me.btnTest)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents txtbxData As System.Windows.Forms.TextBox
    Friend WithEvents lblRandom As System.Windows.Forms.Label
    Friend WithEvents lblItems As System.Windows.Forms.Label
    Friend WithEvents txtbxReport As System.Windows.Forms.TextBox
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents lblMax As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label

End Class

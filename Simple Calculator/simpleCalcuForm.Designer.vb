<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class simpleCalcuForm
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
        Me.systemPanel1 = New System.Windows.Forms.Panel()
        Me.resetBtn = New System.Windows.Forms.Button()
        Me.resultaInput = New System.Windows.Forms.TextBox()
        Me.resultLabel = New System.Windows.Forms.Label()
        Me.secNumInput = New System.Windows.Forms.TextBox()
        Me.firstNumInput = New System.Windows.Forms.TextBox()
        Me.secNumLabel = New System.Windows.Forms.Label()
        Me.firstNumLabel = New System.Windows.Forms.Label()
        Me.headerPanel = New System.Windows.Forms.Panel()
        Me.subHeader = New System.Windows.Forms.Label()
        Me.headerLabel = New System.Windows.Forms.Label()
        Me.divBtn = New System.Windows.Forms.Button()
        Me.subBtn = New System.Windows.Forms.Button()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.multiBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.PictureBox()
        Me.simpleCalcuLogo = New System.Windows.Forms.PictureBox()
        Me.systemPanel1.SuspendLayout()
        Me.headerPanel.SuspendLayout()
        CType(Me.exitBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.simpleCalcuLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'systemPanel1
        '
        Me.systemPanel1.Controls.Add(Me.resetBtn)
        Me.systemPanel1.Controls.Add(Me.resultaInput)
        Me.systemPanel1.Controls.Add(Me.resultLabel)
        Me.systemPanel1.Controls.Add(Me.divBtn)
        Me.systemPanel1.Controls.Add(Me.subBtn)
        Me.systemPanel1.Controls.Add(Me.addBtn)
        Me.systemPanel1.Controls.Add(Me.multiBtn)
        Me.systemPanel1.Controls.Add(Me.secNumInput)
        Me.systemPanel1.Controls.Add(Me.firstNumInput)
        Me.systemPanel1.Controls.Add(Me.secNumLabel)
        Me.systemPanel1.Controls.Add(Me.firstNumLabel)
        Me.systemPanel1.Controls.Add(Me.headerPanel)
        Me.systemPanel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.systemPanel1.Location = New System.Drawing.Point(0, -3)
        Me.systemPanel1.Name = "systemPanel1"
        Me.systemPanel1.Size = New System.Drawing.Size(640, 365)
        Me.systemPanel1.TabIndex = 1
        '
        'resetBtn
        '
        Me.resetBtn.BackColor = System.Drawing.Color.White
        Me.resetBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.resetBtn.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetBtn.Location = New System.Drawing.Point(449, 281)
        Me.resetBtn.Name = "resetBtn"
        Me.resetBtn.Size = New System.Drawing.Size(99, 47)
        Me.resetBtn.TabIndex = 13
        Me.resetBtn.Text = "RESET"
        Me.resetBtn.UseVisualStyleBackColor = False
        '
        'resultaInput
        '
        Me.resultaInput.BackColor = System.Drawing.Color.White
        Me.resultaInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.resultaInput.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultaInput.ForeColor = System.Drawing.Color.Black
        Me.resultaInput.Location = New System.Drawing.Point(327, 206)
        Me.resultaInput.Multiline = True
        Me.resultaInput.Name = "resultaInput"
        Me.resultaInput.Size = New System.Drawing.Size(252, 38)
        Me.resultaInput.TabIndex = 12
        '
        'resultLabel
        '
        Me.resultLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.resultLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultLabel.ForeColor = System.Drawing.Color.Black
        Me.resultLabel.Location = New System.Drawing.Point(199, 206)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(122, 38)
        Me.resultLabel.TabIndex = 11
        Me.resultLabel.Text = "Resulta:"
        Me.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'secNumInput
        '
        Me.secNumInput.BackColor = System.Drawing.Color.White
        Me.secNumInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.secNumInput.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secNumInput.ForeColor = System.Drawing.Color.Black
        Me.secNumInput.Location = New System.Drawing.Point(327, 162)
        Me.secNumInput.Multiline = True
        Me.secNumInput.Name = "secNumInput"
        Me.secNumInput.Size = New System.Drawing.Size(252, 38)
        Me.secNumInput.TabIndex = 7
        '
        'firstNumInput
        '
        Me.firstNumInput.BackColor = System.Drawing.Color.White
        Me.firstNumInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.firstNumInput.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNumInput.ForeColor = System.Drawing.Color.Black
        Me.firstNumInput.Location = New System.Drawing.Point(327, 118)
        Me.firstNumInput.Multiline = True
        Me.firstNumInput.Name = "firstNumInput"
        Me.firstNumInput.Size = New System.Drawing.Size(252, 38)
        Me.firstNumInput.TabIndex = 6
        '
        'secNumLabel
        '
        Me.secNumLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.secNumLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secNumLabel.ForeColor = System.Drawing.Color.Black
        Me.secNumLabel.Location = New System.Drawing.Point(53, 162)
        Me.secNumLabel.Name = "secNumLabel"
        Me.secNumLabel.Size = New System.Drawing.Size(268, 38)
        Me.secNumLabel.TabIndex = 5
        Me.secNumLabel.Text = "Ikalawang Numero:"
        Me.secNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'firstNumLabel
        '
        Me.firstNumLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.firstNumLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNumLabel.ForeColor = System.Drawing.Color.Black
        Me.firstNumLabel.Location = New System.Drawing.Point(99, 118)
        Me.firstNumLabel.Name = "firstNumLabel"
        Me.firstNumLabel.Size = New System.Drawing.Size(222, 38)
        Me.firstNumLabel.TabIndex = 4
        Me.firstNumLabel.Text = "Unang Numero:"
        Me.firstNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'headerPanel
        '
        Me.headerPanel.BackColor = System.Drawing.Color.Black
        Me.headerPanel.Controls.Add(Me.exitBtn)
        Me.headerPanel.Controls.Add(Me.subHeader)
        Me.headerPanel.Controls.Add(Me.simpleCalcuLogo)
        Me.headerPanel.Controls.Add(Me.headerLabel)
        Me.headerPanel.Cursor = System.Windows.Forms.Cursors.Default
        Me.headerPanel.Location = New System.Drawing.Point(0, 3)
        Me.headerPanel.Name = "headerPanel"
        Me.headerPanel.Size = New System.Drawing.Size(640, 103)
        Me.headerPanel.TabIndex = 1
        '
        'subHeader
        '
        Me.subHeader.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subHeader.ForeColor = System.Drawing.Color.White
        Me.subHeader.Location = New System.Drawing.Point(120, 53)
        Me.subHeader.Name = "subHeader"
        Me.subHeader.Size = New System.Drawing.Size(348, 38)
        Me.subHeader.TabIndex = 2
        Me.subHeader.Text = "Simple Calculator Software | Copyright 2022" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SCS Version 1 2022" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'headerLabel
        '
        Me.headerLabel.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerLabel.ForeColor = System.Drawing.Color.White
        Me.headerLabel.Location = New System.Drawing.Point(116, 0)
        Me.headerLabel.Name = "headerLabel"
        Me.headerLabel.Size = New System.Drawing.Size(352, 53)
        Me.headerLabel.TabIndex = 1
        Me.headerLabel.Text = "Simple Calculator"
        Me.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'divBtn
        '
        Me.divBtn.BackColor = System.Drawing.Color.White
        Me.divBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.divBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.divBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.divBtn.ForeColor = System.Drawing.Color.White
        Me.divBtn.Image = Global.Simple_Calculator.My.Resources.Resources.division_sysmbol
        Me.divBtn.Location = New System.Drawing.Point(358, 267)
        Me.divBtn.Name = "divBtn"
        Me.divBtn.Size = New System.Drawing.Size(75, 75)
        Me.divBtn.TabIndex = 10
        Me.divBtn.UseVisualStyleBackColor = False
        '
        'subBtn
        '
        Me.subBtn.BackColor = System.Drawing.Color.White
        Me.subBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.subBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.subBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subBtn.ForeColor = System.Drawing.Color.White
        Me.subBtn.Image = Global.Simple_Calculator.My.Resources.Resources.minus_icon
        Me.subBtn.Location = New System.Drawing.Point(175, 267)
        Me.subBtn.Name = "subBtn"
        Me.subBtn.Size = New System.Drawing.Size(75, 75)
        Me.subBtn.TabIndex = 9
        Me.subBtn.UseVisualStyleBackColor = False
        '
        'addBtn
        '
        Me.addBtn.BackColor = System.Drawing.Color.White
        Me.addBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addBtn.ForeColor = System.Drawing.Color.White
        Me.addBtn.Image = Global.Simple_Calculator.My.Resources.Resources.plus_icon
        Me.addBtn.Location = New System.Drawing.Point(84, 267)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(75, 75)
        Me.addBtn.TabIndex = 8
        Me.addBtn.UseVisualStyleBackColor = False
        '
        'multiBtn
        '
        Me.multiBtn.BackColor = System.Drawing.Color.White
        Me.multiBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.multiBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.multiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.multiBtn.ForeColor = System.Drawing.Color.White
        Me.multiBtn.Image = Global.Simple_Calculator.My.Resources.Resources.times_icon
        Me.multiBtn.Location = New System.Drawing.Point(265, 267)
        Me.multiBtn.Name = "multiBtn"
        Me.multiBtn.Size = New System.Drawing.Size(75, 75)
        Me.multiBtn.TabIndex = 9
        Me.multiBtn.UseVisualStyleBackColor = False
        '
        'exitBtn
        '
        Me.exitBtn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exitBtn.Image = Global.Simple_Calculator.My.Resources.Resources._24_Pixel_Exit_Icon_Red
        Me.exitBtn.Location = New System.Drawing.Point(613, 3)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(25, 25)
        Me.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.exitBtn.TabIndex = 3
        Me.exitBtn.TabStop = False
        '
        'simpleCalcuLogo
        '
        Me.simpleCalcuLogo.Image = Global.Simple_Calculator.My.Resources.Resources.calculator_icon
        Me.simpleCalcuLogo.Location = New System.Drawing.Point(29, 12)
        Me.simpleCalcuLogo.Name = "simpleCalcuLogo"
        Me.simpleCalcuLogo.Size = New System.Drawing.Size(81, 79)
        Me.simpleCalcuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.simpleCalcuLogo.TabIndex = 1
        Me.simpleCalcuLogo.TabStop = False
        '
        'simpleCalcuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(640, 365)
        Me.Controls.Add(Me.systemPanel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "simpleCalcuForm"
        Me.Text = "Simple Calculator"
        Me.systemPanel1.ResumeLayout(False)
        Me.systemPanel1.PerformLayout()
        Me.headerPanel.ResumeLayout(False)
        CType(Me.exitBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.simpleCalcuLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents systemPanel1 As Panel
    Friend WithEvents headerPanel As Panel
    Friend WithEvents exitBtn As PictureBox
    Friend WithEvents subHeader As Label
    Friend WithEvents simpleCalcuLogo As PictureBox
    Friend WithEvents headerLabel As Label
    Friend WithEvents firstNumLabel As Label
    Friend WithEvents secNumLabel As Label
    Friend WithEvents firstNumInput As TextBox
    Friend WithEvents secNumInput As TextBox
    Friend WithEvents divBtn As Button
    Friend WithEvents subBtn As Button
    Friend WithEvents addBtn As Button
    Friend WithEvents multiBtn As Button
    Friend WithEvents resultLabel As Label
    Friend WithEvents resultaInput As TextBox
    Friend WithEvents resetBtn As Button
End Class

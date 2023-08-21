<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTittle = New Label()
        lblPlayerOne = New Label()
        lblPlayerTwo = New Label()
        lblScoreOne = New Label()
        lblScoreTwo = New Label()
        btnReset = New Button()
        btnExit = New Button()
        btnBoard1 = New Button()
        btnBoard2 = New Button()
        btnBoard3 = New Button()
        btnBoard4 = New Button()
        btnBoard5 = New Button()
        btnBoard6 = New Button()
        btnBoard7 = New Button()
        btnBoard8 = New Button()
        btnBoard9 = New Button()
        lblWinner = New Label()
        SuspendLayout()
        ' 
        ' lblTittle
        ' 
        lblTittle.AutoSize = True
        lblTittle.Font = New Font("Stencil", 16F, FontStyle.Bold, GraphicsUnit.Point)
        lblTittle.ForeColor = SystemColors.MenuText
        lblTittle.Location = New Point(417, 9)
        lblTittle.Name = "lblTittle"
        lblTittle.Size = New Size(193, 38)
        lblTittle.TabIndex = 0
        lblTittle.Text = "TicTacToe"
        ' 
        ' lblPlayerOne
        ' 
        lblPlayerOne.AutoSize = True
        lblPlayerOne.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point)
        lblPlayerOne.Location = New Point(159, 88)
        lblPlayerOne.Name = "lblPlayerOne"
        lblPlayerOne.Size = New Size(123, 45)
        lblPlayerOne.TabIndex = 1
        lblPlayerOne.Text = "Plyer 1"
        ' 
        ' lblPlayerTwo
        ' 
        lblPlayerTwo.AutoSize = True
        lblPlayerTwo.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point)
        lblPlayerTwo.Location = New Point(614, 83)
        lblPlayerTwo.Name = "lblPlayerTwo"
        lblPlayerTwo.Size = New Size(123, 45)
        lblPlayerTwo.TabIndex = 2
        lblPlayerTwo.Text = "Plyer 2"
        ' 
        ' lblScoreOne
        ' 
        lblScoreOne.AutoSize = True
        lblScoreOne.BorderStyle = BorderStyle.Fixed3D
        lblScoreOne.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        lblScoreOne.Location = New Point(288, 83)
        lblScoreOne.MaximumSize = New Size(100, 50)
        lblScoreOne.MinimumSize = New Size(100, 50)
        lblScoreOne.Name = "lblScoreOne"
        lblScoreOne.Size = New Size(100, 50)
        lblScoreOne.TabIndex = 3
        lblScoreOne.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblScoreTwo
        ' 
        lblScoreTwo.AutoSize = True
        lblScoreTwo.BorderStyle = BorderStyle.Fixed3D
        lblScoreTwo.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        lblScoreTwo.Location = New Point(743, 78)
        lblScoreTwo.MaximumSize = New Size(100, 50)
        lblScoreTwo.MinimumSize = New Size(100, 50)
        lblScoreTwo.Name = "lblScoreTwo"
        lblScoreTwo.Size = New Size(100, 50)
        lblScoreTwo.TabIndex = 4
        lblScoreTwo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = SystemColors.ActiveCaption
        btnReset.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnReset.Location = New Point(782, 529)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(178, 47)
        btnReset.TabIndex = 5
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = SystemColors.ActiveCaption
        btnExit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnExit.Location = New Point(12, 526)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(178, 53)
        btnExit.TabIndex = 6
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnBoard1
        ' 
        btnBoard1.Font = New Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point)
        btnBoard1.Location = New Point(319, 214)
        btnBoard1.Name = "btnBoard1"
        btnBoard1.Size = New Size(110, 96)
        btnBoard1.TabIndex = 7
        btnBoard1.UseVisualStyleBackColor = True
        ' 
        ' btnBoard2
        ' 
        btnBoard2.Font = New Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point)
        btnBoard2.Location = New Point(453, 214)
        btnBoard2.Name = "btnBoard2"
        btnBoard2.Size = New Size(110, 96)
        btnBoard2.TabIndex = 8
        btnBoard2.UseVisualStyleBackColor = True
        ' 
        ' btnBoard3
        ' 
        btnBoard3.Font = New Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point)
        btnBoard3.Location = New Point(587, 214)
        btnBoard3.Name = "btnBoard3"
        btnBoard3.Size = New Size(110, 96)
        btnBoard3.TabIndex = 9
        btnBoard3.UseVisualStyleBackColor = True
        ' 
        ' btnBoard4
        ' 
        btnBoard4.Font = New Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point)
        btnBoard4.Location = New Point(319, 338)
        btnBoard4.Name = "btnBoard4"
        btnBoard4.Size = New Size(110, 96)
        btnBoard4.TabIndex = 10
        btnBoard4.UseVisualStyleBackColor = True
        ' 
        ' btnBoard5
        ' 
        btnBoard5.Font = New Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point)
        btnBoard5.Location = New Point(453, 338)
        btnBoard5.Name = "btnBoard5"
        btnBoard5.Size = New Size(110, 96)
        btnBoard5.TabIndex = 11
        btnBoard5.UseVisualStyleBackColor = True
        ' 
        ' btnBoard6
        ' 
        btnBoard6.Font = New Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point)
        btnBoard6.Location = New Point(587, 338)
        btnBoard6.Name = "btnBoard6"
        btnBoard6.Size = New Size(110, 96)
        btnBoard6.TabIndex = 12
        btnBoard6.UseVisualStyleBackColor = True
        ' 
        ' btnBoard7
        ' 
        btnBoard7.Font = New Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point)
        btnBoard7.Location = New Point(319, 460)
        btnBoard7.Name = "btnBoard7"
        btnBoard7.Size = New Size(110, 96)
        btnBoard7.TabIndex = 13
        btnBoard7.UseVisualStyleBackColor = True
        ' 
        ' btnBoard8
        ' 
        btnBoard8.Font = New Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point)
        btnBoard8.Location = New Point(453, 460)
        btnBoard8.Name = "btnBoard8"
        btnBoard8.Size = New Size(110, 96)
        btnBoard8.TabIndex = 14
        btnBoard8.UseVisualStyleBackColor = True
        ' 
        ' btnBoard9
        ' 
        btnBoard9.Font = New Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point)
        btnBoard9.Location = New Point(587, 460)
        btnBoard9.Name = "btnBoard9"
        btnBoard9.Size = New Size(110, 96)
        btnBoard9.TabIndex = 15
        btnBoard9.UseVisualStyleBackColor = True
        ' 
        ' lblWinner
        ' 
        lblWinner.AutoSize = True
        lblWinner.Font = New Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point)
        lblWinner.Location = New Point(349, 150)
        lblWinner.MaximumSize = New Size(300, 50)
        lblWinner.MinimumSize = New Size(300, 50)
        lblWinner.Name = "lblWinner"
        lblWinner.Size = New Size(300, 50)
        lblWinner.TabIndex = 16
        lblWinner.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        ClientSize = New Size(972, 588)
        Controls.Add(lblWinner)
        Controls.Add(btnBoard9)
        Controls.Add(btnBoard8)
        Controls.Add(btnBoard7)
        Controls.Add(btnBoard6)
        Controls.Add(btnBoard5)
        Controls.Add(btnBoard4)
        Controls.Add(btnBoard3)
        Controls.Add(btnBoard2)
        Controls.Add(btnBoard1)
        Controls.Add(btnExit)
        Controls.Add(btnReset)
        Controls.Add(lblScoreTwo)
        Controls.Add(lblScoreOne)
        Controls.Add(lblPlayerTwo)
        Controls.Add(lblPlayerOne)
        Controls.Add(lblTittle)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTittle As Label
    Friend WithEvents lblPlayerOne As Label
    Friend WithEvents lblPlayerTwo As Label
    Friend WithEvents lblScoreOne As Label
    Friend WithEvents lblScoreTwo As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnBoard1 As Button
    Friend WithEvents btnBoard2 As Button
    Friend WithEvents btnBoard3 As Button
    Friend WithEvents btnBoard4 As Button
    Friend WithEvents btnBoard5 As Button
    Friend WithEvents btnBoard6 As Button
    Friend WithEvents btnBoard7 As Button
    Friend WithEvents btnBoard8 As Button
    Friend WithEvents btnBoard9 As Button
    Friend WithEvents lblWinner As Label
End Class

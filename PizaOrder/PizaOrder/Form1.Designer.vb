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
        lblPizzaVariety = New Label()
        lblSizeOfPizza = New Label()
        lblPizzaCrustStyle = New Label()
        cboPizzaVariety = New ComboBox()
        lbSizeOfPizza = New ListBox()
        rdbThickCrust = New RadioButton()
        rdbThinCrust = New RadioButton()
        GroupBox1 = New GroupBox()
        lblOutputCrust = New Label()
        lblOutputSize = New Label()
        lblCrust = New Label()
        lblSize = New Label()
        lblOutputVariety = New Label()
        lblVariety = New Label()
        btnNewOrder = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblPizzaVariety
        ' 
        lblPizzaVariety.AutoSize = True
        lblPizzaVariety.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        lblPizzaVariety.Location = New Point(58, 46)
        lblPizzaVariety.Name = "lblPizzaVariety"
        lblPizzaVariety.Size = New Size(191, 38)
        lblPizzaVariety.TabIndex = 0
        lblPizzaVariety.Text = "Pizza Variety "
        ' 
        ' lblSizeOfPizza
        ' 
        lblSizeOfPizza.AutoSize = True
        lblSizeOfPizza.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        lblSizeOfPizza.Location = New Point(99, 123)
        lblSizeOfPizza.Name = "lblSizeOfPizza"
        lblSizeOfPizza.Size = New Size(179, 38)
        lblSizeOfPizza.TabIndex = 1
        lblSizeOfPizza.Text = "Size of Pizza"
        ' 
        ' lblPizzaCrustStyle
        ' 
        lblPizzaCrustStyle.AutoSize = True
        lblPizzaCrustStyle.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        lblPizzaCrustStyle.Location = New Point(58, 279)
        lblPizzaCrustStyle.Name = "lblPizzaCrustStyle"
        lblPizzaCrustStyle.Size = New Size(231, 38)
        lblPizzaCrustStyle.TabIndex = 2
        lblPizzaCrustStyle.Text = "Pizza Crust Style"
        ' 
        ' cboPizzaVariety
        ' 
        cboPizzaVariety.BackColor = SystemColors.ScrollBar
        cboPizzaVariety.DropDownStyle = ComboBoxStyle.DropDownList
        cboPizzaVariety.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        cboPizzaVariety.FormattingEnabled = True
        cboPizzaVariety.Location = New Point(238, 48)
        cboPizzaVariety.Name = "cboPizzaVariety"
        cboPizzaVariety.Size = New Size(264, 40)
        cboPizzaVariety.TabIndex = 3
        ' 
        ' lbSizeOfPizza
        ' 
        lbSizeOfPizza.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lbSizeOfPizza.FormattingEnabled = True
        lbSizeOfPizza.ItemHeight = 32
        lbSizeOfPizza.Location = New Point(284, 123)
        lbSizeOfPizza.Name = "lbSizeOfPizza"
        lbSizeOfPizza.Size = New Size(218, 132)
        lbSizeOfPizza.TabIndex = 4
        ' 
        ' rdbThickCrust
        ' 
        rdbThickCrust.AutoSize = True
        rdbThickCrust.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rdbThickCrust.Location = New Point(295, 282)
        rdbThickCrust.Name = "rdbThickCrust"
        rdbThickCrust.Size = New Size(160, 36)
        rdbThickCrust.TabIndex = 5
        rdbThickCrust.TabStop = True
        rdbThickCrust.Text = "Thick Crust"
        rdbThickCrust.UseVisualStyleBackColor = True
        ' 
        ' rdbThinCrust
        ' 
        rdbThinCrust.AutoSize = True
        rdbThinCrust.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rdbThinCrust.Location = New Point(295, 324)
        rdbThinCrust.Name = "rdbThinCrust"
        rdbThinCrust.Size = New Size(150, 36)
        rdbThinCrust.TabIndex = 6
        rdbThinCrust.TabStop = True
        rdbThinCrust.Text = "Thin Crust"
        rdbThinCrust.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblOutputCrust)
        GroupBox1.Controls.Add(lblOutputSize)
        GroupBox1.Controls.Add(lblCrust)
        GroupBox1.Controls.Add(lblSize)
        GroupBox1.Controls.Add(lblOutputVariety)
        GroupBox1.Controls.Add(lblVariety)
        GroupBox1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        GroupBox1.Location = New Point(577, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(544, 306)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Your Order"
        ' 
        ' lblOutputCrust
        ' 
        lblOutputCrust.BackColor = SystemColors.ButtonHighlight
        lblOutputCrust.BorderStyle = BorderStyle.Fixed3D
        lblOutputCrust.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        lblOutputCrust.ForeColor = Color.Black
        lblOutputCrust.Location = New Point(161, 205)
        lblOutputCrust.Name = "lblOutputCrust"
        lblOutputCrust.Size = New Size(361, 45)
        lblOutputCrust.TabIndex = 5
        ' 
        ' lblOutputSize
        ' 
        lblOutputSize.BackColor = SystemColors.ButtonHighlight
        lblOutputSize.BorderStyle = BorderStyle.Fixed3D
        lblOutputSize.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        lblOutputSize.ForeColor = Color.Black
        lblOutputSize.Location = New Point(161, 137)
        lblOutputSize.Name = "lblOutputSize"
        lblOutputSize.Size = New Size(361, 45)
        lblOutputSize.TabIndex = 4
        ' 
        ' lblCrust
        ' 
        lblCrust.AutoSize = True
        lblCrust.Location = New Point(53, 205)
        lblCrust.Name = "lblCrust"
        lblCrust.Size = New Size(93, 38)
        lblCrust.TabIndex = 3
        lblCrust.Text = "Crust:"
        ' 
        ' lblSize
        ' 
        lblSize.AutoSize = True
        lblSize.Location = New Point(69, 137)
        lblSize.Name = "lblSize"
        lblSize.Size = New Size(77, 38)
        lblSize.TabIndex = 2
        lblSize.Text = "Size:"
        ' 
        ' lblOutputVariety
        ' 
        lblOutputVariety.BackColor = SystemColors.ButtonHighlight
        lblOutputVariety.BorderStyle = BorderStyle.Fixed3D
        lblOutputVariety.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        lblOutputVariety.ForeColor = Color.Black
        lblOutputVariety.Location = New Point(161, 59)
        lblOutputVariety.Name = "lblOutputVariety"
        lblOutputVariety.Size = New Size(361, 45)
        lblOutputVariety.TabIndex = 1
        ' 
        ' lblVariety
        ' 
        lblVariety.AutoSize = True
        lblVariety.Location = New Point(29, 59)
        lblVariety.Name = "lblVariety"
        lblVariety.Size = New Size(117, 38)
        lblVariety.TabIndex = 0
        lblVariety.Text = "Variety:"
        ' 
        ' btnNewOrder
        ' 
        btnNewOrder.BackColor = SystemColors.ActiveBorder
        btnNewOrder.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        btnNewOrder.Location = New Point(891, 332)
        btnNewOrder.Name = "btnNewOrder"
        btnNewOrder.Size = New Size(208, 47)
        btnNewOrder.TabIndex = 8
        btnNewOrder.Text = "New Order"
        btnNewOrder.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1133, 391)
        Controls.Add(btnNewOrder)
        Controls.Add(GroupBox1)
        Controls.Add(rdbThinCrust)
        Controls.Add(rdbThickCrust)
        Controls.Add(lbSizeOfPizza)
        Controls.Add(cboPizzaVariety)
        Controls.Add(lblPizzaCrustStyle)
        Controls.Add(lblSizeOfPizza)
        Controls.Add(lblPizzaVariety)
        Name = "Form1"
        Text = "Piza Order"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblPizzaVariety As Label
    Friend WithEvents lblSizeOfPizza As Label
    Friend WithEvents lblPizzaCrustStyle As Label
    Friend WithEvents cboPizzaVariety As ComboBox
    Friend WithEvents lbSizeOfPizza As ListBox
    Friend WithEvents rdbThickCrust As RadioButton
    Friend WithEvents rdbThinCrust As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblOutputCrust As Label
    Friend WithEvents lblOutputSize As Label
    Friend WithEvents lblCrust As Label
    Friend WithEvents lblSize As Label
    Friend WithEvents lblOutputVariety As Label
    Friend WithEvents lblVariety As Label
    Friend WithEvents btnNewOrder As Button
End Class

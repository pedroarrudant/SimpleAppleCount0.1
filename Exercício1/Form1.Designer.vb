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
        Me.BtnqntdMacas = New System.Windows.Forms.Button()
        Me.TxtqntdMacas = New System.Windows.Forms.TextBox()
        Me.lblqntdMacas = New System.Windows.Forms.Label()
        Me.PctMaca = New System.Windows.Forms.PictureBox()
        Me.LbltotalMacas = New System.Windows.Forms.Label()
        Me.LblvalorMacas = New System.Windows.Forms.Label()
        Me.Btnsair = New System.Windows.Forms.Button()
        CType(Me.PctMaca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnqntdMacas
        '
        Me.BtnqntdMacas.Location = New System.Drawing.Point(227, 54)
        Me.BtnqntdMacas.Name = "BtnqntdMacas"
        Me.BtnqntdMacas.Size = New System.Drawing.Size(83, 38)
        Me.BtnqntdMacas.TabIndex = 0
        Me.BtnqntdMacas.Text = "Calcular"
        Me.BtnqntdMacas.UseVisualStyleBackColor = True
        '
        'TxtqntdMacas
        '
        Me.TxtqntdMacas.Location = New System.Drawing.Point(155, 28)
        Me.TxtqntdMacas.Name = "TxtqntdMacas"
        Me.TxtqntdMacas.Size = New System.Drawing.Size(155, 20)
        Me.TxtqntdMacas.TabIndex = 1
        '
        'lblqntdMacas
        '
        Me.lblqntdMacas.AutoSize = True
        Me.lblqntdMacas.Location = New System.Drawing.Point(12, 35)
        Me.lblqntdMacas.Name = "lblqntdMacas"
        Me.lblqntdMacas.Size = New System.Drawing.Size(114, 13)
        Me.lblqntdMacas.TabIndex = 2
        Me.lblqntdMacas.Text = "Quantidade de maçãs:"
        '
        'PctMaca
        '
        Me.PctMaca.InitialImage = Nothing
        Me.PctMaca.Location = New System.Drawing.Point(14, 97)
        Me.PctMaca.Name = "PctMaca"
        Me.PctMaca.Size = New System.Drawing.Size(132, 115)
        Me.PctMaca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctMaca.TabIndex = 3
        Me.PctMaca.TabStop = False
        '
        'LbltotalMacas
        '
        Me.LbltotalMacas.AutoSize = True
        Me.LbltotalMacas.Location = New System.Drawing.Point(152, 104)
        Me.LbltotalMacas.Name = "LbltotalMacas"
        Me.LbltotalMacas.Size = New System.Drawing.Size(99, 13)
        Me.LbltotalMacas.TabIndex = 4
        Me.LbltotalMacas.Text = "O total de maçãs é:"
        '
        'LblvalorMacas
        '
        Me.LblvalorMacas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblvalorMacas.Location = New System.Drawing.Point(155, 146)
        Me.LblvalorMacas.Name = "LblvalorMacas"
        Me.LblvalorMacas.Size = New System.Drawing.Size(155, 20)
        Me.LblvalorMacas.TabIndex = 5
        '
        'Btnsair
        '
        Me.Btnsair.Location = New System.Drawing.Point(143, 54)
        Me.Btnsair.Name = "Btnsair"
        Me.Btnsair.Size = New System.Drawing.Size(78, 37)
        Me.Btnsair.TabIndex = 6
        Me.Btnsair.Text = "Sair"
        Me.Btnsair.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 221)
        Me.Controls.Add(Me.Btnsair)
        Me.Controls.Add(Me.LblvalorMacas)
        Me.Controls.Add(Me.LbltotalMacas)
        Me.Controls.Add(Me.PctMaca)
        Me.Controls.Add(Me.lblqntdMacas)
        Me.Controls.Add(Me.TxtqntdMacas)
        Me.Controls.Add(Me.BtnqntdMacas)
        Me.Name = "Form1"
        Me.Text = "Valor das Maçãs"
        CType(Me.PctMaca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnqntdMacas As System.Windows.Forms.Button
    Friend WithEvents TxtqntdMacas As System.Windows.Forms.TextBox
    Friend WithEvents lblqntdMacas As System.Windows.Forms.Label
    Friend WithEvents PctMaca As System.Windows.Forms.PictureBox
    Friend WithEvents LbltotalMacas As System.Windows.Forms.Label
    Friend WithEvents LblvalorMacas As System.Windows.Forms.Label
    Friend WithEvents Btnsair As System.Windows.Forms.Button

End Class

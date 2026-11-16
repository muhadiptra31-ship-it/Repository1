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
        txtBerat = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        lblHasil = New Label()
        btnHitung = New Button()
        cmbTujuan = New ComboBox()
        SuspendLayout()
        ' 
        ' txtBerat
        ' 
        txtBerat.Location = New Point(369, 135)
        txtBerat.Name = "txtBerat"
        txtBerat.Size = New Size(100, 23)
        txtBerat.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(190, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 2
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(205, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 3
        Label2.Text = "Label2"
        ' 
        ' lblHasil
        ' 
        lblHasil.BackColor = SystemColors.ControlDarkDark
        lblHasil.Location = New Point(146, 199)
        lblHasil.Name = "lblHasil"
        lblHasil.Size = New Size(295, 23)
        lblHasil.TabIndex = 4
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(248, 243)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(75, 23)
        btnHitung.TabIndex = 5
        btnHitung.Text = "Button1"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' cmbTujuan
        ' 
        cmbTujuan.FormattingEnabled = True
        cmbTujuan.Location = New Point(334, 73)
        cmbTujuan.Name = "cmbTujuan"
        cmbTujuan.Size = New Size(121, 23)
        cmbTujuan.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(512, 280)
        Controls.Add(cmbTujuan)
        Controls.Add(btnHitung)
        Controls.Add(lblHasil)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtBerat)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtBerat As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblHasil As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents cmbTujuan As ComboBox
End Class

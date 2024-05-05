<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Registration
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(175, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 21)
        Label1.TabIndex = 0
        Label1.Text = "User Registration"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(63, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 1
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(63, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(63, 227)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 15)
        Label4.TabIndex = 3
        Label4.Text = "First Name "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(63, 281)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 15)
        Label5.TabIndex = 4
        Label5.Text = "Last Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(63, 336)
        Label6.Name = "Label6"
        Label6.Size = New Size(36, 15)
        Label6.TabIndex = 5
        Label6.Text = "Email"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(186, 429)
        Button1.Name = "Button1"
        Button1.Size = New Size(88, 31)
        Button1.TabIndex = 11
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(-1, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(63, 23)
        Button2.TabIndex = 12
        Button2.Text = "Back"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Control
        TextBox1.Location = New Point(166, 125)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(201, 23)
        TextBox1.TabIndex = 13
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.Control
        TextBox2.Location = New Point(166, 174)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(201, 23)
        TextBox2.TabIndex = 14
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.Control
        TextBox3.Location = New Point(166, 227)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(201, 23)
        TextBox3.TabIndex = 15
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.Control
        TextBox4.Location = New Point(166, 281)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(201, 23)
        TextBox4.TabIndex = 16
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = SystemColors.Control
        TextBox5.Location = New Point(166, 336)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(201, 23)
        TextBox5.TabIndex = 17
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = SystemColors.Control
        TextBox6.Location = New Point(166, 383)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(201, 23)
        TextBox6.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(63, 386)
        Label7.Name = "Label7"
        Label7.Size = New Size(30, 15)
        Label7.TabIndex = 19
        Label7.Text = "Role"
        ' 
        ' User_Registration
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(486, 492)
        Controls.Add(Label7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "User_Registration"
        Text = "User_Registration"
        TransparencyKey = Color.White
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
End Class

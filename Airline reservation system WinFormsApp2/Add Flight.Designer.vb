<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Flight
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
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(208, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 25)
        Label1.TabIndex = 0
        Label1.Text = "Add Flight"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 176)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 15)
        Label2.TabIndex = 1
        Label2.Text = " flight Id to be added"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(194, 168)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(138, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(68, 231)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 15)
        Label4.TabIndex = 5
        Label4.Text = "Flight Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(68, 276)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 15)
        Label5.TabIndex = 6
        Label5.Text = "Leaving From"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(68, 325)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 15)
        Label6.TabIndex = 7
        Label6.Text = "Going To"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(68, 372)
        Label7.Name = "Label7"
        Label7.Size = New Size(86, 15)
        Label7.TabIndex = 8
        Label7.Text = "Departure Date"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(68, 421)
        Label8.Name = "Label8"
        Label8.Size = New Size(71, 15)
        Label8.TabIndex = 9
        Label8.Text = "Depart Time"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(68, 463)
        Label9.Name = "Label9"
        Label9.Size = New Size(36, 15)
        Label9.TabIndex = 10
        Label9.Text = "Price "
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(194, 223)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 12
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(194, 268)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 13
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(194, 317)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 14
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(194, 364)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 15
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(194, 413)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(100, 23)
        TextBox7.TabIndex = 16
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(194, 455)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(100, 23)
        TextBox8.TabIndex = 17
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(283, 507)
        Button2.Name = "Button2"
        Button2.Size = New Size(95, 38)
        Button2.TabIndex = 18
        Button2.Text = "Add"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(464, -1)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 19
        Button3.Text = "Log Out"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(-4, -1)
        Button4.Name = "Button4"
        Button4.Size = New Size(62, 23)
        Button4.TabIndex = 20
        Button4.Text = "Back"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Add_Flight
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightBlue
        ClientSize = New Size(537, 557)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Add_Flight"
        Text = "Add_Flight"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class

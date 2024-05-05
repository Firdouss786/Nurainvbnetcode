<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Book_Flight
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
        Label7 = New Label()
        Label8 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox6 = New TextBox()
        Button1 = New Button()
        Label9 = New Label()
        TextBox7 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(142, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 25)
        Label1.TabIndex = 0
        Label1.Text = "Book Flight"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(75, 138)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 15)
        Label2.TabIndex = 1
        Label2.Text = "Flight Id"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(72, 177)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 15)
        Label3.TabIndex = 2
        Label3.Text = "Flight Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(75, 216)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 15)
        Label4.TabIndex = 3
        Label4.Text = "Leaving From"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(75, 254)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 15)
        Label5.TabIndex = 4
        Label5.Text = "Going To"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(72, 292)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 15)
        Label6.TabIndex = 5
        Label6.Text = "Departure Date"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(75, 328)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 15)
        Label7.TabIndex = 6
        Label7.Text = "Depart Time"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(79, 371)
        Label8.Name = "Label8"
        Label8.Size = New Size(33, 15)
        Label8.TabIndex = 7
        Label8.Text = "Price"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(219, 130)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 8
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(219, 169)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 9
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(219, 208)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 10
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(219, 246)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 11
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(219, 363)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 13
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(219, 418)
        Button1.Name = "Button1"
        Button1.Size = New Size(113, 39)
        Button1.TabIndex = 14
        Button1.Text = "Book Flight"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(75, 100)
        Label9.Name = "Label9"
        Label9.Size = New Size(43, 15)
        Label9.TabIndex = 18
        Label9.Text = "User Id"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(219, 92)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(100, 23)
        TextBox7.TabIndex = 19
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(219, 284)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(100, 23)
        DateTimePicker1.TabIndex = 20
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Format = DateTimePickerFormat.Time
        DateTimePicker2.Location = New Point(219, 322)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(100, 23)
        DateTimePicker2.TabIndex = 21
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(386, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 22
        Button2.Text = "Log Out"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(-2, 0)
        Button3.Name = "Button3"
        Button3.Size = New Size(59, 23)
        Button3.TabIndex = 23
        Button3.Text = "Back"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Book_Flight
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(463, 478)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox7)
        Controls.Add(Label9)
        Controls.Add(Button1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Book_Flight"
        Text = "Book_Flight"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_Flight
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
        Button1 = New Button()
        Label8 = New Label()
        TextBox1 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Button2 = New Button()
        Button3 = New Button()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(184, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 21)
        Label1.TabIndex = 0
        Label1.Text = "Search  Flight"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(225, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 20)
        Label2.TabIndex = 1
        Label2.Text = "One Way Trip"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(64, 161)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 15)
        Label3.TabIndex = 2
        Label3.Text = "Leaving From"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(284, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 15)
        Label4.TabIndex = 3
        Label4.Text = "Going To"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(64, 227)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 15)
        Label5.TabIndex = 6
        Label5.Text = "Depart Date"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(330, 272)
        Button1.Name = "Button1"
        Button1.Size = New Size(126, 44)
        Button1.TabIndex = 14
        Button1.Text = "Search Flights"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(64, 117)
        Label8.Name = "Label8"
        Label8.Size = New Size(43, 15)
        Label8.TabIndex = 15
        Label8.Text = "User Id"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(149, 109)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 16
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = ""
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(149, 221)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(100, 23)
        DateTimePicker1.TabIndex = 17
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(430, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 18
        Button2.Text = "Log Out"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(1, 0)
        Button3.Name = "Button3"
        Button3.Size = New Size(64, 23)
        Button3.TabIndex = 19
        Button3.Text = "Back"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(149, 158)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 20
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(344, 161)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 21
        ' 
        ' Search_Flight
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(506, 380)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox1)
        Controls.Add(Label8)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Cursor = Cursors.IBeam
        Name = "Search_Flight"
        Text = "Search_Flight"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class

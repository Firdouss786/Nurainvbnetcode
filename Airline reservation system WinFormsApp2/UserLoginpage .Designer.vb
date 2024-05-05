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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        LinkLabel2 = New LinkLabel()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.SkyBlue
        Label1.Font = New Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(120, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(314, 26)
        Label1.TabIndex = 0
        Label1.Text = "AIRLINE RESERVATION SYSTEM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.SkyBlue
        Label2.Location = New Point(292, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 15)
        Label2.TabIndex = 1
        Label2.Text = "USERNAME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.SkyBlue
        Label3.Location = New Point(292, 186)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 15)
        Label3.TabIndex = 2
        Label3.Text = "PASSWORD"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Control
        TextBox1.Location = New Point(292, 147)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(201, 23)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.Control
        TextBox2.Location = New Point(292, 204)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(201, 23)
        TextBox2.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Control
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(345, 250)
        Button1.Name = "Button1"
        Button1.Size = New Size(102, 44)
        Button1.TabIndex = 5
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.BackColor = Color.SkyBlue
        LinkLabel2.Location = New Point(345, 338)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(89, 15)
        LinkLabel2.TabIndex = 7
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Create Account"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.SkyBlue
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(334, 312)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 15)
        Label4.TabIndex = 8
        Label4.Text = "Don't have an account?"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Screenshot_2024_04_06_041407
        ClientSize = New Size(626, 423)
        Controls.Add(Label4)
        Controls.Add(LinkLabel2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label4 As Label

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class

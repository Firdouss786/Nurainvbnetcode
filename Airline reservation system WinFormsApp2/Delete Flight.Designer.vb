<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delete_Flight
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
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(219, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 25)
        Label1.TabIndex = 0
        Label1.Text = "Delete Flight"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(79, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(170, 15)
        Label2.TabIndex = 1
        Label2.Text = "Enter the flight Id to be deleted"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(255, 85)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(156, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(200, 228)
        Button2.Name = "Button2"
        Button2.Size = New Size(80, 33)
        Button2.TabIndex = 18
        Button2.Text = "Delete"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(421, -1)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 19
        Button3.Text = "Log Out"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(-5, -1)
        Button4.Name = "Button4"
        Button4.Size = New Size(63, 23)
        Button4.TabIndex = 20
        Button4.Text = "Back"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Delete_Flight
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightBlue
        ClientSize = New Size(490, 500)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Delete_Flight"
        Text = "Delete_Flight"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class

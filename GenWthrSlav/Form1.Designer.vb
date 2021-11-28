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
        Me.lbl_dwnloaded = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_temp = New System.Windows.Forms.Label()
        Me.lbl_humid = New System.Windows.Forms.Label()
        Me.lbl_feels = New System.Windows.Forms.Label()
        Me.lbl_speed = New System.Windows.Forms.Label()
        Me.lbl_deg = New System.Windows.Forms.Label()
        Me.lbl_gust = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_dwnloaded
        '
        Me.lbl_dwnloaded.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_dwnloaded.Location = New System.Drawing.Point(12, 9)
        Me.lbl_dwnloaded.Name = "lbl_dwnloaded"
        Me.lbl_dwnloaded.Size = New System.Drawing.Size(600, 100)
        Me.lbl_dwnloaded.TabIndex = 0
        Me.lbl_dwnloaded.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Get Weather"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_temp
        '
        Me.lbl_temp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_temp.Location = New System.Drawing.Point(13, 144)
        Me.lbl_temp.Name = "lbl_temp"
        Me.lbl_temp.Size = New System.Drawing.Size(93, 35)
        Me.lbl_temp.TabIndex = 2
        Me.lbl_temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_humid
        '
        Me.lbl_humid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_humid.Location = New System.Drawing.Point(211, 144)
        Me.lbl_humid.Name = "lbl_humid"
        Me.lbl_humid.Size = New System.Drawing.Size(93, 35)
        Me.lbl_humid.TabIndex = 4
        Me.lbl_humid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_feels
        '
        Me.lbl_feels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_feels.Location = New System.Drawing.Point(112, 144)
        Me.lbl_feels.Name = "lbl_feels"
        Me.lbl_feels.Size = New System.Drawing.Size(93, 35)
        Me.lbl_feels.TabIndex = 5
        Me.lbl_feels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_speed
        '
        Me.lbl_speed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_speed.Location = New System.Drawing.Point(409, 144)
        Me.lbl_speed.Name = "lbl_speed"
        Me.lbl_speed.Size = New System.Drawing.Size(93, 35)
        Me.lbl_speed.TabIndex = 6
        Me.lbl_speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_deg
        '
        Me.lbl_deg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_deg.Location = New System.Drawing.Point(310, 144)
        Me.lbl_deg.Name = "lbl_deg"
        Me.lbl_deg.Size = New System.Drawing.Size(93, 35)
        Me.lbl_deg.TabIndex = 7
        Me.lbl_deg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_gust
        '
        Me.lbl_gust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_gust.Location = New System.Drawing.Point(508, 144)
        Me.lbl_gust.Name = "lbl_gust"
        Me.lbl_gust.Size = New System.Drawing.Size(93, 35)
        Me.lbl_gust.TabIndex = 8
        Me.lbl_gust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 314)
        Me.Controls.Add(Me.lbl_gust)
        Me.Controls.Add(Me.lbl_deg)
        Me.Controls.Add(Me.lbl_speed)
        Me.Controls.Add(Me.lbl_feels)
        Me.Controls.Add(Me.lbl_humid)
        Me.Controls.Add(Me.lbl_temp)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_dwnloaded)
        Me.Name = "Form1"
        Me.Text = "Weather "
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_dwnloaded As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_temp As Label
    Friend WithEvents lbl_humid As Label
    Friend WithEvents lbl_feels As Label
    Friend WithEvents lbl_speed As Label
    Friend WithEvents lbl_deg As Label
    Friend WithEvents lbl_gust As Label
End Class

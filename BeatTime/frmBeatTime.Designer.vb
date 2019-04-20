<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBeatTime
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBeatTime))
        Me.tmrBeat = New System.Windows.Forms.Timer(Me.components)
        Me.lblBeatTime = New System.Windows.Forms.Label()
        Me.pbTime = New System.Windows.Forms.ProgressBar()
        Me.lblT1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tmrBeat
        '
        Me.tmrBeat.Enabled = True
        Me.tmrBeat.Interval = 250
        '
        'lblBeatTime
        '
        Me.lblBeatTime.Font = New System.Drawing.Font("Courier New", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeatTime.ForeColor = System.Drawing.Color.Lime
        Me.lblBeatTime.Location = New System.Drawing.Point(3, -2)
        Me.lblBeatTime.Name = "lblBeatTime"
        Me.lblBeatTime.Size = New System.Drawing.Size(299, 69)
        Me.lblBeatTime.TabIndex = 0
        Me.lblBeatTime.Text = "@888.88"
        Me.lblBeatTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbTime
        '
        Me.pbTime.BackColor = System.Drawing.Color.Black
        Me.pbTime.Location = New System.Drawing.Point(0, 81)
        Me.pbTime.Margin = New System.Windows.Forms.Padding(0)
        Me.pbTime.Maximum = 1000
        Me.pbTime.Name = "pbTime"
        Me.pbTime.Size = New System.Drawing.Size(308, 10)
        Me.pbTime.Step = 1
        Me.pbTime.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbTime.TabIndex = 2
        '
        'lblT1
        '
        Me.lblT1.ForeColor = System.Drawing.Color.Aqua
        Me.lblT1.Location = New System.Drawing.Point(0, 91)
        Me.lblT1.Name = "lblT1"
        Me.lblT1.Size = New System.Drawing.Size(32, 13)
        Me.lblT1.TabIndex = 3
        Me.lblT1.Text = "9am"
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Aqua
        Me.Label1.Location = New System.Drawing.Point(278, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "9am"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(143, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "9pmam"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(73, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "3pm"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(215, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "3am"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Aqua
        Me.Label5.Location = New System.Drawing.Point(0, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "@0"
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(205, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "@750"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(68, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "@250"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(139, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 14)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "@500"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.Aqua
        Me.Label9.Location = New System.Drawing.Point(248, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "@0"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmBeatTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(308, 106)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblT1)
        Me.Controls.Add(Me.pbTime)
        Me.Controls.Add(Me.lblBeatTime)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBeatTime"
        Me.Text = "BeatTime"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrBeat As System.Windows.Forms.Timer
    Friend WithEvents lblBeatTime As System.Windows.Forms.Label
    Friend WithEvents pbTime As System.Windows.Forms.ProgressBar
    Friend WithEvents lblT1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class

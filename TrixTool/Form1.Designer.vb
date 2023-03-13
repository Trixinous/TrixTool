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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPlayers = New System.Windows.Forms.TextBox()
        Me.txtUUIDs = New System.Windows.Forms.TextBox()
        Me.picIcon = New System.Windows.Forms.PictureBox()
        Me.lblIPandPort = New System.Windows.Forms.Label()
        Me.DownloadBar = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dfsdf = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMOTD = New System.Windows.Forms.Label()
        Me.txtHostname = New System.Windows.Forms.TextBox()
        Me.txtOnlinePlayers = New System.Windows.Forms.Label()
        Me.txtMaxPlayers = New System.Windows.Forms.Label()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Minecraft", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(520, 419)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Grab"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtPlayers
        '
        Me.txtPlayers.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtPlayers.Font = New System.Drawing.Font("Minecraft", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPlayers.ForeColor = System.Drawing.Color.White
        Me.txtPlayers.Location = New System.Drawing.Point(162, 157)
        Me.txtPlayers.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPlayers.Name = "txtPlayers"
        Me.txtPlayers.ReadOnly = True
        Me.txtPlayers.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtPlayers.Size = New System.Drawing.Size(313, 22)
        Me.txtPlayers.TabIndex = 5
        '
        'txtUUIDs
        '
        Me.txtUUIDs.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtUUIDs.Font = New System.Drawing.Font("Minecraft", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtUUIDs.ForeColor = System.Drawing.Color.White
        Me.txtUUIDs.Location = New System.Drawing.Point(12, 186)
        Me.txtUUIDs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtUUIDs.Multiline = True
        Me.txtUUIDs.Name = "txtUUIDs"
        Me.txtUUIDs.ReadOnly = True
        Me.txtUUIDs.Size = New System.Drawing.Size(463, 256)
        Me.txtUUIDs.TabIndex = 8
        '
        'picIcon
        '
        Me.picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picIcon.Location = New System.Drawing.Point(724, 12)
        Me.picIcon.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(64, 64)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picIcon.TabIndex = 9
        Me.picIcon.TabStop = False
        '
        'lblIPandPort
        '
        Me.lblIPandPort.AutoSize = True
        Me.lblIPandPort.Font = New System.Drawing.Font("Minecraft", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblIPandPort.ForeColor = System.Drawing.Color.White
        Me.lblIPandPort.Location = New System.Drawing.Point(12, 15)
        Me.lblIPandPort.Name = "lblIPandPort"
        Me.lblIPandPort.Size = New System.Drawing.Size(25, 16)
        Me.lblIPandPort.TabIndex = 10
        Me.lblIPandPort.Text = "IP:"
        '
        'DownloadBar
        '
        Me.DownloadBar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DownloadBar.Location = New System.Drawing.Point(601, 419)
        Me.DownloadBar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DownloadBar.Name = "DownloadBar"
        Me.DownloadBar.Size = New System.Drawing.Size(187, 23)
        Me.DownloadBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.DownloadBar.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Minecraft", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "MOTD:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Minecraft", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Online:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Minecraft", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(150, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Of"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Minecraft", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Players and UUIDs:"
        '
        'dfsdf
        '
        Me.dfsdf.AutoSize = True
        Me.dfsdf.Font = New System.Drawing.Font("Minecraft", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dfsdf.ForeColor = System.Drawing.Color.White
        Me.dfsdf.Location = New System.Drawing.Point(114, 12)
        Me.dfsdf.Name = "dfsdf"
        Me.dfsdf.Size = New System.Drawing.Size(0, 16)
        Me.dfsdf.TabIndex = 16
        '
        'txtPort
        '
        Me.txtPort.AutoSize = True
        Me.txtPort.Font = New System.Drawing.Font("Minecraft", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPort.ForeColor = System.Drawing.Color.White
        Me.txtPort.Location = New System.Drawing.Point(702, 400)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(0, 16)
        Me.txtPort.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Minecraft", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(653, 400)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Port:"
        '
        'txtMOTD
        '
        Me.txtMOTD.AutoSize = True
        Me.txtMOTD.Font = New System.Drawing.Font("Minecraft", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtMOTD.ForeColor = System.Drawing.Color.White
        Me.txtMOTD.Location = New System.Drawing.Point(96, 45)
        Me.txtMOTD.Name = "txtMOTD"
        Me.txtMOTD.Size = New System.Drawing.Size(0, 16)
        Me.txtMOTD.TabIndex = 19
        '
        'txtHostname
        '
        Me.txtHostname.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtHostname.Font = New System.Drawing.Font("Minecraft", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtHostname.ForeColor = System.Drawing.Color.White
        Me.txtHostname.Location = New System.Drawing.Point(96, 11)
        Me.txtHostname.Name = "txtHostname"
        Me.txtHostname.Size = New System.Drawing.Size(313, 22)
        Me.txtHostname.TabIndex = 20
        Me.txtHostname.Text = "trixinous.duckdns.org"
        '
        'txtOnlinePlayers
        '
        Me.txtOnlinePlayers.AutoSize = True
        Me.txtOnlinePlayers.Font = New System.Drawing.Font("Minecraft", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtOnlinePlayers.ForeColor = System.Drawing.Color.White
        Me.txtOnlinePlayers.Location = New System.Drawing.Point(96, 75)
        Me.txtOnlinePlayers.Name = "txtOnlinePlayers"
        Me.txtOnlinePlayers.Size = New System.Drawing.Size(0, 16)
        Me.txtOnlinePlayers.TabIndex = 21
        '
        'txtMaxPlayers
        '
        Me.txtMaxPlayers.AutoSize = True
        Me.txtMaxPlayers.Font = New System.Drawing.Font("Minecraft", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtMaxPlayers.ForeColor = System.Drawing.Color.White
        Me.txtMaxPlayers.Location = New System.Drawing.Point(180, 75)
        Me.txtMaxPlayers.Name = "txtMaxPlayers"
        Me.txtMaxPlayers.Size = New System.Drawing.Size(0, 16)
        Me.txtMaxPlayers.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtMaxPlayers)
        Me.Controls.Add(Me.txtOnlinePlayers)
        Me.Controls.Add(Me.txtHostname)
        Me.Controls.Add(Me.txtMOTD)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.dfsdf)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DownloadBar)
        Me.Controls.Add(Me.lblIPandPort)
        Me.Controls.Add(Me.picIcon)
        Me.Controls.Add(Me.txtUUIDs)
        Me.Controls.Add(Me.txtPlayers)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TrixTool 0.0.2a"
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents txtPlayers As TextBox
    Friend WithEvents txtUUIDs As TextBox
    Friend WithEvents picIcon As PictureBox
    Friend WithEvents lblIPandPort As Label
    Friend WithEvents DownloadBar As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dfsdf As Label
    Friend WithEvents txtPort As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMOTD As Label
    Friend WithEvents txtHostname As TextBox
    Friend WithEvents txtOnlinePlayers As Label
    Friend WithEvents txtMaxPlayers As Label
End Class

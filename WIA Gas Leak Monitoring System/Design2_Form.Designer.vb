<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Design2_Form
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Design2_Form))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSMS_Test = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEmail_Test = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblfooter2 = New System.Windows.Forms.Label()
        Me.lblfooter1 = New System.Windows.Forms.Label()
        Me.PanelMaster = New System.Windows.Forms.Panel()
        Me.TimerDT = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeIPAddressCOMNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddAssociateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMessageReceipientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MessageRecipientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer_ReadOmron = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerSaveDb = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMessages = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Guna2ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.btnSMS_Test)
        Me.Panel3.Controls.Add(Me.btnReset)
        Me.Panel3.Controls.Add(Me.btnEmail_Test)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1200, 72)
        Me.Panel3.TabIndex = 129
        '
        'btnSMS_Test
        '
        Me.btnSMS_Test.Location = New System.Drawing.Point(226, 36)
        Me.btnSMS_Test.Name = "btnSMS_Test"
        Me.btnSMS_Test.Size = New System.Drawing.Size(75, 23)
        Me.btnSMS_Test.TabIndex = 129
        Me.btnSMS_Test.Text = "SMS Test"
        Me.btnSMS_Test.UseVisualStyleBackColor = True
        Me.btnSMS_Test.Visible = False
        '
        'btnReset
        '
        Me.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnReset.Location = New System.Drawing.Point(844, 26)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 131
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        Me.btnReset.Visible = False
        '
        'btnEmail_Test
        '
        Me.btnEmail_Test.Location = New System.Drawing.Point(226, 7)
        Me.btnEmail_Test.Name = "btnEmail_Test"
        Me.btnEmail_Test.Size = New System.Drawing.Size(75, 23)
        Me.btnEmail_Test.TabIndex = 130
        Me.btnEmail_Test.Text = "Email Test"
        Me.btnEmail_Test.UseVisualStyleBackColor = True
        Me.btnEmail_Test.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 33.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(362, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(476, 56)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "WIA Gas Leak Monitoring"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(190, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 125
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.lblDateTime)
        Me.Panel4.Controls.Add(Me.lblfooter2)
        Me.Panel4.Controls.Add(Me.lblfooter1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 991)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1200, 33)
        Me.Panel4.TabIndex = 130
        '
        'lblDateTime
        '
        Me.lblDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateTime.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDateTime.Location = New System.Drawing.Point(957, 5)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(233, 19)
        Me.lblDateTime.TabIndex = 130
        Me.lblDateTime.Text = "Date and Time"
        Me.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblfooter2
        '
        Me.lblfooter2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblfooter2.AutoSize = True
        Me.lblfooter2.BackColor = System.Drawing.Color.Transparent
        Me.lblfooter2.Font = New System.Drawing.Font("Nirmala UI", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfooter2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblfooter2.Location = New System.Drawing.Point(3, 14)
        Me.lblfooter2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblfooter2.Name = "lblfooter2"
        Me.lblfooter2.Size = New System.Drawing.Size(108, 12)
        Me.lblfooter2.TabIndex = 129
        Me.lblfooter2.Text = "© LF Philipines - TSG 2024"
        '
        'lblfooter1
        '
        Me.lblfooter1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblfooter1.AutoSize = True
        Me.lblfooter1.BackColor = System.Drawing.Color.Transparent
        Me.lblfooter1.Font = New System.Drawing.Font("Nirmala UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfooter1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblfooter1.Location = New System.Drawing.Point(5, 3)
        Me.lblfooter1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblfooter1.Name = "lblfooter1"
        Me.lblfooter1.Size = New System.Drawing.Size(133, 12)
        Me.lblfooter1.TabIndex = 128
        Me.lblfooter1.Text = "LITTELFUSE PHILIPPINES INC." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PanelMaster
        '
        Me.PanelMaster.AutoScroll = True
        Me.PanelMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMaster.Location = New System.Drawing.Point(0, 72)
        Me.PanelMaster.Name = "PanelMaster"
        Me.PanelMaster.Size = New System.Drawing.Size(1200, 919)
        Me.PanelMaster.TabIndex = 131
        '
        'TimerDT
        '
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.ChangeIPAddressCOMNameToolStripMenuItem, Me.AddAssociateToolStripMenuItem, Me.EditMessageReceipientToolStripMenuItem})
        Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Me.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(233, 92)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ChangeIPAddressCOMNameToolStripMenuItem
        '
        Me.ChangeIPAddressCOMNameToolStripMenuItem.Name = "ChangeIPAddressCOMNameToolStripMenuItem"
        Me.ChangeIPAddressCOMNameToolStripMenuItem.ShowShortcutKeys = False
        Me.ChangeIPAddressCOMNameToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ChangeIPAddressCOMNameToolStripMenuItem.Text = "Change IP Address/COM name"
        '
        'AddAssociateToolStripMenuItem
        '
        Me.AddAssociateToolStripMenuItem.Name = "AddAssociateToolStripMenuItem"
        Me.AddAssociateToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.AddAssociateToolStripMenuItem.Text = "Add Associate"
        '
        'EditMessageReceipientToolStripMenuItem
        '
        Me.EditMessageReceipientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MessageRecipientToolStripMenuItem})
        Me.EditMessageReceipientToolStripMenuItem.Name = "EditMessageReceipientToolStripMenuItem"
        Me.EditMessageReceipientToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.EditMessageReceipientToolStripMenuItem.Text = "Edit"
        '
        'MessageRecipientToolStripMenuItem
        '
        Me.MessageRecipientToolStripMenuItem.Name = "MessageRecipientToolStripMenuItem"
        Me.MessageRecipientToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.MessageRecipientToolStripMenuItem.Text = " Message Recipient/Delay"
        '
        'Timer_ReadOmron
        '
        Me.Timer_ReadOmron.Interval = 1000
        '
        'TimerSaveDb
        '
        Me.TimerSaveDb.Interval = 30000
        '
        'TimerMessages
        '
        Me.TimerMessages.Interval = 1000
        '
        'Design2_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 1024)
        Me.ContextMenuStrip = Me.Guna2ContextMenuStrip1
        Me.Controls.Add(Me.PanelMaster)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Design2_Form"
        Me.Text = "Design2_Form"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Guna2ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblDateTime As Label
    Friend WithEvents lblfooter2 As Label
    Friend WithEvents lblfooter1 As Label
    Friend WithEvents PanelMaster As Panel
    Friend WithEvents TimerDT As Timer
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer_ReadOmron As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents btnSMS_Test As Button
    Friend WithEvents ChangeIPAddressCOMNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddAssociateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnEmail_Test As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents TimerSaveDb As Timer
    Friend WithEvents TimerMessages As Timer
    Friend WithEvents EditMessageReceipientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MessageRecipientToolStripMenuItem As ToolStripMenuItem
End Class

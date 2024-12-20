<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowSenVal_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShowSenVal_Form))
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBoxTitle = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.picSelas_Low_Alarm = New System.Windows.Forms.PictureBox()
        Me.picSelas_Mid_Alarm = New System.Windows.Forms.PictureBox()
        Me.picSelas_Up_Alarm = New System.Windows.Forms.PictureBox()
        Me.lblnear = New System.Windows.Forms.Label()
        Me.txtSelas_Low = New System.Windows.Forms.TextBox()
        Me.txtSelas_Mid = New System.Windows.Forms.TextBox()
        Me.txtSelas_Up = New System.Windows.Forms.TextBox()
        Me.lblVal3 = New System.Windows.Forms.Label()
        Me.lblVal2 = New System.Windows.Forms.Label()
        Me.lblVal1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.GroupBoxTitle.SuspendLayout()
        CType(Me.picSelas_Low_Alarm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSelas_Mid_Alarm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSelas_Up_Alarm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.Black
        Me.Guna2CustomGradientPanel1.BorderRadius = 10
        Me.Guna2CustomGradientPanel1.BorderThickness = 7
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnClose)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.GroupBoxTitle)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(384, 369)
        Me.Guna2CustomGradientPanel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClose.FillColor = System.Drawing.Color.Transparent
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnClose.Location = New System.Drawing.Point(353, 11)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PressedColor = System.Drawing.Color.DarkGray
        Me.btnClose.PressedDepth = 0
        Me.btnClose.Size = New System.Drawing.Size(22, 19)
        Me.btnClose.TabIndex = 68
        '
        'GroupBoxTitle
        '
        Me.GroupBoxTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBoxTitle.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxTitle.BorderColor = System.Drawing.Color.Black
        Me.GroupBoxTitle.BorderRadius = 10
        Me.GroupBoxTitle.BorderThickness = 5
        Me.GroupBoxTitle.Controls.Add(Me.picSelas_Low_Alarm)
        Me.GroupBoxTitle.Controls.Add(Me.picSelas_Mid_Alarm)
        Me.GroupBoxTitle.Controls.Add(Me.picSelas_Up_Alarm)
        Me.GroupBoxTitle.Controls.Add(Me.lblnear)
        Me.GroupBoxTitle.Controls.Add(Me.txtSelas_Low)
        Me.GroupBoxTitle.Controls.Add(Me.txtSelas_Mid)
        Me.GroupBoxTitle.Controls.Add(Me.txtSelas_Up)
        Me.GroupBoxTitle.Controls.Add(Me.lblVal3)
        Me.GroupBoxTitle.Controls.Add(Me.lblVal2)
        Me.GroupBoxTitle.Controls.Add(Me.lblVal1)
        Me.GroupBoxTitle.CustomBorderColor = System.Drawing.Color.Transparent
        Me.GroupBoxTitle.FillColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBoxTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxTitle.ForeColor = System.Drawing.Color.Black
        Me.GroupBoxTitle.Location = New System.Drawing.Point(25, 27)
        Me.GroupBoxTitle.Name = "GroupBoxTitle"
        Me.GroupBoxTitle.Size = New System.Drawing.Size(334, 317)
        Me.GroupBoxTitle.TabIndex = 2
        Me.GroupBoxTitle.Text = "Location"
        Me.GroupBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picSelas_Low_Alarm
        '
        Me.picSelas_Low_Alarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSelas_Low_Alarm.Image = CType(resources.GetObject("picSelas_Low_Alarm.Image"), System.Drawing.Image)
        Me.picSelas_Low_Alarm.Location = New System.Drawing.Point(263, 224)
        Me.picSelas_Low_Alarm.Name = "picSelas_Low_Alarm"
        Me.picSelas_Low_Alarm.Size = New System.Drawing.Size(50, 43)
        Me.picSelas_Low_Alarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSelas_Low_Alarm.TabIndex = 67
        Me.picSelas_Low_Alarm.TabStop = False
        Me.picSelas_Low_Alarm.Visible = False
        '
        'picSelas_Mid_Alarm
        '
        Me.picSelas_Mid_Alarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSelas_Mid_Alarm.Image = CType(resources.GetObject("picSelas_Mid_Alarm.Image"), System.Drawing.Image)
        Me.picSelas_Mid_Alarm.Location = New System.Drawing.Point(263, 153)
        Me.picSelas_Mid_Alarm.Name = "picSelas_Mid_Alarm"
        Me.picSelas_Mid_Alarm.Size = New System.Drawing.Size(50, 43)
        Me.picSelas_Mid_Alarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSelas_Mid_Alarm.TabIndex = 66
        Me.picSelas_Mid_Alarm.TabStop = False
        Me.picSelas_Mid_Alarm.Visible = False
        '
        'picSelas_Up_Alarm
        '
        Me.picSelas_Up_Alarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSelas_Up_Alarm.Image = CType(resources.GetObject("picSelas_Up_Alarm.Image"), System.Drawing.Image)
        Me.picSelas_Up_Alarm.Location = New System.Drawing.Point(263, 85)
        Me.picSelas_Up_Alarm.Name = "picSelas_Up_Alarm"
        Me.picSelas_Up_Alarm.Size = New System.Drawing.Size(50, 43)
        Me.picSelas_Up_Alarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSelas_Up_Alarm.TabIndex = 65
        Me.picSelas_Up_Alarm.TabStop = False
        Me.picSelas_Up_Alarm.Visible = False
        '
        'lblnear
        '
        Me.lblnear.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnear.ForeColor = System.Drawing.Color.Black
        Me.lblnear.Location = New System.Drawing.Point(3, 29)
        Me.lblnear.Name = "lblnear"
        Me.lblnear.Size = New System.Drawing.Size(328, 38)
        Me.lblnear.TabIndex = 64
        Me.lblnear.Text = "neay by"
        Me.lblnear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSelas_Low
        '
        Me.txtSelas_Low.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSelas_Low.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelas_Low.ForeColor = System.Drawing.Color.Lime
        Me.txtSelas_Low.Location = New System.Drawing.Point(141, 224)
        Me.txtSelas_Low.Name = "txtSelas_Low"
        Me.txtSelas_Low.ReadOnly = True
        Me.txtSelas_Low.Size = New System.Drawing.Size(125, 43)
        Me.txtSelas_Low.TabIndex = 17
        Me.txtSelas_Low.Text = "0.00 %"
        Me.txtSelas_Low.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSelas_Mid
        '
        Me.txtSelas_Mid.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSelas_Mid.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelas_Mid.ForeColor = System.Drawing.Color.Lime
        Me.txtSelas_Mid.Location = New System.Drawing.Point(141, 153)
        Me.txtSelas_Mid.Name = "txtSelas_Mid"
        Me.txtSelas_Mid.ReadOnly = True
        Me.txtSelas_Mid.Size = New System.Drawing.Size(125, 43)
        Me.txtSelas_Mid.TabIndex = 16
        Me.txtSelas_Mid.Text = "0.00 %"
        Me.txtSelas_Mid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSelas_Up
        '
        Me.txtSelas_Up.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSelas_Up.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelas_Up.ForeColor = System.Drawing.Color.Lime
        Me.txtSelas_Up.Location = New System.Drawing.Point(141, 85)
        Me.txtSelas_Up.Name = "txtSelas_Up"
        Me.txtSelas_Up.ReadOnly = True
        Me.txtSelas_Up.Size = New System.Drawing.Size(125, 43)
        Me.txtSelas_Up.TabIndex = 15
        Me.txtSelas_Up.Text = "0.00 %"
        Me.txtSelas_Up.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblVal3
        '
        Me.lblVal3.AutoSize = True
        Me.lblVal3.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVal3.Location = New System.Drawing.Point(46, 227)
        Me.lblVal3.Name = "lblVal3"
        Me.lblVal3.Size = New System.Drawing.Size(98, 37)
        Me.lblVal3.TabIndex = 2
        Me.lblVal3.Text = "Lower:"
        Me.lblVal3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVal2
        '
        Me.lblVal2.AutoSize = True
        Me.lblVal2.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVal2.Location = New System.Drawing.Point(35, 156)
        Me.lblVal2.Name = "lblVal2"
        Me.lblVal2.Size = New System.Drawing.Size(109, 37)
        Me.lblVal2.TabIndex = 1
        Me.lblVal2.Text = "Middle:"
        Me.lblVal2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVal1
        '
        Me.lblVal1.AutoSize = True
        Me.lblVal1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVal1.Location = New System.Drawing.Point(44, 88)
        Me.lblVal1.Name = "lblVal1"
        Me.lblVal1.Size = New System.Drawing.Size(100, 37)
        Me.lblVal1.TabIndex = 0
        Me.lblVal1.Text = "Upper:"
        Me.lblVal1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ShowSenVal_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 369)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ShowSenVal_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ShowSenVal_Form"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.GroupBoxTitle.ResumeLayout(False)
        Me.GroupBoxTitle.PerformLayout()
        CType(Me.picSelas_Low_Alarm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSelas_Mid_Alarm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSelas_Up_Alarm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents GroupBoxTitle As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblnear As Label
    Friend WithEvents txtSelas_Low As TextBox
    Friend WithEvents txtSelas_Mid As TextBox
    Friend WithEvents txtSelas_Up As TextBox
    Friend WithEvents lblVal3 As Label
    Friend WithEvents lblVal2 As Label
    Friend WithEvents lblVal1 As Label
    Friend WithEvents picSelas_Up_Alarm As PictureBox
    Friend WithEvents picSelas_Low_Alarm As PictureBox
    Friend WithEvents picSelas_Mid_Alarm As PictureBox
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
End Class

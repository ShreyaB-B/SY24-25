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
        components = New ComponentModel.Container()
        Timer1 = New Timer(components)
        Pacman = New PictureBox()
        Ghost = New PictureBox()
        Food = New PictureBox()
        TextBox1 = New TextBox()
        Bit = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox10 = New PictureBox()
        PictureBox9 = New PictureBox()
        Ghost2 = New PictureBox()
        CType(Pacman, ComponentModel.ISupportInitialize).BeginInit()
        CType(Ghost, ComponentModel.ISupportInitialize).BeginInit()
        CType(Food, ComponentModel.ISupportInitialize).BeginInit()
        CType(Bit, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(Ghost2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 250
        ' 
        ' Pacman
        ' 
        Pacman.Image = My.Resources.Resources.Original_PacMan_removebg_preview
        Pacman.Location = New Point(483, 161)
        Pacman.Name = "Pacman"
        Pacman.Size = New Size(74, 78)
        Pacman.SizeMode = PictureBoxSizeMode.StretchImage
        Pacman.TabIndex = 0
        Pacman.TabStop = False
        ' 
        ' Ghost
        ' 
        Ghost.Image = My.Resources.Resources.clydeeghost_removebg_preview
        Ghost.Location = New Point(89, 45)
        Ghost.Name = "Ghost"
        Ghost.Size = New Size(74, 78)
        Ghost.SizeMode = PictureBoxSizeMode.StretchImage
        Ghost.TabIndex = 1
        Ghost.TabStop = False
        Ghost.Visible = False
        ' 
        ' Food
        ' 
        Food.Image = My.Resources.Resources.images_removebg_preview1
        Food.Location = New Point(314, 178)
        Food.Name = "Food"
        Food.Size = New Size(48, 49)
        Food.SizeMode = PictureBoxSizeMode.StretchImage
        Food.TabIndex = 2
        Food.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Goudy Stout", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(149, 129)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(483, 219)
        TextBox1.TabIndex = 3
        TextBox1.TextAlign = HorizontalAlignment.Center
        TextBox1.Visible = False
        ' 
        ' Bit
        ' 
        Bit.Image = My.Resources.Resources.Screenshot_2024_09_19_134125
        Bit.Location = New Point(444, 193)
        Bit.Name = "Bit"
        Bit.Size = New Size(17, 19)
        Bit.SizeMode = PictureBoxSizeMode.StretchImage
        Bit.TabIndex = 4
        Bit.TabStop = False
        Bit.Tag = "Bits"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Screenshot_2024_09_19_134125
        PictureBox2.Location = New Point(408, 193)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(17, 19)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        PictureBox2.Tag = "Bits"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.Screenshot_2024_09_19_134125
        PictureBox3.Location = New Point(380, 193)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(17, 19)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        PictureBox3.Tag = "Bits"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.Screenshot_2024_09_19_134125
        PictureBox4.Location = New Point(282, 193)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(17, 19)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 7
        PictureBox4.TabStop = False
        PictureBox4.Tag = "Bits"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.Screenshot_2024_09_19_134125
        PictureBox5.Location = New Point(200, 193)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(17, 19)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 8
        PictureBox5.TabStop = False
        PictureBox5.Tag = "Bits"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.Screenshot_2024_09_19_134125
        PictureBox6.Location = New Point(163, 193)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(17, 19)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 9
        PictureBox6.TabStop = False
        PictureBox6.Tag = "Bits"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.Screenshot_2024_09_19_134125
        PictureBox7.Location = New Point(163, 234)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(17, 19)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 10
        PictureBox7.TabStop = False
        PictureBox7.Tag = "Bits"
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = My.Resources.Resources.Screenshot_2024_09_19_134125
        PictureBox8.Location = New Point(163, 278)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(17, 19)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 11
        PictureBox8.TabStop = False
        PictureBox8.Tag = "Bits"
        ' 
        ' PictureBox10
        ' 
        PictureBox10.Image = My.Resources.Resources.Screenshot_2024_09_19_134125
        PictureBox10.Location = New Point(243, 193)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(17, 19)
        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox10.TabIndex = 13
        PictureBox10.TabStop = False
        PictureBox10.Tag = "Bits"
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Image = My.Resources.Resources.images_removebg_preview1
        PictureBox9.Location = New Point(149, 303)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(48, 49)
        PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox9.TabIndex = 14
        PictureBox9.TabStop = False
        ' 
        ' Ghost2
        ' 
        Ghost2.Image = My.Resources.Resources.images__1_
        Ghost2.Location = New Point(638, 348)
        Ghost2.Name = "Ghost2"
        Ghost2.Size = New Size(82, 78)
        Ghost2.SizeMode = PictureBoxSizeMode.StretchImage
        Ghost2.TabIndex = 15
        Ghost2.TabStop = False
        Ghost2.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(755, 476)
        Controls.Add(Ghost2)
        Controls.Add(PictureBox9)
        Controls.Add(PictureBox10)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Bit)
        Controls.Add(Food)
        Controls.Add(Pacman)
        Controls.Add(TextBox1)
        Controls.Add(Ghost)
        Name = "Form1"
        Text = "Form1"
        CType(Pacman, ComponentModel.ISupportInitialize).EndInit()
        CType(Ghost, ComponentModel.ISupportInitialize).EndInit()
        CType(Food, ComponentModel.ISupportInitialize).EndInit()
        CType(Bit, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(Ghost2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Pacman As PictureBox
    Friend WithEvents Ghost As PictureBox
    Friend WithEvents Food As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Bit As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Ghost2 As PictureBox

End Class

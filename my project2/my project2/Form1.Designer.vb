﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.road_move = New System.Windows.Forms.Timer(Me.components)
        Me.move_left = New System.Windows.Forms.Timer(Me.components)
        Me.move_right = New System.Windows.Forms.Timer(Me.components)
        Me.mycar = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.car3 = New System.Windows.Forms.PictureBox()
        Me.car1 = New System.Windows.Forms.PictureBox()
        Me.car2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.car1_move = New System.Windows.Forms.Timer(Me.components)
        Me.car2_move = New System.Windows.Forms.Timer(Me.components)
        Me.car3_move = New System.Windows.Forms.Timer(Me.components)
        Me.gameoverlbl = New System.Windows.Forms.Label()
        Me.scorelbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.mycar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'road_move
        '
        Me.road_move.Enabled = True
        Me.road_move.Interval = 10
        '
        'move_left
        '
        Me.move_left.Interval = 10
        '
        'move_right
        '
        Me.move_right.Interval = 10
        '
        'mycar
        '
        Me.mycar.Image = Global.WindowsApplication1.My.Resources.Resources.mycar
        Me.mycar.Location = New System.Drawing.Point(120, 276)
        Me.mycar.Name = "mycar"
        Me.mycar.Size = New System.Drawing.Size(20, 60)
        Me.mycar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mycar.TabIndex = 1
        Me.mycar.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.White
        Me.PictureBox8.Location = New System.Drawing.Point(145, 303)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(15, 90)
        Me.PictureBox8.TabIndex = 0
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.White
        Me.PictureBox7.Location = New System.Drawing.Point(65, 303)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(15, 90)
        Me.PictureBox7.TabIndex = 0
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Location = New System.Drawing.Point(145, 182)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(15, 90)
        Me.PictureBox6.TabIndex = 0
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Location = New System.Drawing.Point(65, 182)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(15, 90)
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Location = New System.Drawing.Point(145, 65)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(15, 90)
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Location = New System.Drawing.Point(65, 65)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(15, 90)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(145, -48)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(15, 90)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(65, -48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(15, 90)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'car3
        '
        Me.car3.Image = Global.WindowsApplication1.My.Resources.Resources.blue
        Me.car3.Location = New System.Drawing.Point(203, 12)
        Me.car3.Name = "car3"
        Me.car3.Size = New System.Drawing.Size(20, 60)
        Me.car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.car3.TabIndex = 1
        Me.car3.TabStop = False
        '
        'car1
        '
        Me.car1.Image = Global.WindowsApplication1.My.Resources.Resources.green1
        Me.car1.Location = New System.Drawing.Point(0, 95)
        Me.car1.Name = "car1"
        Me.car1.Size = New System.Drawing.Size(20, 60)
        Me.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.car1.TabIndex = 1
        Me.car1.TabStop = False
        '
        'car2
        '
        Me.car2.Image = Global.WindowsApplication1.My.Resources.Resources.yellow
        Me.car2.Location = New System.Drawing.Point(120, 12)
        Me.car2.Name = "car2"
        Me.car2.Size = New System.Drawing.Size(20, 60)
        Me.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.car2.TabIndex = 1
        Me.car2.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = Global.WindowsApplication1.My.Resources.Resources.mycar
        Me.PictureBox12.Location = New System.Drawing.Point(-76, 130)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(20, 60)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 1
        Me.PictureBox12.TabStop = False
        '
        'car1_move
        '
        Me.car1_move.Enabled = True
        Me.car1_move.Interval = 10
        '
        'car2_move
        '
        Me.car2_move.Enabled = True
        Me.car2_move.Interval = 10
        '
        'car3_move
        '
        Me.car3_move.Enabled = True
        Me.car3_move.Interval = 10
        '
        'gameoverlbl
        '
        Me.gameoverlbl.AutoSize = True
        Me.gameoverlbl.BackColor = System.Drawing.Color.White
        Me.gameoverlbl.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gameoverlbl.ForeColor = System.Drawing.Color.Red
        Me.gameoverlbl.Location = New System.Drawing.Point(44, 95)
        Me.gameoverlbl.Name = "gameoverlbl"
        Me.gameoverlbl.Size = New System.Drawing.Size(128, 25)
        Me.gameoverlbl.TabIndex = 2
        Me.gameoverlbl.Text = "انتهت اللعبة"
        Me.gameoverlbl.Visible = False
        '
        'scorelbl
        '
        Me.scorelbl.AutoSize = True
        Me.scorelbl.BackColor = System.Drawing.Color.Transparent
        Me.scorelbl.ForeColor = System.Drawing.Color.Red
        Me.scorelbl.Location = New System.Drawing.Point(12, 12)
        Me.scorelbl.Name = "scorelbl"
        Me.scorelbl.Size = New System.Drawing.Size(13, 13)
        Me.scorelbl.TabIndex = 3
        Me.scorelbl.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(184, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "0"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(49, 123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 33)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "اعادة اللعبة"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(224, 361)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.scorelbl)
        Me.Controls.Add(Me.gameoverlbl)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.car2)
        Me.Controls.Add(Me.car1)
        Me.Controls.Add(Me.car3)
        Me.Controls.Add(Me.mycar)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(240, 400)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.mycar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents road_move As System.Windows.Forms.Timer
    Friend WithEvents mycar As System.Windows.Forms.PictureBox
    Friend WithEvents move_left As System.Windows.Forms.Timer
    Friend WithEvents move_right As System.Windows.Forms.Timer
    Friend WithEvents car3 As System.Windows.Forms.PictureBox
    Friend WithEvents car1 As System.Windows.Forms.PictureBox
    Friend WithEvents car2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents car1_move As System.Windows.Forms.Timer
    Friend WithEvents car2_move As System.Windows.Forms.Timer
    Friend WithEvents car3_move As System.Windows.Forms.Timer
    Friend WithEvents gameoverlbl As System.Windows.Forms.Label
    Friend WithEvents scorelbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class

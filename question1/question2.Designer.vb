﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class question2
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.txtmod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblsms = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Anopa", "Tinerufaro", "Anotida", "Tinevimbo", "Anotidaishe"})
        Me.ListBox1.Location = New System.Drawing.Point(12, 108)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(210, 95)
        Me.ListBox1.TabIndex = 0
        '
        'txtmod
        '
        Me.txtmod.Location = New System.Drawing.Point(390, 108)
        Me.txtmod.Name = "txtmod"
        Me.txtmod.Size = New System.Drawing.Size(171, 20)
        Me.txtmod.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(273, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Favorate Module"
        '
        'lblsms
        '
        Me.lblsms.AutoSize = True
        Me.lblsms.Location = New System.Drawing.Point(387, 160)
        Me.lblsms.Name = "lblsms"
        Me.lblsms.Size = New System.Drawing.Size(50, 13)
        Me.lblsms.TabIndex = 3
        Me.lblsms.Text = "Message"
        '
        'question2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblsms)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtmod)
        Me.Controls.Add(Me.ListBox1)
        Me.name = "question2"
        Me.Text = "question2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents txtmod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblsms As Label
End Class

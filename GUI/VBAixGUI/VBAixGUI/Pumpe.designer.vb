﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pumpe
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pumpe))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbl_Wert = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Pumpe_links_aus.png")
        Me.ImageList1.Images.SetKeyName(1, "Pumpe_links_ein.png")
        Me.ImageList1.Images.SetKeyName(2, "Pumpe_oben_aus.png")
        Me.ImageList1.Images.SetKeyName(3, "Pumpe_oben_ein.png")
        Me.ImageList1.Images.SetKeyName(4, "Pumpe_rechts_aus.png")
        Me.ImageList1.Images.SetKeyName(5, "Pumpe_rechts_ein.png")
        Me.ImageList1.Images.SetKeyName(6, "Pumpe_unten_aus.png")
        Me.ImageList1.Images.SetKeyName(7, "Pumpe_unten_ein.png")
        '
        'lbl_Wert
        '
        Me.lbl_Wert.AutoSize = true
        Me.lbl_Wert.BackColor = System.Drawing.Color.White
        Me.lbl_Wert.Location = New System.Drawing.Point(22, 33)
        Me.lbl_Wert.Name = "lbl_Wert"
        Me.lbl_Wert.Size = New System.Drawing.Size(13, 13)
        Me.lbl_Wert.TabIndex = 1
        Me.lbl_Wert.Text = "0"
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.VBAixGUI.My.Resources.Resources.Pumpe_links_aus
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = false
        '
        'Pumpe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbl_Wert)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Pumpe"
        Me.Size = New System.Drawing.Size(80, 80)
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lbl_Wert As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class

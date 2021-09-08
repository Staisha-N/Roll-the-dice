<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lblInvite = New System.Windows.Forms.Label()
        Me.txtMise = New System.Windows.Forms.TextBox()
        Me.btnJeterLesDes = New System.Windows.Forms.Button()
        Me.lblMessageResultat = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.picDeUn = New System.Windows.Forms.PictureBox()
        Me.picDeDeux = New System.Windows.Forms.PictureBox()
        CType(Me.picDeUn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeDeux, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInvite
        '
        Me.lblInvite.AutoSize = True
        Me.lblInvite.Location = New System.Drawing.Point(23, 40)
        Me.lblInvite.Name = "lblInvite"
        Me.lblInvite.Size = New System.Drawing.Size(110, 20)
        Me.lblInvite.TabIndex = 0
        Me.lblInvite.Text = "Inscrire la mise:"
        '
        'txtMise
        '
        Me.txtMise.Location = New System.Drawing.Point(139, 37)
        Me.txtMise.Name = "txtMise"
        Me.txtMise.Size = New System.Drawing.Size(115, 27)
        Me.txtMise.TabIndex = 1
        '
        'btnJeterLesDes
        '
        Me.btnJeterLesDes.Location = New System.Drawing.Point(297, 36)
        Me.btnJeterLesDes.Name = "btnJeterLesDes"
        Me.btnJeterLesDes.Size = New System.Drawing.Size(168, 28)
        Me.btnJeterLesDes.TabIndex = 2
        Me.btnJeterLesDes.Text = "Jeter les dés"
        Me.btnJeterLesDes.UseVisualStyleBackColor = True
        '
        'lblMessageResultat
        '
        Me.lblMessageResultat.AutoSize = True
        Me.lblMessageResultat.Location = New System.Drawing.Point(23, 289)
        Me.lblMessageResultat.Name = "lblMessageResultat"
        Me.lblMessageResultat.Size = New System.Drawing.Size(218, 20)
        Me.lblMessageResultat.TabIndex = 3
        Me.lblMessageResultat.Text = "Le total des points accumulés ="
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.Location = New System.Drawing.Point(247, 289)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(41, 20)
        Me.lblPoints.TabIndex = 4
        Me.lblPoints.Text = "1000"
        '
        'picDeUn
        '
        Me.picDeUn.InitialImage = Nothing
        Me.picDeUn.Location = New System.Drawing.Point(23, 86)
        Me.picDeUn.Name = "picDeUn"
        Me.picDeUn.Size = New System.Drawing.Size(165, 144)
        Me.picDeUn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picDeUn.TabIndex = 5
        Me.picDeUn.TabStop = False
        '
        'picDeDeux
        '
        Me.picDeDeux.Location = New System.Drawing.Point(281, 86)
        Me.picDeDeux.Name = "picDeDeux"
        Me.picDeDeux.Size = New System.Drawing.Size(170, 144)
        Me.picDeDeux.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picDeDeux.TabIndex = 6
        Me.picDeDeux.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 340)
        Me.Controls.Add(Me.picDeDeux)
        Me.Controls.Add(Me.picDeUn)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.lblMessageResultat)
        Me.Controls.Add(Me.btnJeterLesDes)
        Me.Controls.Add(Me.txtMise)
        Me.Controls.Add(Me.lblInvite)
        Me.Name = "Form1"
        Me.Text = "Jeu de dés (S. Neville)"
        CType(Me.picDeUn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeDeux, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInvite As Label
    Friend WithEvents txtMise As TextBox
    Friend WithEvents btnJeterLesDes As Button
    Friend WithEvents lblMessageResultat As Label
    Friend WithEvents lblPoints As Label
    Friend WithEvents picDeUn As PictureBox
    Friend WithEvents picDeDeux As PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.pbNewImage = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.AnimalButton = New System.Windows.Forms.Button()
        Me.personButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.ChkAutoSlide = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.pbNewImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbNewImage
        '
        Me.pbNewImage.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.pbNewImage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbNewImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbNewImage.Image = Global.MNB.My.Resources.Resources._as
        Me.pbNewImage.Location = New System.Drawing.Point(108, 203)
        Me.pbNewImage.Name = "pbNewImage"
        Me.pbNewImage.Size = New System.Drawing.Size(637, 275)
        Me.pbNewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbNewImage.TabIndex = 17
        Me.pbNewImage.TabStop = False
        '
        'Label2
        '
        Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(517, 484)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 27)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Date  Time"
        '
        'Label1
        '
        Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Forte", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(106, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(618, 30)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "K5824 GENERAL MEDICAL DIAGNOSIS SYSTEM"
        '
        'ExitButton
        '
        Me.ExitButton.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ExitButton.BackgroundImage = Global.MNB.My.Resources.Resources.exit___Copy
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton.FlatAppearance.BorderSize = 7
        Me.ExitButton.Location = New System.Drawing.Point(645, 60)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(100, 123)
        Me.ExitButton.TabIndex = 14
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'AboutButton
        '
        Me.AboutButton.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.AboutButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AboutButton.BackgroundImage = CType(resources.GetObject("AboutButton.BackgroundImage"), System.Drawing.Image)
        Me.AboutButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutButton.FlatAppearance.BorderSize = 7
        Me.AboutButton.Location = New System.Drawing.Point(502, 60)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(121, 123)
        Me.AboutButton.TabIndex = 13
        Me.AboutButton.Text = "About"
        Me.AboutButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'AnimalButton
        '
        Me.AnimalButton.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.AnimalButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AnimalButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimalButton.FlatAppearance.BorderSize = 7
        Me.AnimalButton.Image = CType(resources.GetObject("AnimalButton.Image"), System.Drawing.Image)
        Me.AnimalButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AnimalButton.Location = New System.Drawing.Point(230, 60)
        Me.AnimalButton.Name = "AnimalButton"
        Me.AnimalButton.Size = New System.Drawing.Size(108, 123)
        Me.AnimalButton.TabIndex = 12
        Me.AnimalButton.Text = "Pet Diagnosis"
        Me.AnimalButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AnimalButton.UseVisualStyleBackColor = True
        '
        'personButton
        '
        Me.personButton.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.personButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.personButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.personButton.FlatAppearance.BorderSize = 7
        Me.personButton.ForeColor = System.Drawing.Color.Black
        Me.personButton.Image = CType(resources.GetObject("personButton.Image"), System.Drawing.Image)
        Me.personButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.personButton.Location = New System.Drawing.Point(107, 60)
        Me.personButton.Name = "personButton"
        Me.personButton.Size = New System.Drawing.Size(108, 123)
        Me.personButton.TabIndex = 11
        Me.personButton.Text = "personal  Diagnosis"
        Me.personButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.personButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 3000
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'ChkAutoSlide
        '
        Me.ChkAutoSlide.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.ChkAutoSlide.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChkAutoSlide.AutoSize = True
        Me.ChkAutoSlide.BackColor = System.Drawing.Color.Transparent
        Me.ChkAutoSlide.Checked = True
        Me.ChkAutoSlide.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkAutoSlide.Font = New System.Drawing.Font("AR BERKLEY", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAutoSlide.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChkAutoSlide.Location = New System.Drawing.Point(107, 484)
        Me.ChkAutoSlide.Name = "ChkAutoSlide"
        Me.ChkAutoSlide.Size = New System.Drawing.Size(90, 24)
        Me.ChkAutoSlide.TabIndex = 18
        Me.ChkAutoSlide.Text = "AutoSlide"
        Me.ChkAutoSlide.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 7
        Me.Button1.Location = New System.Drawing.Point(359, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 123)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Consult Practitioner"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.MNB.My.Resources.Resources.hjghgc___Copy
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(831, 520)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pbNewImage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.AnimalButton)
        Me.Controls.Add(Me.personButton)
        Me.Controls.Add(Me.ChkAutoSlide)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pbNewImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbNewImage As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents AboutButton As System.Windows.Forms.Button
    Friend WithEvents AnimalButton As System.Windows.Forms.Button
    Friend WithEvents personButton As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents ChkAutoSlide As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class

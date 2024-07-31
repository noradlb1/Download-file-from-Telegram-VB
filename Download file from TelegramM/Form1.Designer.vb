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
        Me.filename_ext = New System.Windows.Forms.TextBox()
        Me.FILE_ID = New System.Windows.Forms.TextBox()
        Me.ButtonDownload = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'filename_ext
        '
        Me.filename_ext.Location = New System.Drawing.Point(314, 201)
        Me.filename_ext.Name = "filename_ext"
        Me.filename_ext.Size = New System.Drawing.Size(175, 20)
        Me.filename_ext.TabIndex = 7
        Me.filename_ext.Text = "filename.ext"
        '
        'FILE_ID
        '
        Me.FILE_ID.Location = New System.Drawing.Point(314, 168)
        Me.FILE_ID.Name = "FILE_ID"
        Me.FILE_ID.Size = New System.Drawing.Size(175, 20)
        Me.FILE_ID.TabIndex = 6
        Me.FILE_ID.Text = "FILE_ID"
        '
        'ButtonDownload
        '
        Me.ButtonDownload.Location = New System.Drawing.Point(311, 227)
        Me.ButtonDownload.Name = "ButtonDownload"
        Me.ButtonDownload.Size = New System.Drawing.Size(178, 23)
        Me.ButtonDownload.TabIndex = 5
        Me.ButtonDownload.Text = "ButtonDownload"
        Me.ButtonDownload.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(311, 269)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(47, 13)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "lblStatus"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.filename_ext)
        Me.Controls.Add(Me.FILE_ID)
        Me.Controls.Add(Me.ButtonDownload)
        Me.Controls.Add(Me.lblStatus)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents filename_ext As TextBox
    Friend WithEvents FILE_ID As TextBox
    Friend WithEvents ButtonDownload As Button
    Friend WithEvents lblStatus As Label
End Class

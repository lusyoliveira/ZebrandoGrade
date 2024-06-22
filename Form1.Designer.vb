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
        Me.Grade = New System.Windows.Forms.DataGridView
        Me.btnPreencher = New System.Windows.Forms.Button
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.Grade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grade
        '
        Me.Grade.AllowUserToAddRows = False
        Me.Grade.AllowUserToDeleteRows = False
        Me.Grade.AllowUserToOrderColumns = True
        Me.Grade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1})
        Me.Grade.Location = New System.Drawing.Point(32, 12)
        Me.Grade.Name = "Grade"
        Me.Grade.Size = New System.Drawing.Size(682, 224)
        Me.Grade.TabIndex = 0
        '
        'btnPreencher
        '
        Me.btnPreencher.Location = New System.Drawing.Point(126, 288)
        Me.btnPreencher.Name = "btnPreencher"
        Me.btnPreencher.Size = New System.Drawing.Size(234, 49)
        Me.btnPreencher.TabIndex = 1
        Me.btnPreencher.Text = "Preencher"
        Me.btnPreencher.UseVisualStyleBackColor = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Codigo"
        Me.Column2.Name = "Column2"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nome"
        Me.Column1.Name = "Column1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 374)
        Me.Controls.Add(Me.btnPreencher)
        Me.Controls.Add(Me.Grade)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Grade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grade As System.Windows.Forms.DataGridView
    Friend WithEvents btnPreencher As System.Windows.Forms.Button
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class

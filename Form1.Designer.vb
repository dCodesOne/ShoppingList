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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBoxAdd = New System.Windows.Forms.TextBox()
        Me.txtBoxList = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type item to be added to list:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(14, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Shopping list:"
        '
        'txtBoxAdd
        '
        Me.txtBoxAdd.Location = New System.Drawing.Point(131, 22)
        Me.txtBoxAdd.Name = "txtBoxAdd"
        Me.txtBoxAdd.Size = New System.Drawing.Size(340, 20)
        Me.txtBoxAdd.TabIndex = 0
        '
        'txtBoxList
        '
        Me.txtBoxList.Location = New System.Drawing.Point(131, 77)
        Me.txtBoxList.Multiline = True
        Me.txtBoxList.Name = "txtBoxList"
        Me.txtBoxList.ReadOnly = True
        Me.txtBoxList.Size = New System.Drawing.Size(340, 207)
        Me.txtBoxList.TabIndex = 0
        Me.txtBoxList.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(19, 307)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(78, 65)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Print Shopping List"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(140, 307)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(78, 65)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add to Shopping List"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(264, 307)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(78, 65)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear Shopping List"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(393, 307)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(78, 65)
        Me.btnDone.TabIndex = 4
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(17, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(454, 2)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Label3"
        '
        'PrintDocument1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 384)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtBoxList)
        Me.Controls.Add(Me.txtBoxAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Shopping List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBoxAdd As TextBox
    Friend WithEvents txtBoxList As TextBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDone As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class

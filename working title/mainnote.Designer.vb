<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mainnote
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mainnote))
        Me.notearea = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThisWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoteColorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.YellowToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrangeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhiteDefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontsWIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearConsoleOutputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'notearea
        '
        Me.notearea.AutoWordSelection = True
        Me.notearea.BackColor = System.Drawing.Color.Yellow
        Me.notearea.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.notearea.ContextMenuStrip = Me.ContextMenuStrip1
        Me.notearea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.notearea.EnableAutoDragDrop = True
        Me.notearea.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notearea.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.notearea.Location = New System.Drawing.Point(0, 0)
        Me.notearea.Name = "notearea"
        Me.notearea.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.notearea.ShowSelectionMargin = True
        Me.notearea.Size = New System.Drawing.Size(268, 234)
        Me.notearea.TabIndex = 0
        Me.notearea.Text = ""
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(103, 158)
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThisWindowToolStripMenuItem, Me.NewWindowToolStripMenuItem})
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.TestToolStripMenuItem.Text = "&New Note"
        '
        'ThisWindowToolStripMenuItem
        '
        Me.ThisWindowToolStripMenuItem.Name = "ThisWindowToolStripMenuItem"
        Me.ThisWindowToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ThisWindowToolStripMenuItem.Text = "This Window"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.NewWindowToolStripMenuItem.Text = "New Window"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.SaveAsToolStripMenuItem.Text = "&Save as..."
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoteColorToolStripMenuItem1, Me.FontsWIPToolStripMenuItem, Me.ClearConsoleOutputToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'NoteColorToolStripMenuItem1
        '
        Me.NoteColorToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YellowToolStripMenuItem1, Me.OrangeToolStripMenuItem1, Me.BlueToolStripMenuItem1, Me.WhiteDefaultToolStripMenuItem, Me.CustomToolStripMenuItem})
        Me.NoteColorToolStripMenuItem1.Name = "NoteColorToolStripMenuItem1"
        Me.NoteColorToolStripMenuItem1.Size = New System.Drawing.Size(188, 22)
        Me.NoteColorToolStripMenuItem1.Text = "Note Color"
        '
        'YellowToolStripMenuItem1
        '
        Me.YellowToolStripMenuItem1.Name = "YellowToolStripMenuItem1"
        Me.YellowToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.YellowToolStripMenuItem1.Text = "Yellow (Default)"
        '
        'OrangeToolStripMenuItem1
        '
        Me.OrangeToolStripMenuItem1.Name = "OrangeToolStripMenuItem1"
        Me.OrangeToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.OrangeToolStripMenuItem1.Text = "Orange"
        '
        'BlueToolStripMenuItem1
        '
        Me.BlueToolStripMenuItem1.Name = "BlueToolStripMenuItem1"
        Me.BlueToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.BlueToolStripMenuItem1.Text = "Blue"
        '
        'WhiteDefaultToolStripMenuItem
        '
        Me.WhiteDefaultToolStripMenuItem.Name = "WhiteDefaultToolStripMenuItem"
        Me.WhiteDefaultToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.WhiteDefaultToolStripMenuItem.Text = "White"
        '
        'CustomToolStripMenuItem
        '
        Me.CustomToolStripMenuItem.Name = "CustomToolStripMenuItem"
        Me.CustomToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CustomToolStripMenuItem.Text = "Custom"
        '
        'FontsWIPToolStripMenuItem
        '
        Me.FontsWIPToolStripMenuItem.Name = "FontsWIPToolStripMenuItem"
        Me.FontsWIPToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.FontsWIPToolStripMenuItem.Text = "Fonts"
        '
        'ClearConsoleOutputToolStripMenuItem
        '
        Me.ClearConsoleOutputToolStripMenuItem.Enabled = False
        Me.ClearConsoleOutputToolStripMenuItem.Name = "ClearConsoleOutputToolStripMenuItem"
        Me.ClearConsoleOutputToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ClearConsoleOutputToolStripMenuItem.Text = "Clear Console Output"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'FontDialog1
        '
        Me.FontDialog1.ShowColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.CreatePrompt = True
        Me.SaveFileDialog1.Title = "Save Note"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.CheckPathExists = False
        Me.OpenFileDialog1.FileName = "Note"
        Me.OpenFileDialog1.Title = "Open"
        '
        'Mainnote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(268, 234)
        Me.Controls.Add(Me.notearea)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(284, 273)
        Me.Name = "Mainnote"
        Me.Text = "SlimNotes Public Beta 0.1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents notearea As RichTextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NoteColorToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents WhiteDefaultToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YellowToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OrangeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FontsWIPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ThisWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearConsoleOutputToolStripMenuItem As ToolStripMenuItem
End Class

Public Class Mainnote
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CRAZY HAMBORGER
        'steven esso is a simp
        Console.WriteLine("Form loaded.")
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'notearea.Size = Me.Size
        'Console.WriteLine("Sized RTB to window.")
        'Me.KeyPreview = True
    End Sub
    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        notearea.Cut()
        Console.WriteLine("Cut.")
    End Sub
    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        notearea.Copy()
        Console.WriteLine("Copy.")
    End Sub
    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        notearea.Paste()
        Console.WriteLine("Paste.")
    End Sub
    Private Sub ContextMenuStrip1_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        My.Computer.Audio.Play(My.Resources.boopsfx1, AudioPlayMode.Background)
        Console.WriteLine("boopsfx1 played.")
    End Sub
    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveFileDialog1.Filter = "SlimNote Files (*.snf*)|*.snf"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK _
         Then
            My.Computer.FileSystem.WriteAllText _
            (SaveFileDialog1.FileName, notearea.Text, True)

        End If
    End Sub
    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        MsgBox("Saved.")
    End Sub
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        'add confirmation later
        OpenFileDialog1.ShowDialog()
        notearea.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        Text = OpenFileDialog1.FileName
        Console.WriteLine("File opened.")
    End Sub
    Private Sub WhiteDefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhiteDefaultToolStripMenuItem.Click
        notearea.BackColor = Color.White
        Console.WriteLine("Note color changed to white.")
    End Sub
    Private Sub YellowToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles YellowToolStripMenuItem1.Click
        notearea.BackColor = Color.Yellow
        Console.WriteLine("Note color changed to yellow.")
    End Sub
    Private Sub OrangeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem1.Click
        notearea.BackColor = Color.Orange
        Console.WriteLine("Note color changed to orange.")
    End Sub
    Private Sub BlueToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem1.Click
        notearea.BackColor = Color.LightBlue
        Console.WriteLine("Note color changed to blue.")
    End Sub
    Private Sub FontsWIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontsWIPToolStripMenuItem.Click
        If FontDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            notearea.ForeColor = FontDialog1.Color
            notearea.Font = FontDialog1.Font
            Console.WriteLine("Font changed.")
        End If
    End Sub
    Private Sub CustomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomToolStripMenuItem.Click
        If ColorDialog1.ShowDialog <> DialogResult.Cancel Then
            notearea.BackColor = ColorDialog1.Color
            Console.WriteLine("Note color changed to a custom color.")
        End If
    End Sub
    Private Sub ThisWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThisWindowToolStripMenuItem.Click
        'might scrap code here
        If notearea.Modified Then
        End If
        Dim M As MsgBoxResult
        M = MsgBox("Save changes?", MsgBoxStyle.YesNoCancel)
        If M = MsgBoxResult.Cancel Then
        ElseIf M = MsgBoxResult.No Then
            notearea.Clear()
        ElseIf M = MsgBoxResult.Yes Then
            SaveFileDialog1.Filter = "SlimNote Files (*.snf*)|*.snf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK _
             Then
                My.Computer.FileSystem.WriteAllText _
                (SaveFileDialog1.FileName, notearea.Text, True)
                notearea.Clear()
                Console.WriteLine("New note created in same window.")
            End If
        End If
    End Sub
    Private Sub NewWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewWindowToolStripMenuItem.Click
        Shell("SlimNotes.exe")
    End Sub
    Private Sub ClearConsoleOutputToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearConsoleOutputToolStripMenuItem.Click
        Console.Clear()
    End Sub
End Class
Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        TabControl1.SelectedTab = Subjects
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Dim isave As New SaveFileDialog
        isave.Filter = "txt files(* .txt) |*.txt"
        isave.FilterIndex = 2
        isave.RestoreDirectory = False

        If isave.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(isave.FileName, TextBox3.Text)


        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim emptytext1 As String = ""
        If (TextBox2.Text = emptytext1) Then
            ErrorProvider1.SetError(TextBox2, "Complusury")
            Button7.Visible = False

        ElseIf (TextBox5.text > 100) Then
            MsgBox("CVV can't be greater than three Digits")
        ElseIf (TextBox5.text < val(999)) Then
            MsgBox("CVV can't be less than three Digits")

        ElseIf (TextBox5.Text = emptytext1) Then
            ErrorProvider1.SetError(TextBox5, "Complusury")
            Button7.Visible = False

        ElseIf (TextBox6.Text = emptytext1) Then
            ErrorProvider1.SetError(TextBox6, "Complusury")
            Button7.Visible = False


        Else
            MsgBox("Your paymet is Successfull")
            Button7.Visible = True

        End If
        Dim Cardno As New Regex("\d{3}")
        If Cardno.IsMatch(TextBox2.Text) Then
        Else
            ErrorProvider1.SetError(TextBox2, "Enter Valid Card NO.")
            MsgBox("Enter Valid Card NO.")

        End If

        'If Not IsNumeric(Me.TextBox2.Text) Then
        ' Me.ErrorProvider1.SetError(Me.TextBox2, "Enter Valid Card Details")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim it As String
        Dim it2 As String
        Dim it3 As String
        it = ListBox1.Text
        it2 = ListBox2.Text
        it3 = ListBox3.Text
        TextBox3.AppendText("    " + vbNewLine)
        TextBox3.AppendText(vbTab & Label1.Text + " :   " + TextBox1.Text + vbNewLine + vbNewLine)
        TextBox3.AppendText(vbTab & Label2.Text + " :   " + DateTimePicker1.Value + vbNewLine + vbNewLine)
        TextBox3.AppendText(vbTab & Label3.Text + " :   " + TextBox4.Text + vbNewLine + vbNewLine)
        TextBox3.AppendText(vbTab & Label4.Text + " :   " + TextBox7.Text + vbNewLine + vbNewLine)
        TextBox3.AppendText(vbTab & Label5.Text + " :   " + TextBox8.Text + vbNewLine + vbNewLine)
        TextBox3.AppendText(vbTab & Label6.Text + " :   " + it + vbNewLine + vbNewLine)
        TextBox3.AppendText(vbTab & Label8.Text + " :   " + it2 + vbNewLine + vbNewLine)
        TextBox3.AppendText(vbTab & Label9.Text + " :   " + it3 + vbNewLine + vbNewLine)
        TextBox3.AppendText(vbTab + "Selected Subjects:  " + vbNewLine)

        ' MsgBox("itme selected in first label is " & it)
        'TextBox3.AppendText(vbTab & "subject" + " :   " + CheckBox1.Checked + vbNewLine + vbNewLine)
        'MsgBox(CheckBox1.Checked)
        If (CheckBox1.Checked = True) Then
            Dim valuecheckSubject As String
            valuecheckSubject = "VB.Net"
            TextBox3.AppendText(vbTab & vbTab & CheckBox1.Text & vbTab + " :True " + vbNewLine + vbNewLine)
        End If

        If (CheckBox2.Checked = True) Then
            Dim valuecheckSubject As String
            valuecheckSubject = "VB.Net"
            TextBox3.AppendText(vbTab & vbTab & CheckBox2.Text & vbTab + " :True " + vbNewLine + vbNewLine)
        End If

        If (CheckBox3.Checked = True) Then
            Dim valuecheckSubject As String
            valuecheckSubject = "VB.Net"
            TextBox3.AppendText(vbTab & vbTab & CheckBox3.Text & vbTab + " :True " + vbNewLine + vbNewLine)
        End If

        If (CheckBox4.Checked = True) Then
            Dim valuecheckSubject As String
            valuecheckSubject = "VB.Net"
            TextBox3.AppendText(vbTab & vbTab & CheckBox4.Text & vbTab + " :True " + vbNewLine + vbNewLine)
        End If

        If (CheckBox5.Checked = True) Then
            Dim valuecheckSubject As String
            valuecheckSubject = "VB.Net"
            TextBox3.AppendText(vbTab & vbTab & CheckBox5.Text & vbTab + " :True " + vbNewLine + vbNewLine)
        End If

        If (CheckBox6.Checked = True) Then
            Dim valuecheckSubject As String
            valuecheckSubject = "VB.Net"
            TextBox3.AppendText(vbTab & vbTab & CheckBox6.Text & vbTab + " :True " + vbNewLine + vbNewLine)
        End If

        If (CheckBox7.Checked = True) Then
            Dim valuecheckSubject As String
            valuecheckSubject = "VB.Net"
            TextBox3.AppendText(vbTab & vbTab & CheckBox7.Text & vbTab + " :True " + vbNewLine + vbNewLine)
        End If

        If (CheckBox8.Checked = True) Then
            Dim valuecheckSubject As String
            valuecheckSubject = "VB.Net"
            TextBox3.AppendText(vbTab & vbTab & CheckBox8.Text & vbTab + " :True " + vbNewLine + vbNewLine)
        End If

        If (CheckBox9.Checked = True) Then
            Dim valuecheckSubject As String
            valuecheckSubject = "VB.Net"
            TextBox3.AppendText(vbTab & vbTab & CheckBox9.Text & vbTab + " :True " + vbNewLine + vbNewLine)
        End If

        If (CheckBox10.Checked = True) Then
            Dim valuecheckSubject As String
            valuecheckSubject = "VB.Net"
            TextBox3.AppendText(vbTab & vbTab & CheckBox10.Text & vbTab + " :True " + vbNewLine + vbNewLine)
        End If

        If (CheckBox11.Checked = True) Then
            Dim valuecheckSubject As String
            valuecheckSubject = "VB.Net"
            TextBox3.AppendText(vbTab & vbTab & CheckBox11.Text & vbTab + " :True " + vbNewLine + vbNewLine)
        End If

        If (CheckBox12.Checked = True) Then
            Dim valuecheckSubject As String
            valuecheckSubject = "VB.Net"
            TextBox3.AppendText(vbTab & vbTab & CheckBox12.Text & vbTab + " :True " + vbNewLine + vbNewLine)
        End If

        If (CheckBox13.Checked = True) Then
            Dim valuecheckSubject As String
            valuecheckSubject = "VB.Net"
            TextBox3.AppendText(vbTab & vbTab & CheckBox13.Text & vbTab + " :True " + vbNewLine + vbNewLine)
        End If

        If (CheckBox14.Checked = True) Then
            Dim valuecheckSubject As String
            valuecheckSubject = "VB.Net"
            TextBox3.AppendText(vbTab & vbTab & CheckBox14.Text & vbTab + " :True " + vbNewLine + vbNewLine)
        End If

        If (CheckBox15.Checked = True) Then
            Dim valuecheckSubject As String
            valuecheckSubject = "VB.Net"
            TextBox3.AppendText(vbTab & vbTab & CheckBox15.Text & vbTab + " :True " + vbNewLine + vbNewLine)
        End If

        If (CheckBox16.Checked = True) Then
            Dim valuecheckSubject As String
            valuecheckSubject = "VB.Net"
            TextBox3.AppendText(vbTab & vbTab & CheckBox16.Text & vbTab + " :True " + vbNewLine + vbNewLine)
        End If

        If (CheckBox17.Checked = True) Then
            Dim valuecheckSubject As String
            valuecheckSubject = "VB.Net"
            TextBox3.AppendText(vbTab & vbTab & CheckBox17.Text & vbTab + " :True " + vbNewLine + vbNewLine)
        End If
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub

    Private Sub Information_Click(sender As Object, e As EventArgs) Handles Information.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.SelectedTab = Payment
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim Name As New Regex("\d{1}")
        If Name.IsMatch(TextBox1.Text) Then
            ErrorProvider1.SetError(TextBox1, "Enter Name")
            MsgBox("Name should contain only Char")
        Else

        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        If (ListBox2.SelectedIndex = 0) Then
            GroupBox1.Visible = True
            GroupBox2.Visible = False
            GroupBox3.Visible = False
            MsgBox("You have Select Computer")

        ElseIf (ListBox2.SelectedIndex = 1) Then
            GroupBox1.Visible = False
            GroupBox2.Visible = True
            GroupBox3.Visible = False
            MsgBox("You have Select Civil")
        Else
            GroupBox1.Visible = False
            GroupBox2.Visible = False
            GroupBox3.Visible = True
            MsgBox("You have Select Mechanical")
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Dim roll As New Regex("\d{1}")
        If roll.IsMatch(TextBox7.Text) Then
        Else
            ErrorProvider1.SetError(TextBox7, "Enter Valid Roll No.")
            MsgBox("Roll No. should contain only Numeric")

        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ' If (DateTimePicker < 0) Then
        ' MsgBox(DateTimePicker1)
        'End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If (ListBox1.SelectedIndex = 0) Then
            ListBox3.Items.Add("1St SEM")
            ListBox3.Items.Add("2nd SEM")
        ElseIf (ListBox1.SelectedIndex = 1) Then
            ListBox3.Items.Add("3rd SEM")
            ListBox3.Items.Add("4th SEM")
        Else
            ListBox3.Items.Add("5th SEM")
            ListBox3.Items.Add("6th SEM")
        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        Dim Enroll As New Regex("\d{1}")
        If Enroll.IsMatch(TextBox8.Text) Then
        Else
            ErrorProvider1.SetError(TextBox8, "Enter Valid Enrollment NO.")
            MsgBox("Enrollment NO. should contain only Numeric")

        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim City As New Regex("\d{1}")
        If City.IsMatch(TextBox4.Text) Then
            ErrorProvider1.SetError(TextBox4, "Enter Valid City Name")
            MsgBox("City Name should contain only Char")
        Else

        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Dim CardHolder As New Regex("\d{1}")
        If CardHolder.IsMatch(TextBox6.Text) Then
            ErrorProvider1.SetError(TextBox6, "Enter Valid CardHolder Name")
            MsgBox("Enter Valid CardHolder Name")
        Else

        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Dim CVV As New Regex("\d{3}")
        '        If CVV.IsMatch(TextBox5.Text) Then


        '        Else
        '       ErrorProvider1.SetError(TextBox5, "Enter Valid CVV NO.")
        '      MsgBox("Enter Valid CVV NO.")

        '      End If
    End Sub

    Private Sub TextBox3_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim psi As New ProcessStartInfo

        psi.UseShellExecute = True

        psi.Verb = "print"

        psi.WindowStyle = ProcessWindowStyle.Hidden

        psi.Arguments = PrintDialog1.PrinterSettings.PrinterName.ToString() ' Here specify printer name

        psi.FileName = "D:\My.txt" ' Here specify a document to be printed

        Process.Start(psi)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim emptytext As String = ""
        If (TextBox1.Text = emptytext) Then
            ErrorProvider1.SetError(TextBox1, "Complusury")
            Button1.Visible = False
        ElseIf (TextBox4.Text = emptytext) Then
            ErrorProvider1.SetError(TextBox4, "Complusury")
            Button1.Visible = False

        ElseIf (TextBox7.Text = emptytext) Then
            ErrorProvider1.SetError(TextBox7, "Complusury")
            Button1.Visible = False

        ElseIf (TextBox8.Text = emptytext) Then
            ErrorProvider1.SetError(TextBox8, "Complusury")
            Button1.Visible = False
            If (RadioButton1.Checked = False And RadioButton2.Checked = False) Then
                ErrorProvider1.SetError(RadioButton1, "Complusury")
                Button1.Visible = False

                'ElseIf (RadioButton2.Checked = False) Then
                '   ErrorProvider1.SetError(RadioButton2, "Complusury")
                ' Button1.Visible = False


            Else
                Button1.Visible = True

                ' Dim inst As String = RadioButton1.Checked

            End If
        Else
            Button1.Visible = True

        End If
        MsgBox("Enter every Details to procced with Next Button")


    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click


        TabControl1.SelectedTab = Print
    End Sub
End Class

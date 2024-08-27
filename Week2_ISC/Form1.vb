Public Class Form1
    Private StrengthWords() As String = {"Invalid", "Very Weak", "Weak", "Better", "Medium", "Strong", "Perfect"}
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtPwd.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub CalculateMeter()
        Dim score As Integer
        Dim password As String = txtPwd.Text
        If (password.Length > 6) Then score += 1 'Length more than 6 
        If System.Text.RegularExpressions.Regex.IsMatch(password, "[a-z]") And
                System.Text.RegularExpressions.Regex.IsMatch(password, "[A-Z]") Then
            score += 1 'upper and lower case 
        End If
        If System.Text.RegularExpressions.Regex.IsMatch(password, "\d+") Then
            score += 1 'number
        End If
        If System.Text.RegularExpressions.Regex.IsMatch(password, "[,!,@,#,$,%,^,&,*,?,_,~,-,/,"",]") Then
            score += 1 'special character
        End If
        If (password.Length >= 10) Then score += 1 'length more than 9
        If (password.Length > 15) Then score += 1 'length more than 15
        pbStrength.Value = score / 6 * 100 'finding percentage to increase 
        lblProgressbar.Width = 50 * score 'label width is not auto so setting it to show color amount
        lblProgressbar.Text = StrengthWords(score) 'Getting strength word from string array declared above 
        lblProgressbar.TextAlign = ContentAlignment.MiddleCenter 'aligning to center can be done one time in design
        lblProgressbar.BackColor = GetColor(score) 'Getting color and setting 
        pbStrength.ForeColor = GetColor(score) 'does not work unless you disable Visual Styles from application properties
    End Sub
    Private Function GetColor(ByVal score As Integer) As Color
        Select Case score
            Case 0
                Return Color.Red
            Case 1
                Return Color.Red
            Case 2
                Return Color.Purple
            Case 3
                Return Color.LightGreen
            Case 4
                Return Color.MediumSeaGreen
            Case 5
                Return Color.Green
            Case 6
                Return Color.DarkGreen
        End Select
    End Function
    Private Sub txtPwd_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPwd.KeyUp
        CalculateMeter()
    End Sub
End Class


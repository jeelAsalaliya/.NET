Public Class Form1

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub TxtUSERID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUSERID.TextChanged

    End Sub

    Private Sub TxtPWD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPWD.TextChanged

    End Sub

    Private Sub TxtCPWD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCPWD.TextChanged

    End Sub

    Private Sub TxtADD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtADD.TextChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtPHONE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPHONE.TextChanged

    End Sub

    Private Sub TxtEMAIL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEMAIL.TextChanged

    End Sub

    Private Sub RBMALE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBMALE.CheckedChanged

    End Sub

    Private Sub RBFEMALE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBFEMALE.CheckedChanged

    End Sub

    Private Sub CHKHOBBIES_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKHOBBIES.SelectedIndexChanged

    End Sub

    Private Sub BTNREG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNREG.Click
        If TxtPWD.Text <> TxtCPWD.Text Then
            MessageBox.Show("PASSWORD AND CPWD INVALID")
        End If
        LBLMSG.Text = "ADDRESS:" & TxtADD.Text & vbCrLf & "PHONE:" & TxtPHONE.Text & vbCrLf & "EMAIL:" & TxtEMAIL.Text & vbCrLf

        If RBMALE.Checked = True Then
            LBLMSG.Text += "GENDER:" & RBMALE.Text & vbCrLf & "HOBBIES:"
        ElseIf RBFEMALE.Checked = True Then
            LBLMSG.Text += "GENDER:" & RBFEMALE.Text & vbCrLf & "HOBBIES:"
        End If

        For Each Item In CHKHOBBIES.CheckedItems
            LBLMSG.Text += "Item" & vbCrLf
        Next
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBLMSG.Click

    End Sub
End Class

Public Class Form1

    Private _oArr As String

    Private Property oArr(ByVal p1 As Integer) As String
        Get
            Return _oArr
        End Get
        Set(ByVal value As String)
            _oArr = value
        End Set
    End Property

    Private Sub btnobj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnobj.Click
        Dim oArr(2) As Object
        Dim sArr() As String = New String() {"dance", "music", "singing"}

        oArr(0) = 101
        oArr(1) = "aaa"
        oArr(2) = sArr()

        MessageBox.Show(CStr(oArr(0)))
        MessageBox.Show(CStr(oArr(1)))
        MessageBox.Show(oArr(2)(1))
    End Sub

    Private Sub btncollection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncollection.Click
        Dim Actors As New Collection
        Actors.Add("hritik", "hr")
        Actors.Add("sara ali", "3.14")

        MessageBox.Show(CStr(Actors.Item("hr")))
        MessageBox.Show(CStr(Actors.Item(1)))
        MessageBox.Show(CStr(Actors.Item("3.14")))
    End Sub

    Private Function oArr(ByVal p1 As Integer) As String
        Throw New NotImplementedException
    End Function

    Private Function oArr(ByVal p1 As Integer) As String
        Throw New NotImplementedException
    End Function

End Class

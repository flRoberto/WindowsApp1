Imports System.Data.OleDb
Public Class frmBuscar
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim con As New OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=E:\MATRICULA\base de datos\matricula(2002-2003).mdb")
        Try
            con.Open()
            MsgBox("registro encontrado",, "buscar")

            Dim query = "select * from estudiante where nombreestudiante like '" & txtBuscar.Text & "%'"
            Dim adap As New OleDbDataAdapter(query, con)
            Dim at As New DataTable
            adap.Fill(dt)
            DataGridView1.DataSource = dt()



        Catch ex As Exception
            MsgBox("no se conecto " & ex.Message)

        End Try
    End Sub

    Private Function dt() As DataSet
        Throw New NotImplementedException()
    End Function

    Private Sub btnGrafica_Click(sender As Object, e As EventArgs) Handles btnGrafica.Click
        frmGrafica.Show()

    End Sub
End Class
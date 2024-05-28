Imports System.Data.OleDb

Public Class Form1
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source= E:\MATRICULA\base de datos\matricula.mdb")
        Try
            con.Open()
            MsgBox("conectado")

            Dim query = "select * from estudiante"
            Dim adap As New OleDbDataAdapter(query, con)
            Dim at As New DataTable
            adap.Fill(dt)
            DataGridView1.DataSource = dt


        Catch ex As Exception
            MsgBox("no se conecto " & ex.Message)

        End Try

    End Sub

    Private Function dt() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        frmBuscar.Show()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class

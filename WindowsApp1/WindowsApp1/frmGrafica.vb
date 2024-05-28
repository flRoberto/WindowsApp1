Imports System.Data.OleDb
Public Class frmGrafica
    Private Sub frmGrafica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=E:\MATRICULA\base de datos\matricula(2002-2003).mdb")
        Try
            con.Open()
            MsgBox("conectado")

            Dim query = "select * from estudiante"
            Dim adap As New OleDbDataAdapter(query, con)
            Dim at As New DataTable
            adap.Fill(dt)

            Chart1.Series("series1").XValueMember = "nombreestudiante"
            Chart1.Series("serie1").XValueMember = "dniestudiante"

        Catch ex As Exception
            MsgBox("no se conecto " & ex.Message)

        End Try
    End Sub

    Private Function dt() As DataSet
        Throw New NotImplementedException()
    End Function
End Class
﻿Public Class frmProfesionalConMasTurnos
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim Reporte As New ProfesionalConMasTurnos
        CrystalReportViewer1.ReportSource = Reporte
        CrystalReportViewer1.Show()
        CrystalReportViewer1.Refresh()

    End Sub
End Class
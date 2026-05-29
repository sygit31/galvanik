Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bacadbase()
        koneksiORA()

        If connected Then
            'MsgBox("Koneksi oke!!!")
            tampil_galv_proses()
        Else
            MsgBox("Koneksi Gagal!!!")
        End If

    End Sub

    Private Sub tampil_galv_proses()
        Try
            Dim dao As New erp_galv_prosesDAO
            Dim data_galv_proses As List(Of erp_galv_proses)
            data_galv_proses = dao.get_galv_proses()

            dgGalv_Proses.Rows.Clear()
            For Each S As erp_galv_proses In data_galv_proses
                Dim sRow As Integer = dgGalv_Proses.Rows.Add
                dgGalv_Proses.Rows(sRow).Cells("idD").Value = S.id
                dgGalv_Proses.Rows(sRow).Cells("nmrD").Value = S.nmr
                dgGalv_Proses.Rows(sRow).Cells("kode_prosesD").Value = S.kode_proses
            Next
            dgGalv_Proses.Refresh()
        Catch ex As Exception
            errorLog("Form1-tampil_galv_proses", ex.Message, ex.ToString)
            MsgBox("Gagal mengambil data galv proses!")
        End Try
    End Sub

End Class

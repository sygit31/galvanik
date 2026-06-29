Public Class Form1
    Dim id1A, id1B, id2A, id2B, id3A, id3B, id4A, id4B, id5A, id5B As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bacadbase()
        koneksiORA()

        If connected Then
            'MsgBox("Koneksi oke!!!")
            tambah_kolom_pilihan()
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
                dgGalv_Proses.Rows(sRow).Cells("pilihD").Value = ""
            Next
            dgGalv_Proses.Refresh()
        Catch ex As Exception
            errorLog("Form1-tampil_galv_proses", ex.Message, ex.ToString)
            MsgBox("Gagal mengambil data galv proses!")
        End Try
    End Sub

    Private Sub tambah_kolom_pilihan()
        If dgGalv_Proses.Columns.Contains("pilihD") Then
            Exit Sub
        End If

        Dim kolom As New DataGridViewComboBoxColumn
        kolom.Name = "pilihD"
        kolom.HeaderText = "PILIH"
        kolom.Width = 100
        kolom.Items.Add("")
        kolom.Items.Add("1A")
        kolom.Items.Add("1B")
        kolom.Items.Add("2A")
        kolom.Items.Add("2B")
        kolom.Items.Add("3A")
        kolom.Items.Add("3B")
        kolom.Items.Add("4A")
        kolom.Items.Add("4B")
        kolom.Items.Add("5A")
        kolom.Items.Add("5B")
        dgGalv_Proses.Columns.Add(kolom)
    End Sub

    Private Sub dgGalv_Proses_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgGalv_Proses.CurrentCellDirtyStateChanged
        If dgGalv_Proses.IsCurrentCellDirty Then
            dgGalv_Proses.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dgGalv_Proses_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgGalv_Proses.CellValueChanged
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If dgGalv_Proses.Columns(e.ColumnIndex).Name = "pilihD" Then
            isi_data_pilihan()
        End If
    End Sub

    Private Sub isi_data_pilihan()
        kosongkan_data_pilihan()

        For Each row As DataGridViewRow In dgGalv_Proses.Rows
            If row.IsNewRow Then
                Continue For
            End If

            Dim pilihan As String = ""
            If Not row.Cells("pilihD").Value Is Nothing Then
                pilihan = row.Cells("pilihD").Value.ToString
            End If

            If pilihan <> "" Then
                isi_data_proses(pilihan, row.Cells("idD").Value.ToString, row.Cells("kode_prosesD").Value.ToString)
            End If
        Next
    End Sub

    Private Sub kosongkan_data_pilihan()
        id1A = ""
        id1B = ""
        id2A = ""
        id2B = ""
        id3A = ""
        id3B = ""
        id4A = ""
        id4B = ""
        id5A = ""
        id5B = ""

        txt1A.Text = ""
        txt1B.Text = ""
        txt2A.Text = ""
        txt2B.Text = ""
        txt3A.Text = ""
        txt3B.Text = ""
        txt4A.Text = ""
        txt4B.Text = ""
        txt5A.Text = ""
        txt5B.Text = ""
    End Sub

    Private Sub isi_data_proses(ByVal pilihan As String, ByVal id As String, ByVal kode_proses As String)
        Select Case pilihan
            Case "1A"
                id1A = id
                txt1A.Text = kode_proses
            Case "1B"
                id1B = id
                txt1B.Text = kode_proses
            Case "2A"
                id2A = id
                txt2A.Text = kode_proses
            Case "2B"
                id2B = id
                txt2B.Text = kode_proses
            Case "3A"
                id3A = id
                txt3A.Text = kode_proses
            Case "3B"
                id3B = id
                txt3B.Text = kode_proses
            Case "4A"
                id4A = id
                txt4A.Text = kode_proses
            Case "4B"
                id4B = id
                txt4B.Text = kode_proses
            Case "5A"
                id5A = id
                txt5A.Text = kode_proses
            Case "5B"
                id5B = id
                txt5B.Text = kode_proses
        End Select
    End Sub

End Class

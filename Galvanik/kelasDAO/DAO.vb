Imports Oracle
Imports Oracle.DataAccess
Imports Oracle.DataAccess.Client
Public Class DAO

    'Dim conn As New SqlConnection(My.Settings.    )

    '===============================================================================================================
    '===============================================================================================================
    '===============================================================================================================
    '===============================================================================================================
    '===============================================================================================================



    'Public Function FillTable(ByVal kon As MySqlConnection) As DataTable
    '    Dim dt As New DataTable
    '    Try
    '        Dim da As New MySqlDataAdapter("SELECT * FROM xxxxxxxx", kon)
    '        da.Fill(dt)
    '        Return dt
    '    Catch ex As Exception
    '        If kon.State = ConnectionState.Open Then
    '            kon.Close()
    '        End If
    '        errorLog("xxxxxxx", ex.Message, ex.ToString)
    '        Return dt
    '    End Try
    'End Function


    'Public Function FilltableReader(ByVal dg As DataGridView, ByVal kon As MySqlConnection)
    '    Try
    '        dg.Rows.Clear()
    '        Dim s As Integer = 0
    '        Dim rdr As MySqlDataReader
    '        Dim cmd As New MySqlCommand("SELECT * From xxxxxxxx", kon)
    '        If kon.State = ConnectionState.Closed Then
    '            kon.Open()
    '        End If
    '        rdr = cmd.ExecuteReader
    '        If rdr.HasRows Then
    '            While rdr.Read
    '                s = dg.Rows.Add
    '                dg.Rows(s).Cells("xxxxxxxxxxxxx").Value = rdr("xxxxxxxxxxxxx")
    '                dg.Rows(s).Cells("xxxxxxxxxxxxx").Value = rdr("xxxxxxxxxxxxx")
    '                dg.Rows(s).Cells("xxxxxxxxxxxxx").Value = rdr("xxxxxxxxxxxxx")
    '                dg.Rows(s).Cells("xxxxxxxxxxxxx").Value = rdr("xxxxxxxxxxxxx")
    '                dg.Rows(s).Cells("xxxxxxxxxxxxx").Value = rdr("xxxxxxxxxxxxx")
    '                dg.Rows(s).Cells("xxxxxxxxxxxxx").Value = rdr("xxxxxxxxxxxxx")
    '                dg.Rows(s).Cells("xxxxxxxxxxxxx").Value = rdr("xxxxxxxxxxxxx")
    '                dg.Rows(s).Cells("xxxxxxxxxxxxx").Value = rdr("xxxxxxxxxxxxx")
    '                dg.Rows(s).Cells("xxxxxxxxxxxxx").Value = rdr("xxxxxxxxxxxxx")
    '                dg.Rows(s).Cells("xxxxxxxxxxxxx").Value = rdr("xxxxxxxxxxxxx")
    '                dg.Rows(s).Cells("xxxxxxxxxxxxx").Value = rdr("xxxxxxxxxxxxx")
    '                dg.Rows(s).Cells("xxxxxxxxxxxxx").Value = rdr("xxxxxxxxxxxxx")
    '                dg.Rows(s).Cells("xxxxxxxxxxxxx").Value = rdr("xxxxxxxxxxxxx")
    '                dg.Rows(s).Cells("xxxxxxxxxxxxx").Value = rdr("xxxxxxxxxxxxx")
    '                dg.Rows(s).Cells("xxxxxxxxxxxxx").Value = rdr("xxxxxxxxxxxxx")
    '                dg.Rows(s).Cells("xxxxxxxxxxxxx").Value = rdr("xxxxxxxxxxxxx")
    '                dg.Rows(s).Cells("xxxxxxxxxxxxx").Value = rdr("xxxxxxxxxxxxx")
    '                dg.Refresh()
    '            End While
    '        End If
    '        rdr.Close()
    '        kon.Close()
    '        Return dg
    '    Catch ex As Exception
    '        If kon.State = ConnectionState.Open Then
    '            kon.Close()
    '        End If
    '        errorLog("xxxxxxx", ex.Message, ex.ToString)
    '        Return dg
    '    End Try
    'End Function


    '===============================================================================================================
    '===============================================================================================================
    '===============================================================================================================
    '===============================================================================================================
    '===============================================================================================================


    'Public Function Filter(ByVal id As String,ByVal kon As MySqlConnection) As DataTable
    '    Dim dt As New DataTable
    '    Try
    '        Dim da As New MySqlDataAdapter("SELECT * FROM xxxxxxxx WHERE xxxxx = @id", kon)
    '        da.SelectCommand.Parameters.AddWithValue("@id", id)
    '        da.Fill(dt)
    '        Return dt
    '    Catch ex As Exception
    '        If kon.State = ConnectionState.Open Then
    '            kon.Close()
    '        End If
    '        errorLog("xxxxxxx", ex.Message, ex.ToString)
    '        Return dt
    '    End Try
    'End Function



    '===============================================================================================================
    '===============================================================================================================
    '===============================================================================================================
    '===============================================================================================================
    '===============================================================================================================



    'Function binding(ByVal id As String,ByVal kon As MySqlConnection) As Class
    '    Dim S As new Class
    '    Try
    '        Dim rdr As MySqlDataReader
    '        Dim cmd As New MySqlCommand("SELECT * From xxxxxxxx WHERE xxxxxx = @id", kon)
    '        cmd.Parameters.AddWithValue("@id", id)
    '        If kon.State = ConnectionState.Closed Then
    '            kon.Open()
    '        End If
    '        rdr = cmd.ExecuteReader
    '        If rdr.Read() Then
    '            S.xxxxx = rdr("xxxxxxxxxxxxx")
    '            S.xxxxx = rdr("xxxxxxxxxxxxx")
    '            S.xxxxx = rdr("xxxxxxxxxxxxx")
    '            S.xxxxx = rdr("xxxxxxxxxxxxx")
    '            S.xxxxx = rdr("xxxxxxxxxxxxx")
    '            S.xxxxx = rdr("xxxxxxxxxxxxx")
    '            S.xxxxx = rdr("xxxxxxxxxxxxx")
    '            S.xxxxx = rdr("xxxxxxxxxxxxx")
    '        End If
    '        rdr.Close()
    '        kon.Close()
    '        Return S
    '    Catch ex As Exception
    '        If kon.State = ConnectionState.Open Then
    '            kon.Close()
    '        End If
    '        errorLog("xxxxxxx", ex.Message, ex.ToString)
    '        Return S
    '    End Try
    'End Function



    '===============================================================================================================
    '===============================================================================================================
    '===============================================================================================================
    '===============================================================================================================
    '===============================================================================================================



    'Public Function Save(ByVal S As Class,ByVal kon As MySqlConnection) As Boolean
    '    Try
    '        Dim cmd As New MySqlCommand("INSERT INTO xxxxxxxx (aaaaaaa,bbbbbbb,ccccccc,ddddddd,eeeeeee,fffffff,ggggggg,hhhhhhh) VALUES (@a,@b,@c,@d,@e,@f,@g,@h)", kon)
    '        cmd.Parameters.AddWithValue("@a", S.xxxxxxx)
    '        cmd.Parameters.AddWithValue("@b", S.xxxxxxx)
    '        cmd.Parameters.AddWithValue("@c", S.xxxxxxx)
    '        cmd.Parameters.AddWithValue("@d", S.xxxxxxx)
    '        cmd.Parameters.AddWithValue("@e", S.xxxxxxx)
    '        cmd.Parameters.AddWithValue("@f", S.xxxxxxx)
    '        cmd.Parameters.AddWithValue("@g", S.xxxxxxx)
    '        cmd.Parameters.AddWithValue("@h", S.xxxxxxx)
    '        If kon.State = ConnectionState.Closed Then
    '            kon.Open()
    '        End If
    '        If cmd.ExecuteNonQuery() Then
    '            kon.Close()
    '            Return True
    '        Else
    '            kon.Close()
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        If kon.State = ConnectionState.Open Then
    '            kon.Close()
    '        End If
    '        errorLog("xxxxxxx", ex.Message, ex.ToString)
    '        Return False
    '    End Try
    'End Function



    '===============================================================================================================
    '===============================================================================================================
    '===============================================================================================================
    '===============================================================================================================
    '===============================================================================================================



    'Public Function Edit(ByVal S As Class,ByVal kon As MySqlConnection) As Boolean
    '    Try
    '        Dim cmd As New MySqlCommand("UPDATE xxxxxxx SET aaaaaaa=@a,bbbbbbb=@b,ccccccc=@c,ddddddd=@d,eeeeeee=@e,fffffff=@f,ggggggg=@g,hhhhhhh=@h WHERE id = @id", kon)
    '        cmd.Parameters.AddWithValue("@a", S.xxxxxxx)
    '        cmd.Parameters.AddWithValue("@b", S.xxxxxxx)
    '        cmd.Parameters.AddWithValue("@c", S.xxxxxxx)
    '        cmd.Parameters.AddWithValue("@d", S.xxxxxxx)
    '        cmd.Parameters.AddWithValue("@e", S.xxxxxxx)
    '        cmd.Parameters.AddWithValue("@f", S.xxxxxxx)
    '        cmd.Parameters.AddWithValue("@g", S.xxxxxxx)
    '        cmd.Parameters.AddWithValue("@h", S.xxxxxxx)
    '        cmd.Parameters.AddWithValue("@id", S.xxxxxxx)
    '        If kon.State = ConnectionState.Closed Then
    '            kon.Open()
    '        End If
    '        If cmd.ExecuteNonQuery() Then
    '            kon.Close()
    '            Return True
    '        Else
    '            kon.Close()
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        If kon.State = ConnectionState.Open Then
    '            kon.Close()
    '        End If
    '        errorLog("xxxxxxx", ex.Message, ex.ToString)
    '        Return False
    '    End Try
    'End Function



    '===============================================================================================================
    '===============================================================================================================
    '===============================================================================================================
    '===============================================================================================================
    '===============================================================================================================



    'Public Function Delete(ByVal S As Class,ByVal kon As MySqlConnection) As Boolean
    '    Try
    '        Dim cmd As New MySqlCommand("DELETE FROM xxxxxxxx WHERE id=@id", kon)
    '        cmd.Parameters.AddWithValue("@id", S.xxxxxxx)
    '        If kon.State = ConnectionState.Closed Then
    '            kon.Open()
    '        End If
    '        If cmd.ExecuteNonQuery() Then
    '            kon.Close()
    '            Return True
    '        Else
    '            kon.Close()
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        If kon.State = ConnectionState.Open Then
    '            kon.Close()
    '        End If
    '        errorLog("xxxxxxx", ex.Message, ex.ToString)
    '        Return False
    '    End Try
    'End Function


End Class

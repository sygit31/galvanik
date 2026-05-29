Imports Oracle
Imports Oracle.DataAccess
Imports Oracle.DataAccess.Client

Module publicVariable
    Public server, port, database, user_id, password As String

    Public oraconn As New OracleConnection

    Public KoneksiString As String

    Public connected As Boolean = False

    Dim fileDbDir As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location()) + "\db.ini"

    Public Sub koneksiORA()
        Try
            Dim oradb As String = "Data Source=(DESCRIPTION=" _
                       + "(ADDRESS=(PROTOCOL=TCP)(HOST=" + server + ")(PORT=" + port + "))" _
                       + "(CONNECT_DATA=(SERVICE_NAME=" + database + ")));" _
                       + "User Id=" + user_id + ";Password=" + password + ";"

            oraconn.ConnectionString = oradb

            If server = "" Or database = "" Or user_id = "" Then
                connected = False
            Else
                oraconn.Open()
                If oraconn.State = ConnectionState.Open Then
                    connected = True
                    oraconn.Close()
                Else
                    connected = False
                End If
            End If
        Catch ex As Exception
            connected = False
            If oraconn.State = ConnectionState.Open Then
                oraconn.Close()
            End If
            MsgBox("Connection Error!")
            errorLog("Global Variable-koneksi", ex.Message, ex.ToString)
        End Try
    End Sub


    Public Sub bacadbase()
        Try
            If System.IO.File.Exists(fileDbDir) Then
                Dim readTxt As New System.IO.StreamReader(fileDbDir)
                Dim abc As String
                Dim FieldValue As String()
                Dim field As String
                Dim value As String
                Do While readTxt.Peek <> -1
                    abc = readTxt.ReadLine()
                    If Not InStr(abc, ":", CompareMethod.Text) = 0 Then
                        FieldValue = Split(abc.ToLower, ":", -1, CompareMethod.Text)
                        field = FieldValue(0)
                        value = FieldValue(1)
                        If field = "server" Then
                            If value = "" Or value = Nothing Then
                            Else
                                server = value
                            End If
                        ElseIf field = "port" Then
                            If value = "" Or value = Nothing Then
                            Else
                                port = value
                            End If
                        ElseIf field = "database" Then
                            If value = "" Or value = Nothing Then
                            Else
                                database = value
                            End If
                        ElseIf field = "user_id" Then
                            If value = "" Or value = Nothing Then
                            Else
                                user_id = value
                            End If
                        ElseIf field = "password" Then
                            If value = "" Or value = Nothing Then
                            Else
                                password = value
                            End If
                        End If
                    End If
                Loop
                readTxt.Close()
            End If
        Catch ex As Exception
            MsgBox("Error!")
            errorLog("Global Variable-bacadbase", ex.Message, ex.ToString)
        End Try
    End Sub


    Public Sub errorLog(ByVal location As String, ByVal message As String, ByVal coordinate As String)
        Dim di As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location()) + "\errorLog\")
        di.Create()
        Dim save As New System.IO.StreamWriter(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.Location()) + "\errorLog\" + location + _
        "-" + Date.Now.Day.ToString + Date.Now.Month.ToString + Date.Now.Year.ToString + Date.Now.Hour.ToString + Date.Now.Minute.ToString + Date.Now.Second.ToString + ".log")
        save.Write("location : " + location + vbCrLf + vbCrLf + "Message : " + vbCrLf + message + vbCrLf + vbCrLf + "Coordinate" + vbCrLf + coordinate)
        save.Close()
    End Sub

 
End Module

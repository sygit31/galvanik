Public Class erp_galv_proses


    Private _id As String
    Public Property id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Private _nmr As String
    Public Property nmr() As String
        Get
            Return _nmr
        End Get
        Set(ByVal value As String)
            _nmr = value
        End Set
    End Property

    Private _kode_proses As String
    Public Property kode_proses() As String
        Get
            Return _kode_proses
        End Get
        Set(ByVal value As String)
            _kode_proses = value
        End Set
    End Property

End Class

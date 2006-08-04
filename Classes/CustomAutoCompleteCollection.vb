Option Strict On
Option Explicit On

Friend Class CustomAutoCompleteCollection
    Inherits System.Windows.Forms.AutoCompleteStringCollection

    Private _DataSource As New List(Of StringDataBag)

    Public Sub New(ByVal dataSource As IDataReader, ByVal display As String)
        MyBase.New()

        Dim lIndex As Integer
        Dim lDataRow As StringDataBag

        While dataSource.Read
            lIndex = MyBase.Add(dataSource.Item(display).ToString)
            lDataRow = New StringDataBag

            For lItem As Integer = 0 To dataSource.FieldCount - 1
                lDataRow.Add(dataSource.GetName(lItem), CStr(dataSource.GetValue(lItem)))
            Next

            _DataSource.Insert(lIndex, lDataRow)
        End While
    End Sub

    Public Function GetValue(ByVal shortName As String, ByVal key As String) As String
        Dim lReturn As String

        If Not MyBase.Contains(shortName) Then Return String.Empty

        lReturn = _DataSource.Item(MyBase.IndexOf(shortName)).Value(key)

        Return lReturn
    End Function
End Class
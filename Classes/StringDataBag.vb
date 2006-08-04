Option Strict On
Option Explicit On

''' <summary>
''' A DataBag class represents a generic collection class for holding string data with a key
''' </summary>
''' <remarks>This is useful for holding data from a database table</remarks>
Public Class StringDataBag
    Private _Values As New Dictionary(Of String, String)

    ''' <summary>
    ''' Retrieve a value with a default empty return value
    ''' </summary>
    ''' <param name="key">The key to the collection value</param>
    ''' <value>System.String</value>
    ''' <returns>System.String</returns>
    ''' <remarks></remarks>
    Public Property Value(ByVal key As String) As String
        Get
            'If the key doesn't exist, return a default empty value
            If Not _Values.ContainsKey(key) Then
                _Values.Add(key, String.Empty)
            End If

            Return _Values.Item(key)
        End Get
        Set(ByVal value As String)
            _Values.Item(key) = value
        End Set
    End Property

    ''' <summary>
    ''' Add a new value to the collection
    ''' </summary>
    ''' <param name="key">The key for retrieving the value</param>
    ''' <param name="value">The value itself</param>
    Public Sub Add(ByVal key As String, ByVal value As String)
        _Values.Add(key, value)
    End Sub

    Public ReadOnly Property Count() As Integer
        Get
            Return _Values.Count
        End Get
    End Property

    Public Function GetEnumerator() As System.Collections.Generic.Dictionary(Of String, String).Enumerator
        Return _Values.GetEnumerator
    End Function

    Public Function ContainsKey(ByVal key As String) As Boolean
        Return _Values.ContainsKey(key)
    End Function

    Public Function ContainsValue(ByVal value As String) As Boolean
        Return _Values.ContainsValue(value)
    End Function
End Class
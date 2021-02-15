'Laura Riley
'RCET0265
'Spring 2021
'ConvertAndValidate
'

Option Explicit On
Option Strict On

'The program will convert a string to a 32 bit integer
Module ConvertandValidate

    Sub Main()
        Console.WriteLine(ValidateAndConvert("a", 5))
    End Sub

    Private Function ValidateAndConvert(convertThisString As String, toThisInteger As Integer) As Integer
        Static message$

        Try

        Catch ex As Exception

        End Try

        Return message$

    End Function

End Module

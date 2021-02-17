'Laura Riley
'RCET0265
'Spring 2021
'ConvertAndValidate
'https://github.com/rilelaur/ConvertandValidate_LG.git

Option Explicit On
Option Strict On

'The program will convert a string to a 32 bit integer
Module ConvertandValidate

    Sub Main()
        Dim userinput As String
        Dim validate As String
        Dim converted As Integer

        userinput = Console.ReadLine()
        validate = ValidateAndConvert(userinput, converted)

        If validate = "" Then
            Console.WriteLine(converted)
        Else
            Console.WriteLine(validate)
        End If
        Console.ReadLine()
    End Sub

    Private Function ValidateAndConvert(convertThisString As String, toThisInteger As Integer) As String
        'Converts the string to an integer
        'If it converts it will return a blank
        'If it fails to convert it will check if it is empty
        'or if it is simply unable to convert and return the message acccordingly
        Try
            toThisInteger = CInt(convertThisString)
            Return " "
        Catch ex As Exception
            Select Case convertThisString
                Case ""
                    Return "Is Empty"
                Case Else
                    Return "Must contain a number"
            End Select
        End Try
    End Function

End Module

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
        Dim converted As Integer

        userinput = Console.ReadLine()
        Console.WriteLine(ValidateAndConvert(userinput, converted))

        Console.ReadLine()
    End Sub

    Private Function ValidateAndConvert(convertThisString As String, toThisInteger As Integer) As String
        'Converts the string to an integer. If it converts, it will return a blank. 
        'If it fails To convert it will check If it Is empty Or If it Is simply unable To convert 
        'And Then Return the message acccordingly
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

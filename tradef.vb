'
' Created by SharpDevelop.
' User: Cecilio
' Date: 04/10/2018
' Time: 21:31
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
' 

Imports System
Imports System.IO
Imports System.Collections

Public Module tradef
	
	 Function buscartrade(ByVal valor As String) As String
        Dim objReader As New StreamReader("data\Stocks S&P 500.csv")
        Dim sLine As String = ""
        Dim arrText As New ArrayList()
        Dim posx As Int64
        Dim words As String()

        Do
            sLine = objReader.ReadLine()
            If Not sLine Is Nothing Then
            	
            	posx= sLine.LastIndexOf(RTrim(valor))
            	If (posx <> -1 ) Then
            		words = sLine.Split(New Char() {";"c})
            		objReader.Close()
            		Return words(1)
            	End If
            	
            End If
        Loop Until sLine Is Nothing
        
        objReader.Close()
        Return "-1"

    End Function
	
End Module

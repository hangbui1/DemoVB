Option Explicit On
Option Strict On
Imports System

#Const CustomerNumber = 35
Module Program
    Sub Main()
        'Declaration
        Dim InputWord As String
        Dim NumberOfLetters As Integer
        Dim ResultSentence As String

        'Initialization
        Console.Write("Please, enter keyword:")
        InputWord = Console.ReadLine()
        Console.WriteLine()

        'Processing demo function
        NumberOfLetters = CountNumberOfLettersInWord(InputWord)

        Console.WriteLine("Processing function!")
        ResultSentence = String.Format("{0} contains {1} letters", InputWord, NumberOfLetters)
        Console.WriteLine(ResultSentence)
        Console.WriteLine()

        'Processing demo operator
        If InputWord = "Hang" Then
            Console.WriteLine("Processing operator!")
            Console.WriteLine("Hello {0}", InputWord.ToUpper())
            Console.WriteLine()
        End If

        'Processing demo GET , SET
        Console.WriteLine("Processing GET/SET")
        Dim MyMouse = New Mouse()
        'Property short version
        MyMouse.Color = "White"
        Console.WriteLine("My {0} mouse", MyMouse.Color)
        Console.WriteLine()

        'Property long version
        MyMouse.NumberOfButtons = 4
        Console.WriteLine("I have {0} Mouses", MyMouse.NumberOfButtons)
        Console.WriteLine()

        'Interpreted property
        Console.WriteLine(MyMouse.LightsAreOn)
        Console.WriteLine()

        'Processing Method
        Console.WriteLine("Processing Method")
        Dim r As New Rectangle()
        r.AcceptDetails()
        r.Display()
        Console.WriteLine()

        Console.WriteLine("Processing Constants")
        Const PI = 3.14149
        Dim radius, area As Single
        radius = 7
        area = CSng(PI * radius)
        Console.WriteLine("Area = " & Str(area))
        Console.WriteLine()

        'Processing directive
        Console.WriteLine("Processing Directive")
#If CustomerNumber = 35 Then
        Console.WriteLine("Insert code to be compiled for customer # 35.")
#ElseIf CustomerNumber = 36 Then
            Console.WriteLine("Insert code to be compiled for customer # 36.")
#Else
            Console.WriteLine("Insert code to be compiled for all other customers.")
#End If
        Console.WriteLine()

        Console.WriteLine("Processing Loop")
        Dim a As Integer = 10

        While (a < 20)
            Console.WriteLine("value of a: {0}", a)
            a = a + 1
            If (a > 15) Then
                Exit While
            End If
        End While
        Console.WriteLine()

        Console.ReadKey()

    End Sub

    Private Function CountNumberOfLettersInWord(ByVal WordToAnalyse As String) As Integer
        'Declaration
        Dim NumberOfLetters As Integer

        'Initialization
        NumberOfLetters = 0

        'Processing
        For Each Letter As Char In WordToAnalyse
            NumberOfLetters += 1
        Next

        'Return the value
        Return NumberOfLetters
    End Function
End Module
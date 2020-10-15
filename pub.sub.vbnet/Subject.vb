
Imports System.Threading

Public Class Subject
    Public Event StateChange As EventHandler(Of Integer)
    Public Property State As Integer

    Public Sub SomeBusinessLogic()
        State = New Random().Next(1, 10)
        Thread.Sleep(15)
        RaiseEvent StateChange(Me, State)
    End Sub

End Class

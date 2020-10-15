Public Class ConcreteObserverB
    Friend Sub subject_StateChange(sender As Object, e As Integer)
        Console.WriteLine("Observer B receives " & e)
    End Sub
End Class

Public Class ConcreteObserverA
    Friend Sub subject_StateChange(sender As Object, e As Integer)
        Console.WriteLine("Observer A receives " & e)
    End Sub
End Class

Module Module1

    Sub Main()
        Dim subject As New Subject()

        Dim observera As New ConcreteObserverA()
        AddHandler subject.StateChange, AddressOf observera.subject_StateChange
        subject.SomeBusinessLogic()

        Dim observerb As New ConcreteObserverB()
        AddHandler subject.StateChange, AddressOf observerb.subject_StateChange
        subject.SomeBusinessLogic()

        RemoveHandler subject.StateChange, AddressOf observera.subject_StateChange
        subject.SomeBusinessLogic()

        Console.ReadLine()
    End Sub

End Module

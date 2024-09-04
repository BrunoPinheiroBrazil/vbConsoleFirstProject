Module Program
  Sub Main(args As String())
    Dim resposta = ""

    While resposta <> "sair"

      Console.WriteLine("Insira um nome por favor!")
      Dim entrada = Console.ReadLine()

      If entrada = "Sonic" Then
        Console.WriteLine($"Parabéns {entrada} passou na entrevista!!")
      End If

      If entrada = "Mickey" Then
        Console.WriteLine($"O {entrada} é o professor do Sonic e está muito orgulhoso!!!")
      End If

      If entrada = "Leia" Then
        Console.WriteLine($"A {entrada} está muito feliz que o Sonic vai ser programador VB Net!!!!")
      End If
    End While

  End Sub
End Module

Module Program
  Sub Main(args As String())
    Dim resposta = ""

    While resposta <> "sair"

      Console.WriteLine("Insira um nome por favor!")
      Dim entrada = Console.ReadLine()

      If entrada = "Sonic" Then
        Console.WriteLine($"Parab�ns {entrada} passou na entrevista!!")
      End If

      If entrada = "Mickey" Then
        Console.WriteLine($"O {entrada} � o professor do Sonic e est� muito orgulhoso!!!")
      End If

      If entrada = "Leia" Then
        Console.WriteLine($"A {entrada} est� muito feliz que o Sonic vai ser programador VB Net!!!!")
      End If
    End While

  End Sub
End Module

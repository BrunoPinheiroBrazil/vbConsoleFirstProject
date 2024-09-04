Module Program
  Sub Main(args As String())
    Dim resposta = ""

    Console.WriteLine("Insira um nome ou insira sair para sair do programa:")
    Dim entrada = Console.ReadLine()

    While resposta <> "sair"

      If entrada = "Sonic" Then
        Console.WriteLine($"Parabéns {entrada} passou na entrevista!!")
      End If

      If entrada = "Mickey" Then
        Console.WriteLine($"O {entrada} é o professor do Sonic e está muito orgulhoso!!!")
      End If

      If entrada = "Leia" Then
        Console.WriteLine($"A {entrada} está muito feliz que o Sonic vai ser programador VB Net!!!!")
      End If

      Console.WriteLine()

      Console.WriteLine("Insira outro nome por favor:")
      entrada = Console.ReadLine()

    End While

  End Sub
End Module

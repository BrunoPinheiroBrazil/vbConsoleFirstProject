Module Program
  Sub Main(args As String())
    Dim resposta = ""

    Console.WriteLine("Insira um nome ou insira sair para sair do programa:")
    Dim entrada = Console.ReadLine()

    While resposta <> "sair"

      If entrada = "Sonic" Then
        Console.WriteLine($"Parab�ns {entrada} passou na entrevista!!")
      End If

      If entrada = "Mickey" Then
        Console.WriteLine($"O {entrada} � o professor do Sonic e est� muito orgulhoso!!!")
      End If

      If entrada = "Leia" Then
        Console.WriteLine($"A {entrada} est� muito feliz que o Sonic vai ser programador VB Net!!!!")
      End If

      'Assim � coment�rio no c�digo com aspa �nica
      'Adicione mais uns 3 IFs para os nomes Eduardo, Pato e Vacilo
      'Para Eduardo uma frase de estudos, para Pato uma frase de vagabundo e para Vacilo uma frase de chingamento.
      'Boa sorte Sonic.

      Console.WriteLine()

      Console.WriteLine("Insira outro nome por favor:")
      entrada = Console.ReadLine()

    End While

  End Sub
End Module

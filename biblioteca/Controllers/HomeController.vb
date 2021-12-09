Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function Sobre() As ActionResult
        ViewData("Message") = "Somos uma rede de bibliotecas espalhadas pelo mundo, procurando trazer até o conforto da sua casa, tudo o que um livro lhe porporciona em bem estar, aventuras, suspenses, romances e tudo mais que o mundo da magia lhe permitir ver e sentir."

        Return View()
    End Function

    Function Contato() As ActionResult
        ViewData("Message") = "Para nos contatar é bem simples, é só discar 323265987 ou 56487941."

        Return View()
    End Function
End Class


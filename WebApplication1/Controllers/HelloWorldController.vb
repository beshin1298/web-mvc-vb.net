Imports System.Web.Mvc

Namespace Controllers
    Public Class HelloWorldController
        Inherits Controller

        ' GET: HelloWorld
        Function Index() As ActionResult
            Return View()
        End Function

        Function Welcome(name As String) As ActionResult
            ViewBag.Message = "Hello " + name
            Return View()
        End Function
    End Class
End Namespace
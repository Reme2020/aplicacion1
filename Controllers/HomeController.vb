﻿Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Title") = "Home Page"

        Return View()
    End Function
    Function About() As ActionResult
        ViewData("Title") = "Descripcion de pagina"
        Return View()
    End Function


End Class

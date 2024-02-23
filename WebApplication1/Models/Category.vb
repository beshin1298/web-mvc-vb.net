Imports System.Data.Entity

Namespace WebMVC
    Public Class Category
        Public Property CategoryId As Integer
        Public Property name As String
    End Class
    Public Class MovieDBContext
        Inherits DbContext
        Public Property Movies As DbSet(Of category)
    End Class
End Namespace
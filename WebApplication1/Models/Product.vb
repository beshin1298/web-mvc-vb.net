Imports Microsoft.VisualBasic.Devices
Imports System.Data.Entity
Namespace WebMVC.Models
    Public Class Product
        Public productId As Integer
        Public name As String
        Public quantity As Integer
        Public categoryId As Integer
    End Class
    Public Class MovieDBContext
        Inherits DbContext
        Public Property Movies As DbSet(Of Product)
    End Class
End Namespace
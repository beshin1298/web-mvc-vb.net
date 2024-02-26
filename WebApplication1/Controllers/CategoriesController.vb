
Imports System.Data.Entity
Imports System.Net


Namespace Controllers
    Public Class CategoriesController
        Inherits System.Web.Mvc.Controller

        Private db As New VB_MVCEntities

        ' GET: Categories
        Function Index() As ActionResult
            Return View(db.categories.ToList())
        End Function

        ' GET: Categories/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim category As category = db.categories.Find(id)
            If IsNothing(category) Then
                Return HttpNotFound()
            End If
            Return View(category)
        End Function

        ' GET: Categories/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Categories/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="name")> ByVal category As category) As ActionResult
            If ModelState.IsValid Then
                db.categories.Add(category)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(category)
        End Function

        ' GET: Categories/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim category As category = db.categories.Find(id)
            If IsNothing(category) Then
                Return HttpNotFound()
            End If
            Return View(category)
        End Function

        ' POST: Categories/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="category_id,name")> ByVal category As category) As ActionResult
            If ModelState.IsValid Then
                db.Entry(category).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(category)
        End Function

        ' GET: Categories/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim category As category = db.categories.Find(id)
            If IsNothing(category) Then
                Return HttpNotFound()
            End If
            Return View(category)
        End Function

        ' POST: Categories/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim category As category = db.categories.Find(id)
            db.categories.Remove(category)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        <HttpPost()>
        <ActionName("Search")>
        <ValidateAntiForgeryToken()>
        Function Search(SearchString As String) As ActionResult
            Dim listCategories As List(Of category) = Nothing

            If Not String.IsNullOrEmpty(SearchString) Then
                listCategories = (From category In db.categories Where category.name.ToLower().Contains(SearchString.ToLower())).ToList()
            Else
                listCategories = db.categories.ToList()
            End If

            Return View("Index", listCategories)
        End Function


        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace

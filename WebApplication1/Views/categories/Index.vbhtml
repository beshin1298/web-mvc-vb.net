@ModelType IEnumerable(Of WebApplication1.category)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>DATA LIST</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table table-sm" >

    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
    <td>
        @Html.DisplayFor(Function(modelItem) item.category_id)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.name)
    </td>
    <td>
        @Html.ActionLink("Edit", "Edit", New With {.id = item.category_id}) |
        @Html.ActionLink("Details", "Details", New With {.id = item.category_id}) |
        @Html.ActionLink("Deletee", "Delete", New With {.id = item.category_id})
    </td>
</tr>
Next

</table>

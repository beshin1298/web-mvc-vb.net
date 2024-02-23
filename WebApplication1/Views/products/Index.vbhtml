@ModelType IEnumerable(Of WebApplication1.product)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.quantity)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.category.name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.quantity)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.category.name)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.product_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.product_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.product_id })
        </td>
    </tr>
Next

</table>

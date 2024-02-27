@ModelType IEnumerable(Of WebApplication1.product)
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Products</h2>

@Using (Html.BeginForm("Search", "Products", FormMethod.Post))
    @Html.AntiForgeryToken()
    @<div style="display:flex; height: 30px">
        @Html.TextBox("SearchString") <br />
        <br />

        <button type="submit" value="Search">
            <i class="fa fa-search" aria-hidden="true"></i>
        </button>
    </div>

End Using
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
                <button type="button" class="btn btn-primary" onclick="window.location.href='@Url.Action("Edit", "Products", New With {.id = item.product_id})'">
                    <i class="fa fa-cog" aria-hidden="true"></i>
                </button>
                <button type="button" class="btn btn-success" onclick="window.location.href='@Url.Action("Details", "Products", New With {.id = item.product_id})'">
                    <i class="fa fa-info" aria-hidden="true"></i>
                </button>

                <button type="button" class="btn btn-danger" onclick="location.href='@Url.Action("Delete", "Products", New With {.id = item.product_id})'">
                    <i class="fa fa-trash-o" aria-hidden="true"></i>

                </button>
            </td>
        </tr>
    Next

</table>
<button type="button" class="btn btn-primary" onclick="window.location.href='@Url.Action("Create", "Products")'">
    <i class="fa fa-plus" aria-hidden="true"></i>
</button>

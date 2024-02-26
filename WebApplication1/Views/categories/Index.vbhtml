@ModelType IEnumerable(Of WebApplication1.category)
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>DATA LIST</h2>


@Using (Html.BeginForm("Search", "categories", FormMethod.Post))
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
            Category Id
        </th>
        <th>
            Name
        </th>

        <th>
            Action
        </th>
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
                <button type="button" class="btn btn-primary" onclick="window.location.href='@Url.Action("Edit", "categories", New With {.id = item.category_id})'">
                    <i class="fa fa-cog" aria-hidden="true"></i>
                </button>
                <button type="button" class="btn btn-success" onclick="window.location.href='@Url.Action("Details", "categories", New With {.id = item.category_id})'">
                    <i class="fa fa-info" aria-hidden="true"></i>
                </button>

                <button type="button" class="btn btn-danger" onclick="location.href='@Url.Action("Delete", "categories", New With {.id = item.category_id})'">
                    <i class="fa fa-trash-o" aria-hidden="true"></i>

                </button>
            </td>
        </tr>
    Next

</table>
<button type="button" class="btn btn-primary" onclick="window.location.href='@Url.Action("Create", "categories")'">
    <i class="fa fa-plus" aria-hidden="true"></i>
</button>

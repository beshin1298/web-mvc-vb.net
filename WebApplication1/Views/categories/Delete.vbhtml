@ModelType WebApplication1.category
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this category?</h3>
<div>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            Category name
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.name)
        </dd>

    </dl>

    @If TempData.ContainsKey("ErrorMessage") Then
        @<div class="alert alert-danger">
            @TempData("ErrorMessage")
        </div>
    End If


    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>

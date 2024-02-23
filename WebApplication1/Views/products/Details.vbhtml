@ModelType WebApplication1.product
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>product</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.quantity)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.quantity)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.category.name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.category.name)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.product_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>

﻿@ModelType WebApplication1.category
@Code
    ViewData("Title") = "Edit"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Edit</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>category</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
        @Html.HiddenFor(Function(model) model.category_id)

        <div class="form-group">
            @Html.LabelFor(Function(model) model.name, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.name, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.name, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            <div>
                <input type="submit" value="Save" class="btn btn-primary mt-2" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section

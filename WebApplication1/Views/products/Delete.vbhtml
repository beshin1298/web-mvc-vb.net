@ModelType WebApplication1.product
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this product?</h3>
<div>
 
    <div class="container my-5">
        <div class="row">
            <div class="col-md-5">
                <div class="main-img">
                    <img class="img-fluid" src="@Model.image" alt="ProductS">
                    <!-- Thêm hình ảnh xem trước khác (nếu cần) -->
                </div>
            </div>
            <div class="col-md-7">
                <div class="main-description px-2">
                    <div class="category font-weight-bold">Category: @Model.category.name</div>
                    <h1 class="product-title">@Model.name</h1>
                    <p class="product-description"> Quantity in warehouse: @Model.quantity</p>

                </div>
           
            </div>

        </div>
        @Using (Html.BeginForm())
            @Html.AntiForgeryToken()

            @<div class="form-actions no-color">
                <input  type="submit" value="Delete" class="btn btn-danger" /> |
                @Html.ActionLink("Back to List", "Index")
            </div>
        End Using
    </div>

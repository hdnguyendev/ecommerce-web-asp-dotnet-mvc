filterSelection("all")
function filterSelection(c) {
    var x, i;
    x = document.getElementsByClassName("product-item");
    if (c == "all") c = "";
    // Add the "show" class (display:block) to the filtered elements, and remove the "show" class from the elements that are not selected
    var hasShownItems = false;
    for (i = 0; i < x.length; i++) {
        w3RemoveClass(x[i], "show");
        if (x[i].className.indexOf(c) > -1) {
            w3AddClass(x[i], "show");
            hasShownItems = true;
        }
    }
    // Show the "No products" div if no items are shown
    var noProductDiv = document.getElementById("noProduct");
    if (hasShownItems) {
        noProductDiv.style.display = "none";
    } else {
        noProductDiv.style.display = "block";
    }
}
// Show filtered elements
function w3AddClass(element, name) {
    var i, arr1, arr2;
    arr1 = element.className.split(" ");
    arr2 = name.split(" ");
    for (i = 0; i < arr2.length; i++) {
        if (arr1.indexOf(arr2[i]) == -1) {
            element.className += " " + arr2[i];
        }
    }
}

// Hide elements that are not selected
function w3RemoveClass(element, name) {
    var i, arr1, arr2;
    arr1 = element.className.split(" ");
    arr2 = name.split(" ");
    for (i = 0; i < arr2.length; i++) {
        while (arr1.indexOf(arr2[i]) > -1) {
            arr1.splice(arr1.indexOf(arr2[i]), 1);
        }
    }
    element.className = arr1.join(" ");
}

// Add active class to the current control button (highlight it)
var btnContainer = document.getElementById("myBtnContainer");
var btns = btnContainer.getElementsByClassName("btn");
for (var i = 0; i < btns.length; i++) {
    btns[i].addEventListener("click", function () {
        var current = document.getElementsByClassName("active");
        current[0].className = current[0].className.replace(" active", "");
        this.className += " active";
    });
}

$(document).ready(function () {
    $('a.item-btn').click(function (e) {
        e.preventDefault();

        var customerId = $(this).data('customer-id');
        var productId = $(this).data('product-id');

        $.ajax({
            url: '/Carts/AddToCart',
            type: 'POST',
            mode: 'cors',
            data: {
                Quantity: 1, // Giá trị của Quantity nếu cần

                CustomerId: customerId,
                ProductId: productId
            },
            success: function (response) {
                // Xử lý khi gửi thành công
                if (response.success) {
                    alert("Add product to Cart successfully!")
                }
            },
            error: function (xhr, status, error) {
                // Xử lý khi gửi thất bại
                alert("Error!")
                console.log(error);
            }
        });
    });
});

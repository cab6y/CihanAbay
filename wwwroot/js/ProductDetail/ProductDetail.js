
function addBasket(id) {

    $.post("/ProductDetail/AddProduct?productID=" + id , function () {
    });
}
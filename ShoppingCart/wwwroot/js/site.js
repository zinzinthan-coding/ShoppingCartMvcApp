let listCartHTML = document.querySelector('.listCart');
let iconCart = document.querySelector('.icon-cart');
let body = document.querySelector('body');
let closeCart = document.querySelector('.close');

// open and close tab
iconCart.addEventListener('click', () => {
    body.classList.toggle('activeTabCart');
})
closeCart.addEventListener('click', () => {
    body.classList.toggle('activeTabCart');
})

//===================AddToCart()=========================//
function addtoCart(id) {

    $.ajax({
        url: '/product/create',
        type: 'POST',
        data: {
            id: id
        },
        success: function (data) {
            $("#count").html(data);
        },
        error: function (request, status, error) {
            console.log({ request, status, error });
        }
    });
}

//======================End===============================//

//===================UpdateCart()=========================//
function updateCart(id) {

    $.ajax({
        url: '/product/update',
        type: 'POST',
        data: {
            id: id
        },
        success: function (data) {
            $("#count").html(data);
        },
        error: function (request, status, error) {
            console.log({ request, status, error });
        }
    });
}

//=========================End===============================//

//========================ShowCart()========================//
function showCart() {
    $.ajax({
        url: '/product/list',
        type: 'GET',
        success: function (data) {
            if (data != null) {
                console.log(data);
           
            listCartHTML.innerHTML = '';
            data.forEach(item => {
                console.log(item);

                listCartHTML.innerHTML += `
                    <div class="item">
                        <div class="image">
                           <img src="~/images/${item.Image}">
                        </div>
                        <div class="name">
                            ${item.ProductName}
                        </div>
                        <div class="totalPrice">$${item.Price * item.quantity}
                        </div>
                        <div class="quantity">
                            <span class="minus" data-id="${item.Id}"><</span>
                            <span>${item.Quantity}</span>
                            <span class="plus" data-id="${item.id}">></span>
                        </div>
                    </div>
                `;
            })
        },
        error: function (request, status, error) {
            console.log({ request, status, error });
        }
    });
}
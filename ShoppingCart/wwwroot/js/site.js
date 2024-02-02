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
            showCart();
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
            showCart();
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
            console.log(data);
            if (data != null) {

                listCartHTML.innerHTML = '';
                data.forEach(item => {
                    console.log(item);

                    listCartHTML.innerHTML += `
                        <div class="item">
                            <div class="image">
                               <img src="/images/${item.image}">
                            </div>
                            <div class="name">
                                ${item.productName}
                            </div>
                            <div class="totalPrice">$${item.totalPrice}
                            </div>
                            <div class="quantity">
                                <span class="minus" onclick="updateCart(${item.productId})"><</span>
                                <span>${item.quantity}</span>
                                <span class="plus" onclick="addtoCart(${item.productId})">></span>
                            </div>
                        </div>
                    `;
                })
            }
        },
        error: function (request, status, error) {
            console.log({ request, status, error });
        }
    });
}

//=============================End===========================//
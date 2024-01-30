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


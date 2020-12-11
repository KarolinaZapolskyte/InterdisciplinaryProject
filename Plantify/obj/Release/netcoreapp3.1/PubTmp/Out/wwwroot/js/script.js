// Function for the adding the quantity on the specific product page quantity field, where the max is the amount we have in stock
function up() {
    document.getElementById("myNumber").value = parseInt(document.getElementById("myNumber").value) + 1;
    const max = parseInt(document.getElementById('hidden-stock').innerHTML);
    if (document.getElementById("myNumber").value >= parseInt(max)) {
        document.getElementById("myNumber").value = max;
    }
}

// Function for the reducing the quantity on the specific product page quantity field
function down() {
    document.getElementById("myNumber").value = parseInt(document.getElementById("myNumber").value) - 1;
    const min = 1;
    if (document.getElementById("myNumber").value <= parseInt(min)) {
        document.getElementById("myNumber").value = min;
    }
}

// Function for shortening dscription of the product on the cart page to a whole word and running the disButton & noStock functions
function shortenDescription() {
    if (window.location.toString().includes("Cart?returnUrl=%")) {
        for (let i = 0; i < document.getElementsByClassName('cart-product-description').length; i++) {
            let description = document.getElementsByClassName('cart-product-description')[i].innerText
            description = (i, shorten(description, 125));
            document.getElementsByClassName('cart-product-description')[i].innerText = description + " ..."
        }
        disButtons();
    }
    noStock();
}

// Function for shortening the description
function shorten(str, maxLen, separator = ' ') {
    if (str.length <= maxLen) return str;
    return str.substr(0, str.lastIndexOf(separator, maxLen));
}

// Function for disabling a "Proceed to checkout" button id there is 0 elements in a cart
function disButtons() {
    if (!document.getElementsByClassName("all-products")[0]) {
        document.getElementsByClassName("button-hide")[0].style.display = "none";
        document.getElementsByClassName("button-show")[0].style.display = "block"
    }
}

// Function for putting quantity value to 0 and disabling the button, if the we don't have item in stock
function noStock() {
    if (window.location.toString().includes("ProductPage")) {
        if (parseInt(document.getElementById('hidden-stock').innerHTML) === 0) {
            document.getElementById('myNumber').value = 0;
            const button = document.getElementsByClassName('pull-right')[0];
            const buttonGrey = document.getElementsByClassName('out-of-stock')[0];
            button.style.display = "none";
            buttonGrey.style.display = "block";
        }
    }
}
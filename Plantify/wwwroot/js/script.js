function up() {
    document.getElementById("myNumber").value = parseInt(document.getElementById("myNumber").value) + 1;
    const max = 15;
    if (document.getElementById("myNumber").value >= parseInt(max)) {
        document.getElementById("myNumber").value = max;
    }
}
function down() {
    document.getElementById("myNumber").value = parseInt(document.getElementById("myNumber").value) - 1;
    const min = 1;
    if (document.getElementById("myNumber").value <= parseInt(min)) {
        document.getElementById("myNumber").value = min;
    }
}

function shortenDescription() {
    if (window.location.search === "?returnUrl=%2F") {
        for (let i = 0; i < document.getElementsByClassName('cart-product-description').length; i++) {
            let description = document.getElementsByClassName('cart-product-description')[i].innerText
            description = (i, shorten(description, 125));
            document.getElementsByClassName('cart-product-description')[i].innerText = description + " ..."
        }
        disButtons();
    }
}

function shorten(str, maxLen, separator = ' ') {
    if (str.length <= maxLen) return str;
    return str.substr(0, str.lastIndexOf(separator, maxLen));
}

// Disable button 
function disButtons() {
    if (!document.getElementsByClassName("all-products")[0]) {
        document.getElementsByClassName("button-hide")[0].style.display = "none";
        document.getElementsByClassName("button-show")[0].style.display = "block"
    }
}
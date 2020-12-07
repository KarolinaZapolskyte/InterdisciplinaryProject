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

function addToCart() {
    //window.location = '/Cart?returnUrl=%2F'

}
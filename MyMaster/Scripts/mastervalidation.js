/*
function showError(container, errorMessage) {
    container.className = 'error';
    var msgElem = document.createElement('span');
    msgElem.className = "error-message";
    msgElem.innerHTML = errorMessage;
    container.appendChild(msgElem);
}

function resetError(container) {
    container.className = '';
    if (container.lastChild.className == "error-message") {
        container.removeChild(container.lastChild);
    }
}

function masterValidate(form) {
    var elems = form.elements;

    resetError(elems.first_name.parentNode);
    if (!elems.first_name.value) {
        showError(elems.first_name.parentNode, ' Введите имя');
    }

}

*/

$(document).ready(function () {

    $("#reg-form")
})

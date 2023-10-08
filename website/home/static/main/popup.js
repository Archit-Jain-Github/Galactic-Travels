function createPopup(id) {
    let popupNode = document.querySelector(id);
    let overlay = popupNode.querySelector(".overlay");
    let closeBtn = popupNode.querySelector(".close-btn");
    let submitBtn = popupNode.querySelector(".submit-btn");

    function openPopup() {
        popupNode.classList.add("active");
    }

    function closePopup() {
        popupNode.classList.remove("active");
    }

    function submitForm() {
        let fullName = document.getElementById("full-name").value;
        let email = document.getElementById("email").value;
        closePopup();
    }

    overlay.addEventListener("click", closePopup);
    closeBtn.addEventListener("click", closePopup);
    submitBtn.addEventListener("click", submitForm);

    return openPopup;
}

let popup = createPopup("#popup");
document.querySelector("#open-popup").addEventListener("click", popup);

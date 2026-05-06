let label = document.getElementById("label")

function printText() {
    label.textContent = "Hello World";
}
function toBold() {
    label.classList.toggle("bold");
}
function toItalic() {
    label.classList.toggle("italic");


}
function toUnderline() {
    label.classList.toggle("underline");

}
function toReset() {
    label.className = "";
}
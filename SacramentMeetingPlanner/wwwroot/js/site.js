document.addEventListener('DOMContentLoaded', function() {

    let speaker2 = document.getElementById("speaker2").innerHTML.trim();
    let speaker3 = document.getElementById("speaker3").innerHTML.trim();
    let speaker4 = document.getElementById("speaker4").innerHTML.trim();
    let musicValue = document.getElementById("musicValue").innerHTML.trim();

    let speaker2Div = document.getElementById("speaker2Div");
    let speaker3Div = document.getElementById("speaker3Div");
    let speaker4Div = document.getElementById("speaker4Div");
    let musicValueDiv = document.getElementById("musicValueDiv");

    if (!speaker2) {
        speaker2Div.style.display = "none";
    }
    if (!speaker3) {
        speaker3Div.style.display = "none";
    }
    if (!speaker4) {
        speaker4Div.style.display = "none";
    }
    if (musicValue == '""') {
        musicValueDiv.style.display = "none";
    }
});
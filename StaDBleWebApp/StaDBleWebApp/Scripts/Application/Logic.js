/// <reference path="../typings/jquery/jquery.d.ts" />
var StableModel = (function () {
    function StableModel() {
    }
    return StableModel;
}());
function initHorseAssignment() {
    $("#AssingHorseButton").click(function () {
        // alert("Toimii");
        var horseCode = $("#HorseCode").val();
        var stableCode = $("#StableCode").val();
        alert("H: " + horseCode);
        alert("S: " + stableCode);
        var data = new StableModel();
        data.HorseCode = horseCode;
        data.StableCode = stableCode;
        //lähetetään JSON-muotoista dataa palvelimelle
        $.ajax({
            type: "POST",
            url: "/StaDBle/Horse",
            data: JSON.stringify(data),
            contentType: "application/json",
            success: function (data) {
                if (data.success == true) {
                    alert("Horse successfully assigned.");
                }
                else {
                    alert("there was an error: " + data.error);
                }
            },
            dataType: "json"
        });
    });
}
//# sourceMappingURL=Logic.js.map
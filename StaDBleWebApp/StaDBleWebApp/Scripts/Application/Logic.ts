/// <reference path="../typings/jquery/jquery.d.ts" />

class StableModel {
    public HorseCode: string;
    public StableCode: string;
    }

function initHorseAssignment() {
    $("#AssingHorseButton").click(function () {
        // alert("Toimii");
        var horseCode: string = $("#HorseCode").val();
        var stableCode: string = $("#StableCode").val();

        alert("H: " + horseCode);
        alert("S: " + stableCode);

        var data: StableModel = new StableModel();
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
                    // $(".result").html(data);
                }
                },
            dataType: "json"
        });

    });
}

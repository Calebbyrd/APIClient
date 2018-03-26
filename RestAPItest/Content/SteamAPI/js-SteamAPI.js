function getSteamApps() {
    $.ajax({
        url: "/SteamAPI/GetSteamApps",
        success: function (data) {
            $("#AppListPartialWrapper").html(data);
        }
    });
}

function getSteamProfileByVanityUrl() {
    var data = {
        vanityUrl: $("#profileSearch").val()
};
    $.ajax({
        url: "/SteamAPI/GetUserIdFromVanityUrl",
        data: data,
        success: function (data) {
            $("#profileInfoWrapper").html(data);
        }
    });
}
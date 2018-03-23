function getSteamApps() {
    $.ajax({
        url: "/SteamAPI/GetSteamApps",
        success: function(data) {
            debugger;
        }
    });
}
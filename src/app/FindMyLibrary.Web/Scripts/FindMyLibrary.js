function FindMyLibrary() {
}

FindMyLibrary._callbackStateList = function() {
    $.post("/State/GetStates", FindMyLibrary._renderStates, "json");
};

FindMyLibrary._renderStates = function(states) {
    $("#stateList").empty();

    $.each(states, function(i, state) {
        $('#stateList').append($('<li/>')
            .attr("class", "stateItem")
        );
    });
};
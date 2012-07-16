function FindMyLibrary() {
}

FindMyLibrary._callbackStateList = function() {
    $.post("/State/GetStates", FindMyLibrary._renderStates, "json");
};

FindMyLibrary._renderStates = function(states) {
    $("#stateList").empty();

    $.each(states, function(i, state) {
        $('#stateList').append($('<li/>')
            .append(_getStateLinkHTML(state))
        );
    });
};

function _getStateLinkHTML(state) {
    return '<a href="' + state.Url + '">' + state.Name + '</a>';
}
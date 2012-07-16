function FindMyLibrary() {
}

FindMyLibrary._callbackStateList = function() {
    $.post("/State/GetStates", FindMyLibrary._renderStates, "json");
};

FindMyLibrary._renderStates = function(states) {
    $("#stateList").empty();

    $.each(states, function(i, state) {
        $('#stateList').append(_getStateLinkHTML(state));
    });
};

function _getStateLinkHTML(state) {
    var str = '';
    if (state.StateId % 4 == 0)
        str = '<div class="row"><div class="span4"/><div class="span8>';
    str = str + '<a href="/City/' + state.Url + '">' + state.Name + '</a></td>';
    if (state.StateId % 8 == 0)
        str = str + '</div></div>';
    return str;
}
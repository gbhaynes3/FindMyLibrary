function FindMyLibrary() {
}

FindMyLibrary._callbackStateList = function() {
    $.post("/State/GetStates", FindMyLibrary._renderStates, "json");
};

FindMyLibrary._renderStates = function(states) {
   $("#stateList").empty();


    $('#stateList').append('<div class="row">');
    $.each(states, function(i, state) {
        $('#stateList').append(_getStateLinkHTML(state));
    });
    $('#stateList').append('</div>');
    
};

function _getStateLinkHTML(state) {
    var str = '';
    var startString = '<div class="row">';

    str = str + '<div class="span3"><a href="' + state.Url + '">' + state.Name + '</a></div>';
    if (state.StateId % 3 == 0)
        str = str + '</div>' + startString;
    return str;
}
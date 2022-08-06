// Use server-side JavaScript to filter your audience further
// You have full access to the guest context which can be accessed under guest, e.g. guest.email
// Any truthy return value will pass the audience filter, it is recommended to return an object
// The value returned can be accessed from the variant API response as 'filter'


(function () {
    var guestSessions = guest.sessions;

    var resultFlag = false;

    for (var ses = 0; ses < guestSessions.length; ses++) {

        var sessionVar = guestSessions[ses];
        var sesEvents = sessionVar.events;

        for (var evnt = 0; evnt < sesEvents.length; evnt++) {

            var eventVar = sesEvents[evnt];
            if (eventVar.type === "ALERT_BAR_DISMISSED") {
                resultFlag = true;
                break;
            }

        }
        if (resultFlag) {
            break;
        }
    }
    if (checkAlreadyDismissed()) {
        return false;
    }
    else {
        return resultFlag;
    }
})();

function checkAlreadyDismissed() {
    var guestSessions = guest.sessions;

    var resultFlag = false;

    for (var ses = 0; ses < guestSessions.length; ses++) {

        var sessionVar = guestSessions[ses];
        var sesEvents = sessionVar.events;

        for (var evnt = 0; evnt < sesEvents.length; evnt++) {

            var eventVar = sesEvents[evnt];
            if (eventVar.type === "ALT_SIDEBAR_DISMISSED") {
                resultFlag = true;
                break;
            }

        }
        if (resultFlag) {
            break;
        }
    }
    return resultFlag;
}
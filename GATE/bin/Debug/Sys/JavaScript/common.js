var callback = arguments[arguments.length - 1];
var logs = new Array();

function sleep(ms) {
    return new Promise((resolve) => setTimeout(resolve, ms));
}

function returnError(msg) {
    log("ERR", msg);
    callback(logs);
}

function returnSuccess() {
    callback(logs);
}

function findElement(searchType, searchParam) {
    switch (searchType) {
        case "id":
            return document.getElementById(searchParam)
            break;
        case "xpath":
            return document.evaluate(searchParam, document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue;
    }
}

function log(type, msg) {
    logs.push("[" + type + "] " + msg);
}




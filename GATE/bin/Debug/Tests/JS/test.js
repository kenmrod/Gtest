async function myScript() {
    // navigate to PDMPART
    findElement("xpath", "//*[text()='Materials']").click();
    findElement("xpath", "//*[text()='Product Definition']").click();
    findElement("xpath", "//*[text()='Items']").click();
    findElement("xpath", "//*[text()='Manage Parts']").click();
    await sleep(5000);

    //verify PART ID exists
    var pid = findElement("id", "PART_ID");
    if (!pid) {
        returnError("Part ID not found.");
    }
    else {
        log("INF", "Part ID found. Testing if I can set value...");
        pid.value = "JP_VALLE";
    }

    // click query
    findElement("xpath", "//*[@id='PART_ID']/ancestor::form[1]//*[text()='Query']").click();

    // random search
    findElement("id", "basicField0").value = "XY";

    // click Find in Query
    findElement("id", "submitQ").click();
    await sleep(1000);

    // verify Value of Part ID changed
    if (pid.value != "XY-PART")
        returnError("XY-PART not found. Expected to be found.");

    //verify FAKE element
    if (!findElement("id", "HUHUHU"))
        returnError("HUHU not found");

    returnSuccess();
}

return myScript();
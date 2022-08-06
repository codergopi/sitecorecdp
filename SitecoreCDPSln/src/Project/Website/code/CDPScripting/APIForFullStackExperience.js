<#-- Construct the API response using Freemarker -->
    <#-- For your Experience to run your API tab must have, at a minimum, open and closing brackets -->
    {
        "firstName": "${guest.fistName!""}",
        "lastName": "${guest.lastName!""}",
        "emailid": "${guest.email!""}",
    <#if(offers) ??>
        "decisionOffers": ${ toJSON(offers) }
    </#if >
}
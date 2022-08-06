(function () {
    return {
        "TopBuyer": guest.orders && guest.orders.length > 3,
        "HasOrders": guest.orders && guest.orders.length !== 0
    }
})();
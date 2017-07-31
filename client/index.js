(function () {
    var url = 'data/data.json';
    var mainData = [];

    $('#colors').on('change', function () {
        console.debug("  sizes = ", mainData[this.value].sizes);
        $('#sizes')[0].options.length = 0;
        var sizes = mainData[this.value].sizes;
        $.each(sizes, function (index, el) {
            $('#sizes').append($('<option>', {
                value: el.name,
                text: el.name
            }));
        });        
    });


    $.get(url).then(function (data) {
        //populate the main dropdown
        var skus = data.products[0].skus;
        $.each(skus, function (index, sku) {
            var itemfound = mainData.find(function (el) {
                return el.color ==sku.image.url;
            });
            var el = itemfound;
            if (el) {
                el.sizes.push(sku.size);

            } else {
                el = {
                    id:  sku.id,
                    color: sku.image.url,
                    sizes: []
                };
                el.sizes.push(sku.size);
                mainData.push(el);
            }
        });
    }).then(function () {
        $('#colors')[0].options.length = 0;

        $.each(mainData, function (index, el) {
            $('#colors').append($('<option>', {
                value: index,
                text: el.color
            }));
        });
    });
})();
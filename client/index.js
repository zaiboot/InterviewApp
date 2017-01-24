(function(){
    var url = 'data/data.json';
    var mainData = [];
    $.get(url).then(function(data){
        //populate the main dropdown
        var skus = data.products[0].skus;
        $.each(skus, function( index, sku){
            var el = {
                color: sku.image.url,
                sizes: sku.size
            };
            mainData.push(el);
        });
    }).then(function(){
        $('#colors')[0].options.length = 0;

        $.each(mainData, function( index, el){
            console.log("adsadas");
            $('#colors').append($('<option>', { 
                    value: index,
                    text : el.color
                }));
        });
    });
})();
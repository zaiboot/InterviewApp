var express = require('express');
var app = express();
var port = process.env.PORT || 5000;
var options = {
  index: "index.html"
};
app.use(express.static('../client', options));

app.listen(port, function(err) {
    console.log('Running server on port: ', port);
});
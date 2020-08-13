var http = require('http')
console.log('Http web server')
var port = 8080;
http.createServer((request,response) => {
    console.log("Http request received")
    response.writeHead(200,{'Content-Type':'text/plain'})
    response.end('text sent to webpage ')
}).listen(port,'127.0.0.1');

console.log('server listening on port ' + port)
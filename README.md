# RedisWrapper


PS C:\Users\adrianpoplavsky> (Invoke-WebRequest "http://site.azurewebsites.net/api/entities/building/1").Conten
t
{"id":"1","sarasa":"Marcelo","legajo":"239722"}
PS C:\Users\adrian.poplavsky> Invoke-WebRequest "http://site.azurewebsites.net/api/entities/building/1" -Body '{
"id": "1","sarasa": "Marcelo","legajo": "239722"}' -Method POST -ContentType "application/json"


StatusCode        : 204
StatusDescription : No Content
Content           : {}
RawContent        : HTTP/1.1 204 No Content
                    Pragma: no-cache
                    Connection: Keep-Alive
                    Cache-Control: no-cache
                    Date: Fri, 01 Apr 2016 21:46:12 GMT
                    Expires: -1
                    Set-Cookie: ARRAffinity=a8e234633e0f83cc6e85d3...
Headers           : {[Pragma, no-cache], [Connection, Keep-Alive], [Cache-Control, no-cache], [Date, Fri, 01 Apr 2016
                    21:46:12 GMT]...}
RawContentLength  : 0

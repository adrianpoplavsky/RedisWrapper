# RedisWrapper


PS C:\Users\adrianpoplavsky> (Invoke-WebRequest "http://site.azurewebsites.net/api/entities/building/1").Content
{"id":"1","sarasa":"Marcelo","legajo":"239722"}

PS C:\Users\adrianpoplavsky> Invoke-WebRequest "http://site.azurewebsites.net/api/entities/building/1" -Body '{"id": "1","sarasa": "Marcelo","legajo": "239722"}' -Method POST -ContentType "application/json"
StatusCode        : 204
StatusDescription : No Content
Content           : {}
RawContent        : HTTP/1.1 204 No Content
RawContentLength  : 0

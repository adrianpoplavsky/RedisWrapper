# RedisWrapper

Requires appsettings to be added to the web.config. Set rediscachename & rediscachepassword settings with your values:
<appSettings>
  <add key="webpages:Version" value="3.0.0.0" />
  <add key="webpages:Enabled" value="false" />
  <add key="ClientValidationEnabled" value="true" />
  <add key="UnobtrusiveJavaScriptEnabled" value="true" />

  <add key="redisCacheName" value="YourRedisCacheName" />
  <add key="redisCachePassword" value="YourRedisCachePassword" />
</appSettings>

Examples:
PS C:\Users\adrianpoplavsky> (Invoke-WebRequest "http://site.azurewebsites.net/api/entities/get/building/1").Content
{"id":"1","sarasa":"Marcelo","legajo":"239722"}

PS C:\Users\adrianpoplavsky> Invoke-WebRequest "http://site.azurewebsites.net/api/entities/set/building/1" -Body '{"id": "1","sarasa": "Marcelo","legajo": "239722"}' -Method POST -ContentType "application/json"
StatusCode        : 204
StatusDescription : No Content
Content           : {}
RawContent        : HTTP/1.1 204 No Content
RawContentLength  : 0

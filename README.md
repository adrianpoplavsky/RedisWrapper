# RedisWrapper
.net-based Webapi webservice that wraps commands from a REDIS cache.

Commands currently implemented:
<ol>
<li>get</li>
<li>set</li>
</ol>

Requires appsettings to be added to the web.config. Set rediscachename & rediscachepassword settings with your values:
```
<appSettings>
  <add key="webpages:Version" value="3.0.0.0" />
  <add key="webpages:Enabled" value="false" />
  <add key="ClientValidationEnabled" value="true" />
  <add key="UnobtrusiveJavaScriptEnabled" value="true" />

  <add key="redisCacheName" value="YourRedisCacheName" />
  <add key="redisCachePassword" value="YourRedisCachePassword" />
</appSettings>
```

Examples:
<pre><code>PS C:\Users\adrianpoplavsky> (Invoke-WebRequest "http://site.azurewebsites.net/api/entities/get/building/1").Content
{"id":"1","sarasa":"Marcelo","legajo":"239722"}</code></pre>

<pre><code>PS C:\Users\adrianpoplavsky> Invoke-WebRequest "http://site.azurewebsites.net/api/entities/set/building" -Body '{"id": "1","sarasa": "Marcelo","legajo": "239722"}' -Method POST -ContentType "application/json"
StatusCode        : 204
StatusDescription : No Content
Content           : {}
RawContent        : HTTP/1.1 204 No Content
RawContentLength  : 0
</code></pre>

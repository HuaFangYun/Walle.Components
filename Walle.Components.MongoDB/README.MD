# Walle.Components.MongoDB

[toc]

## 安装

### 使用 Package Manager:

```
Install-Package Walle.Components.MongoDB -Version 1.0.0
```

### 使用.NetCore CLI:

```
dotnet add package Walle.Components.MongoDB --version 1.0.0
```

## 配置示例

1. 在 ` appsettings.json` 中添加以下节点:

```
{
  "MongoDBConfig": {
    "ConnectionStr": "mongodb://127.0.0.1:27017/walle",
    "DatabaseName": "walle"
  }
}
```

2. 在 `Startup.cs` 中注册依赖:

```csharp

private IConfiguration Configuration { get; }
public Startup(IConfiguration configuration)
{
    Configuration = configuration;
}

public void ConfigureServices(IServiceCollection services)
{
    services.ConfigureMongoDB(Configuration);
}

```

## 实体示例

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Walle.Components.MongoDB;

namespace Demo
{
    public class ActivityModel : MongoEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
```

## 调用示例

```cs
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Demo;
using Demo.BaseModels;
using Demo.Models;
using Walle.Components.MongoDB;

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly ILogger<ActivityController> _logger;

        private IMongoDBCollection<ActivityModel> ActivityCollection { get; }

        public ActivityController(ILogger<ActivityController> logger, IMongoDBCollection<ActivityModel> collection)
        {
            _logger = logger;
            this.ActivityCollection = collection;
        }

        [HttpGet]
        public RespList<ActivityModel> GetAll()
        {
            RespList<ActivityModel> resp = new RespList<ActivityModel>();
            try
            {
                var sources = ActivityCollection.AsQueryable()?.ToList();
                resp.Message = $"{sources.Count()} record(s) matches.";
                resp.Data = sources;
            }
            catch (Exception ex)
            {
                var msg = "Exception occured when get all the activities.";
                _logger.LogError(ex, msg);
                resp.Message = msg;
                resp.Code = (int)RespCode.Exception;
                resp.IsSuccess = false;
            }
            return resp;
        }
    }
}

```

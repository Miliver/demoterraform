namespace DemoTerraform.Controllers

open System
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open DemoTerraform

[<ApiController>]
[<Route("[controller]")>]
type HealthCheckController (logger : ILogger<HealthCheckController>) =
    inherit ControllerBase()

    [<HttpGet>]
    member _.Get() =
        {|
            State = HealtCheckState.Ok
            Running = DateTime.UtcNow - System.Diagnostics.Process.GetCurrentProcess().StartTime
        |}

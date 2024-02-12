namespace DemoTerraform

open System

type HealtCheckState =
| Ok = 0
| Nok = 1

type HealtCheckReport =
    { State: HealtCheckState
      Running: TimeSpan }

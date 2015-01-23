// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    let foo = new Newtonsoft.Json.Converters.BinaryConverter()
    0 // return an integer exit code

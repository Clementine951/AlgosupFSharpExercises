namespace CalculatorAppXeto.Mac
module Program =

    open System
    open CalculatorAppXeto

    [<EntryPoint>]
    [<STAThread>]
    let Main(args) =
        let app = new Eto.Forms.Application(Eto.Platforms.Mac64)
        app.Run(new MainForm())
        0
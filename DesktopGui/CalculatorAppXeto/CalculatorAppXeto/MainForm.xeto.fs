namespace CalculatorAppXeto

open System
open Eto.Forms
open Eto.Drawing
open Eto.Serialization.Xaml;

type MainForm() as this =
    inherit Form()

    do XamlReader.Load(this)

    let displayTextBox = this.FindChild<TextBox>("display")

    member this.HandleClick(sender:obj, e:EventArgs) =
        match box sender with
        | :? Button as b ->
            MessageBox.Show("Click button: " + b.Text) |> ignore
        | _ -> MessageBox.Show("Unknown control") |> ignore

    member this.HandleQuit(sender:obj, e:EventArgs) =
        Application.Instance.Quit()
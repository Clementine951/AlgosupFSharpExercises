namespace CalculatorApp

open System
open Eto.Forms
open Eto.Drawing

type MainForm () as this =
    inherit Form()
    do
        this.Title <- "My Calculator App"
        this.MinimumSize <- new Size(200, 200)
        this.Padding <- new Padding(10)

        let handleClick sender eventArgs =
            match box sender with
            | :? Button as b ->
                MessageBox.Show("Click button: " + b.Text) |> ignore
            | _ -> MessageBox.Show("Unknown control") |> ignore

        let createButton text =
            let b = new Button(Text=text)
            b.Click.Add(handleClick b)
            b

        let layout = new StackLayout()
        let displayTextBox = new TextBox(Text = "", ReadOnly = true)
        let buttonRow = new StackLayout(Orientation=Orientation.Horizontal)
        buttonRow.Items.Add(new StackLayoutItem(createButton "7"))
        buttonRow.Items.Add(new StackLayoutItem(createButton "8"))
        buttonRow.Items.Add(new StackLayoutItem(createButton "9"))
        buttonRow.Items.Add(new StackLayoutItem(createButton "*"))

        layout.Items.Add(new StackLayoutItem(displayTextBox, HorizontalAlignment=HorizontalAlignment.Stretch))
        layout.Items.Add(new StackLayoutItem(buttonRow))

        this.Content <- layout;


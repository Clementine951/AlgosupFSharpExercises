module EBuyrZ.Search

open EBuyrZ.ClientModel
open EBuyrZ.Shared
open Feliz
open Feliz.Bulma

let view (model: Model) (dispatch: Msg -> unit) =
    Bulma.box [
        Bulma.field.div [
            field.isGrouped
            prop.children [
                Bulma.control.p [
                    control.isExpanded
                    prop.children [
                        Bulma.input.text [
                            prop.value model.Input
                            prop.placeholder "What are you lookiiiiiiiiiiiiing for?"
                            prop.onChange (fun x -> SetInput x |> dispatch)
                            prop.style  [style.width 980]
                        ]
                    ]
                ]
                Bulma.control.p [
                    Bulma.button.a [
                        color.isPrimary
                        prop.disabled (Search.isValid model.Input |> not)
                        prop.onClick (fun _ -> dispatch Search)
                        prop.text "Search"
                    ]
                ]
            ]
        ]



        Bulma.control.p [
        for item in model.Items do
            if item.Images.IsEmpty |> not then
                Bulma.field.div [
                    prop.children [
                        Html.img [ prop.src (List.head item.Images); prop.style [style.height 300] ]
                        Html.p [ prop.text item.Name ]
                        Html.button [ 
                            color.isPrimary
                            // prop.onClick (fun _ -> dispatch Search)
                            prop.text "Add to basket"
                        ]
                        Html.p [ prop.text $"Price: {item.Price} €" ]
                    ]
                    prop.style [style.width 300]
                ]
                
        ]
    ]

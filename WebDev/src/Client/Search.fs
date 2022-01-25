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
                            prop.placeholder "What are you looking for?"
                            prop.onChange (fun x -> SetInput x |> dispatch)
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
                Html.img [ prop.src (List.head item.Images); prop.style [style.height 300] ]
            Html.p [ prop.text item.Name ]
            Html.p [ prop.text item.Description ]
            // Html.p [ prop.text item.Price ]
            Html.button [ 
                // prop.onClick (fun _ -> dispatch Search)
                prop.text "Add to Basket"
             ]
        ]
   ]

module EBuyrZ.Index

open Fable.React
open Fable.Core.JsInterop
open ReactRouter.Link
open EBuyrZ.ClientModel
open Feliz
open Feliz.Bulma


let view (model: Model) (dispatch: Msg -> unit) =
    Bulma.box [
        Bulma.content [
            Html.ul [
                    Html.li [ Html.a [  prop.href "/views/html-demo"; prop.text "Html View"]  ]
                    Html.li [ Html.a [  prop.href "/views/json-demo"; prop.text "Json View"]  ]
                    Html.li [ Link [To (!^ "/search")] [str "Search"] ]
            ]
            Bulma.control.p [
                for item in model.FrontPageItems do
                    if item.Images.IsEmpty |> not then
                        Html.img [ prop.src (List.head item.Images) ]
                    Html.p [ prop.text item.Name ]
                    Html.p [ prop.text item.Description ]
            ]

        ]
    ]


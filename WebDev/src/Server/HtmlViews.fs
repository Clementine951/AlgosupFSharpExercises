module EBuyrZ.HtmlViews

open System
open Giraffe.ViewEngine

let layout (content: XmlNode list) =
    html [] [
        head [] [
            title []  [ encodedText "FSharpGiraffe" ]
            link [ _rel  "stylesheet"
                   _type "text/css"
                   _href "https://cdn.jsdelivr.net/npm/bulma@0.9.0/css/bulma.min.css" ]
        ]
        body [] content
    ]

let partial () =
    h1 [] [ encodedText "Html View" ]

let index () =
    [
        partial()
        p [] [ encodedText ("Page generated at: " + DateTime.Now.ToShortTimeString()) ]
    ] |> layout



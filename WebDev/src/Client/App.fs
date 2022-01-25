module EBuyrZ.App

open EBuyrZ
open Fable.React
open Fable.Core.JsInterop
open ReactRouter.BrowserRouter
open ReactRouter.Link
open ReactRouter.Switch
open ReactRouter.Route

open Feliz
open Feliz.Bulma

open Elmish
open Elmish.React

#if DEBUG
open Elmish.Debug
open Elmish.HMR
#endif


let navBrand =
    Bulma.navbarBrand.div [
        Bulma.navbarItem.a [
            prop.href "https://safe-stack.github.io/"
            navbarItem.isActive
            prop.children [
                Html.img [
                    prop.src "/favicon.png"
                    prop.alt "Logo"
                ]
            ]
        ]
    ]

let view (model: ClientModel.Model) (dispatch: ClientModel.Msg -> unit) =
    Bulma.hero [
        hero.isFullHeight
        color.isPrimary
        prop.style [
            style.backgroundSize "cover"
            style.backgroundPosition "no-repeat center center fixed"
        ]
        prop.children [
            Bulma.heroHead [
                Bulma.navbar [
                    Bulma.container [ navBrand ]
                ]
            ]
            Bulma.container [
                Bulma.title [
                    text.hasTextCentered
                    prop.text "Algosup F# Web Demos"
                ]

                BrowserRouter [] [
                    Link [To (!^ "/")] [str "Home"]
                    Switch [] [
                        Route [Path "/search"] [ Search.view model dispatch]
                        Route [Path "/"] [Index.view model dispatch]
                        Route [Path "/items"] [str "itmes page"]
                    ]
                ]
            ]
        ]
    ]


Program.mkProgram ClientModel.init ClientModel.update view
#if DEBUG
|> Program.withConsoleTrace
#endif
|> Program.withReactSynchronous "elmish-app"
#if DEBUG
|> Program.withDebugger
#endif
|> Program.run

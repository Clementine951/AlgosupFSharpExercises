module EBuyrZ.ClientModel

open Elmish
open Fable.Remoting.Client
open EBuyrZ.Shared

type Model = { Items: Item list; Input: string }

type Msg =
    | GotItems of Item list
    | SetInput of string
    | Search

let itemsApi =
    Remoting.createApi ()
    |> Remoting.withRouteBuilder EBuyrZ.Shared.Route.builder
    |> Remoting.buildProxy<IApi>

let init () : Model * Cmd<Msg> =
    let model = { Items = []; Input = "" }

    let cmd = Cmd.none

    model, cmd

let update (msg: Msg) (model: Model) : Model * Cmd<Msg> =
    match msg with
    | GotItems items -> { model with Items = items }, Cmd.none
    | SetInput value -> { model with Input = value }, Cmd.none
    | Search ->

        let cmd =
            Cmd.OfAsync.perform itemsApi.searchItems model.Input GotItems

        { model with Input = "" }, cmd


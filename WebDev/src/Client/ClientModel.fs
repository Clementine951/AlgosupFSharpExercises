module EBuyrZ.ClientModel

open Elmish
open Fable.Remoting.Client
open EBuyrZ.Shared

type Model =
    { SearchInput: string
      SearchResultItems: Item list;
      FrontPageItems: Item list }

type Msg =
    | GotSearchResultItems of Item list
    | GotFrontPageItems of Item list
    | SetSearchInput of string
    | Search

let itemsApi =
    Remoting.createApi ()
    |> Remoting.withRouteBuilder EBuyrZ.Shared.Route.builder
    |> Remoting.buildProxy<IApi>

let init () : Model * Cmd<Msg> =
    let model =
        { SearchResultItems = [];
          SearchInput = ""
          FrontPageItems = [] }

    let cmd =
        Cmd.OfAsync.perform itemsApi.getFrontPageItems () GotFrontPageItems

    model, cmd

let update (msg: Msg) (model: Model) : Model * Cmd<Msg> =
    match msg with
    | GotSearchResultItems items -> { model with SearchResultItems = items }, Cmd.none
    | GotFrontPageItems items -> { model with FrontPageItems = items }, Cmd.none
    | SetSearchInput value -> { model with SearchInput = value }, Cmd.none
    | Search ->

        let cmd =
            Cmd.OfAsync.perform itemsApi.searchItems model.SearchInput GotSearchResultItems

        { model with SearchInput = "" }, cmd


module EBuyrZ.RemotingApi

open System
open EBuyrZ.Shared

let searchItems (text: string) =
    Items.itemList
    |> List.filter (fun x -> x.Name.Contains(text, StringComparison.CurrentCultureIgnoreCase))

let api =
    { getFrontPageItems = fun () -> async { return Items.itemList }
      searchItems =
          fun text ->
              async {
                  let results = searchItems text
                  return results
              } }


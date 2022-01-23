module EBuyrZ.RemotingApi

open System
open EBuyrZ.Shared

let api =
    { getFrontPageItems = fun () -> async { return Items.itemList }
      searchItems =
          fun text ->
              async {
                  let results = Items.itemList |> List.filter (fun x -> x.Name.Contains(text, StringComparison.CurrentCultureIgnoreCase))
                  return results
              } }


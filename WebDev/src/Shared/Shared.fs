namespace EBuyrZ.Shared

open System

type Item =
    { Id: Guid;
      Name: string;
      Description: string
      Price: Decimal;
      Images: list<string> }

module Route =
    let builder typeName methodName =
        sprintf "/api/%s/%s" typeName methodName

module Search =
    let isValid s = String.IsNullOrWhiteSpace s |> not

type IApi =
    { getFrontPageItems: unit -> Async<Item list>
      searchItems: string -> Async<Item list> }

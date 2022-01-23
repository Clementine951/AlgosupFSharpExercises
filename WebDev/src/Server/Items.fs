module EBuyrZ.Items

open System
open EBuyrZ.Shared

let itemList =
    [
        { Id = Guid.NewGuid()
          Name = "Retro Phone"
          Description = "Chic look! Practical, convenient, easy to use. Excellent sound quality."
          Price = 29M
          Images = [ "/items/RetroPhone.png" ] }
    ]


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

        { Id = Guid.NewGuid()
          Name = "Blond doll"
          Description = "Cuddly toy for babies."
          Price = 12M
          Images = [ "/items/doll.jpg" ] }

        { Id = Guid.NewGuid()
          Name = "Jar Jar doll"
          Description = "Star Wars – Edition Collector – Figurine Black Series Jar Jar Binks."
          Price = 2067M
          Images = [ "/items/jarjar.webp" ] }
        
        { Id = Guid.NewGuid()
          Name = "MY little poney doll"
          Description = "My Little Pony Friendship is Magic Princess Twilight Sparkle Cuddly Plush."
          Price = 876M
          Images = [ "/items/poney.jpg" ] }
        
    ]


﻿namespace Messages

type CreateGuitarCommand() = 
    let mutable name = ""
    member x.Name with get() = name and set v = name <- v
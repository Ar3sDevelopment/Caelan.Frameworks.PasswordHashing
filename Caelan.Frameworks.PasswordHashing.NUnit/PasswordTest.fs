﻿namespace Caelan.Frameworks.PasswordHashing.NUnit

open System
open NUnit.Framework
open Caelan.Frameworks.PasswordHashing.Classes

type CustomPasswordHasher() = 
    inherit PasswordHasher("salt", "default")

[<TestFixture>]
type PasswordTest() = 
    [<Test>]
    member __.TestHasher() = 
        let pwd = CustomPasswordHasher()
        "password"
        |> pwd.HashPassword
        |> printfn "%s"
        pwd.DefaultPasswordHashed |> printfn "%s"

module NameGenerator.Specs.NameSelector

open NUnit.Framework
open Swensen.Unquote
open System

open NameGenerator.NameSelector
open NameGenerator.NamesParser

[<Test>]
let ``grabs 1st firstname when given a seed of 0`` () =
  test <@ SelectFirstName 0. = FirstNames.[0]@>

[<Test>]
let ``grabs second name when given a seed marginally greater than first probability`` () =
  let seed = FirstNameProbability.[0] + 0.001
  test <@ SelectFirstName seed = FirstNames.[1] @>
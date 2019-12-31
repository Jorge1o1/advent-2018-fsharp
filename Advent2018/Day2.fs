module Day2

open Shared

let input2Path = "C:\\Users\\Jorge L Martinez Jr\\Source\\Repos\\advent-2018-fsharp\\Advent2018\\Input2.txt"
let ids = readLines input2Path |> List.map Seq.toList // Read in the lines, split into char list list
let countedByLetter = List.map (List.countBy id) ids 

let kvListContainsValue x m = m |> Seq.exists (fun (_, v) -> v = x)
let letterTwiceCount = countedByLetter |> List.filter (kvListContainsValue 2) |> List.length
let letterThriceCount = countedByLetter |> List.filter (kvListContainsValue 3) |> List.length
let solution = letterTwiceCount * letterThriceCount
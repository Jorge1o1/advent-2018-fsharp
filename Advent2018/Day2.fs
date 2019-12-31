module Day2

open Shared

let countLettersInString = Seq.toList >> (List.countBy id)
let countedByLetter = readLines "Input2.txt" |> List.map countLettersInString

let kvListContainsValue x = Seq.exists (fun (_, v) -> v = x)
let numWordsWithXLetters x = List.filter (kvListContainsValue x) >> List.length

let letterTwiceCount = countedByLetter |> numWordsWithXLetters 2
let letterThriceCount = countedByLetter |> numWordsWithXLetters 3
let solution = letterTwiceCount * letterThriceCount
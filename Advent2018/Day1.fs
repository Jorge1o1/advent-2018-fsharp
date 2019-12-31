module Day1

open Shared

let nums =
    readLines "Input1.txt"
    |> List.map LanguagePrimitives.ParseInt32

let rec firstDuplicate freqSet currSum lst =
    match lst with
        | hd::tl ->
            let newSum = currSum + hd
            if Set.contains newSum freqSet
            then Some newSum
            else firstDuplicate (freqSet.Add newSum) newSum tl
        | [] -> firstDuplicate freqSet currSum nums

let solution = List.sum nums
let solution2 = firstDuplicate (Set.empty.Add 0) 0 nums
module Day1

open Shared

let input1Path = "C:\Users\jl_ma\Documents\Visual Studio 2017\Projects\Advent2018\Advent2018\Input1.txt"
let nums =
    readLines input1Path
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
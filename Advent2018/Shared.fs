module Shared

let readLines filePath = System.IO.File.ReadLines(filePath) |> List.ofSeq
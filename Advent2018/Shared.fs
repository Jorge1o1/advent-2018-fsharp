module Shared

let readLines filePath = List.ofSeq (System.IO.File.ReadLines(filePath))
//let isVowel (v: char) = 
//    match v with
//    | 'a' | 'e' | 'i' | 'o' | 'u' | 'A' | 'E' | 'I' | 'O' | 'U' -> true
//    | _ -> false

//let rec countNumOfVowels s =
//    match s with 
//    | "" -> ""
//    | _ -> if isVowel s.[0] then s.[0].ToString() + countNumOfVowels (s.[1..])
//            else countNumOfVowels (s.[1..])

//countNumOfVowels "Higher-order functions can take and return functions of any order";;


let countNumOfVowels (str:string) =

    let isVowel (accA, accE, accI, accO, accU) = 
        function
        | 'a' | 'A' -> (accA + 1, accE, accI, accO, accU)
        | 'e' | 'E' -> (accA, accE + 1, accI, accO, accU)
        | 'i' | 'I' -> (accA, accE, accI + 1, accO, accU)
        | 'o' | 'O' -> (accA, accE, accI, accO + 1, accU)
        | 'u' | 'U' -> (accA, accE, accI, accO, accU + 1)
        | _ -> (accA, accE, accI, accO, accU)

    List.fold isVowel (0, 0, 0, 0, 0) <| List.ofSeq str

countNumOfVowels "Higher-order functions can take and return functions of any order";;

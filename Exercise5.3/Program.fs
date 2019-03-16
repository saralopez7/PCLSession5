let rec pclFib n = 
    match n with 
    | 0 -> 0
    | 1 -> 1
    |_ -> (pclFib <| n - 1) + (pclFib <| n - 2)

pclFib 8;;
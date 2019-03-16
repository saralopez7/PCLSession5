let primesUpTo n = 
    [
    for n in 1 .. n do
        let factorsOfN = [for i in 1 .. n do if n % i = 0 then yield i]
        if List.length factorsOfN = 2 then yield n
    ];; 
    
primesUpTo 10;;
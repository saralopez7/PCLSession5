let doubleNum x = x * 2
let sqrNum x  = x * x

let pclQuadFourth func x =
  let rec inner innerX n =
    if n = 1 then
        func innerX
    else
        inner <| func innerX <| n - 1
  inner x 2

pclQuadFourth doubleNum 2;;
pclQuadFourth sqrNum 2;;


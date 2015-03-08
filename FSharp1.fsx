Seq.unfold (fun (l,r) -> if (l < 1) then None else Some((l,r), (l/2,r*2))) (18,23)
|> Seq.filter (fun x -> (fst x) % 2 = 1)
|> Seq.map (fun (l,r) -> r)
|> Seq.sum 

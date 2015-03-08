Seq.unfold (fun (l,r) -> if (l < 1) then None else Some((l,r), (l/2,r*2))) (18,23)
|> Seq.fold(fun total (l,r) -> if (l % 2 = 1) then total + r else total) 0
;;

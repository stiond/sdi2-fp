let rec sortare list =
   match list with
   | [] ->                            // daca lista este goala
        []                            // returneaza lista goala
   | primul_nr::rest_nr ->      // daca lista nu e goala
        let nr_mic =         // extrage cel mai mic numar 
            rest_nr             
            |> List.filter (fun x -> x < primul_nr) 
            |> sortare              // sorteaza numerele
        let nr_mare =          // extrage cel mai mare numar
            rest_nr 
            |> List.filter (fun x -> x >= primul_nr)
            |> sortare              // sorteaza numerele
        List.concat [nr_mic; [primul_nr]; nr_mare] // uneste cele trei parti intr-o singura lista 
printfn "%A" (sortare [1;10;2;108;19;13;31;423;234;2345;2;0;83;32]) // afiseaza numerele din lista data sortate crescator
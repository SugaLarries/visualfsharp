// #Regression #NoMono #CodeGen #Optimizations #ReqNOMT   
// Regression test for FSHARP1.0:3990
module EqualsMicroPerfAndCodeGenerationTests = 
    let f4() = 
       let mutable x = false
       let t1 = (1,2)
       let t2 = (1,3)
       
       for i = 0 to 10000000 do
           x <- (t1 = t2)
       x


(*lambda expressions*)
//맥북에서 alt+enter==option+enter

//val it: unit -> unit
fun () -> printfn "Hello World"
fun x -> x+1
fun x y -> x+y


(*Defining Named Functions*)
//val addOne: x: int -> int
let addOne x = x+1

(*함수 호출*)
//val it: int = 4
addOne 3

(*Type inference && Type Annotations*)

//val BuildUrlAnnotations: protocol: 'a -> baseUrl: 'b -> path: 'c -> string
//input이 무슨 타입인지 모름
//나쁜 예
let BuildUrlAnnotations protocol baseUrl path = $"{protocol}: // {baseUrl}/{path}"
BuildUrlAnnotations 1 "github.com" (1.0, 4.0)

//좋은 예
let buildURL (protocol: string) (baseURL: string) (path: string): string = 
    $"{protocol}://{baseURL}/{path}"
buildURL "http" "github.com" "dotnet/fsharp"


(*Option Type*)
#r "nuget:FSharp.Data"
open FSharp.Data
open System.IO

let getHtml (htmlFile: string) : HtmlDocument option =
    try
        let html = HtmlDocument.Load(htmlFile)
        //성공하면
        Some(html)
        //otherwise,,
    with
    | ex-> 
        printfn $"Error: {ex}"
        None

HtmlDocument.Load "doesnotexist"
getHtml "doesnotexist"

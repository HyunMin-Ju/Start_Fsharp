//출처: http://fsharpforfunandprofit.com/posts/fsharp-in-60-seconds/ 

//코드 블럭에서 파이썬같이 들여쓰기 사용함. 대괄호 아님.
//인수 구분할 때 공백 사용.

(*변수 설정-불변*)
let myInt = 5
let myFloat = 3.14
let myString = "Hello"

(*리스트*)
let twoToFive = [2;3;4;5]

//The result is [1;2;3;4;5]
let oneToFive = 1::twoToFive

//concat
let zeroToFive = [0;1] @ twoToFive


(*functions*)
let square x = x * x
square 4

let add x y <- x+y
add 1 2

//여러 줄로 함수 정의하려면 들여쓰기(indents) 사용.
let evens list = 
    let isEven x = x%2=0
    List.filter isEven list  //List.filter: 라이브러리 함수, 두개의 인자를 취함.
evens oneToFive //함수 execution

(*괄호*)
//함수 실행 순서 명시
let sumOfSquaresTo100 =
    List.sum( List.map square [1..100] )

(*순방향 파이프*)
//출력된 결과를 다음 함수로 전달
let sumOfSquaresTo100piped =
    [1..100] |> List.map square |> List.sum

(*람다-익명함수*)
//fun 키워드를 통해 정의.
let sumOfSquaresTo100withFun =
    [1..100] |> List.map(fun x->x*x) |> List.sum

(*match...with*)
//return 필요없음, 마지막 값을 리턴한다.
let simplePatternMatch = 
    let x = "a"
    match x with
    | "a" -> printfn "x is a"
    | "b" -> printfn "x is b"
    | _ -> printfn "x is something else" 

(*Some과 None: null이 가능한 값의 wrapper*)
let validValue = Some(99)
let invalidValue = None

//some과 none을 사용하는 match..with의 예시
//Some 값을 바로 꺼내서 사용한다.
let optionPatternMatch input =
    match input with
    | Some i -> printfn "input is an int=%d" i
    | None -> printfn "input is missing"
optionPatternMatch validValue
optionPatternMatch invalidValue

(*Tuple*)
let twoTuple = 1,2
let threeTuple = "a",2,true

(*Record*)
type Person = {First:string; Last:string}
let person1 = {First="john"; Last="Doe"}

(*Union*)
type Temp =
  | DegreesC of float
  | DegreesF of float
let temp = DegreesF 98.6

(*combined recursively*)
type Employee =
  | Worker of Person
  | Manager of Employee list
let jdoe = {First="John";Last="Doe"}
let worker = Worker jdoe


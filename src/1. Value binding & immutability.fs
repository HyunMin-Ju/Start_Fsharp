//String
let CityName = "Seoul"

//Boolean
let fShapeIsAwesome = true

//int
let luckyNumber = 7

//float, float-creating tuples
let coordinates = (1.0, 3.0)

//list <string>
let toDoList = ["Learn F#"; "Build App";"Profit!"]

//int->int (create a named func)
let divideByThree input = input/3

//정의하면 meaning과 context를 변수에 부여함.
//변수의 타입을 정의해주지 않아도 터미널에 입력하면 type inference

(*explicitly type annotation굳이*)
let (luckyNumberString:string) = "7"

(*Updating Data or values*)
// CityName<-"New York" 이렇게 하면 에러 발생
//values cannot be changed throughout the course of a program's execution
//그래서 원래 있던 변수 이름을 새롭게 let하면서 덮는 수밖에.

//immutability enables compilers to check code more stringently, which
//help provide features like type inference.
//it makes ur code predictable(original data change 걱정 ㄴㄴ)

//logic that applies transformations to ur data locally

//만약에 반드시 data를 바꿔야한다면...
let mutable mutableCityName = "New York"
mutableCityName<-"Seoul"
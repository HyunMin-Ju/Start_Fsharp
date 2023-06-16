(*Grouping data in F#*)
(*Tuples*)

let point1 = (1.0, 2.0)
let gitHubStarts = ("dotnet/fsharp", 2800)

(*GET DATA*)
fst gitHubStars //첫 item
snd gitHubStars //두번째 item

let projectName, stars = gitHubStars
printfn $"{projextName}: {stars}"

let projectName, _ = gitHubStars

(*Records*)
(*Record 정의*)
type GitHubProject = {ProjectName: string; Stars: int}

(*Create Record*)
let fsharp = 
    {ProjectName = "dotnet/fsharp"
     Stars = 2800}

(*Access record data*)
printfn$"{fsharp.ProjectName} has {fsharp.Stars} stars"

(*Update record data*)
let updatedFSharp = {fsharp with Stars = 2801}
printfn $"{updatedFSharp.ProjectName} now has {updatedFSharp.Stars} stars"

(*Record Members*)
type GitHubProjectWithMember = 
    {ProjectName: string
    Stars: int}

    member this.GetUrl() =
        $"https://github.com/{this.ProjectName}"
    member _.GetCodeOwner () = "dotnet"

let fsharpProj = 
    {ProjectName = "dotnet/fsharp"
    Stars = 2800}

fsharpProj.GetUrl()
fsharpProj.GetCodeOwner()

(*Discriminated Unions*)
type StringGitHubProject = 
    {   ProjectName: string
        Stars: int
        State: string}

let fakeProject =
    {ProjectName = "Amazing Project"
    Stars = 0
    State = "asdferq"
    }

(*Defining Discriminated Union*)
type ProjectState = 
    | Archived
    | Active of {|Maintainer: string|}

type GitHubProject = 
    {ProjectName: string
    Stars: int
    State: ProjectState }

(*Use Discriminated Union*)
let corefxlab = 
    {ProjectName = "corefxlab"
    Stars = 1500
    State = Archived }

let fsharp = 
    {ProjectName = "dotnet/fsharp"
    Stars = 2800
    State = Active {|Maintainter = "F# Team"|}}

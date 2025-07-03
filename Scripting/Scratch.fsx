// NOTE: Full Paket integration with GitHub sourcing does not work yet
// The Paket dependency manager is not properly registered in FSI despite --compilertool:paket
// Current implementation only supports basic NuGet package fallback for "paket: nuget PackageName" syntax

// #r "paket: github fsharp/FAKE src/legacy/FakeLib/Globbing/Globbing.fs"
// #load @"fsharp\FAKE\src\legacy\FakeLib\Globbing\Globbing.fs"

// let f = Fake.Globbing.search

// Alternative: Use modern FAKE NuGet packages instead
// #r "nuget: Fake.IO.FileSystem"
// open Fake.IO.Globbing.Operators
// let files = !! "**/*.fs" |> Seq.take 5 |> List.ofSeq

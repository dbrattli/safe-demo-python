module Server.Middleware

open Fable.Core

[<Import("StaticFiles", "starlette.staticfiles")>]
let staticFiles : obj = nativeOnly
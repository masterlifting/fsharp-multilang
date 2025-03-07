[<RequireQualifiedAccess>]
module Multilang.Translator

open Infrastructure.Domain
open Multilang.Domain

let translate (request: Request) : Async<Result<Response, Error'>> =
    match request.Culture with
    | English -> "Multilang.Translator.translate" |> NotSupported |> Error |> async.Return
    | Russian -> "Multilang.Translator.translate" |> NotSupported |> Error |> async.Return


type Type = OpenAI of Multilang.OpenAI.Domain.Client

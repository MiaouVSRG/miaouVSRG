﻿namespace Interlude

open System
open System.Reflection
open System.IO

open Percyqaz.Common

module Utils =

    let get_resource_stream (name: string) : Stream =
        Assembly
            .GetExecutingAssembly()
            .GetManifestResourceStream("MiaouVSRG.Resources." + name)

    let get_locale (id: string) : Stream =
        get_resource_stream ("Locale." + id + ".txt")

    let get_resource_text (name: string) : string =
        use s = get_resource_stream name
        use tr = new StreamReader(s)
        tr.ReadToEnd()

    let splash_message_picker (name: string) : unit -> string =
        let r = new Random()
        let text = get_resource_text name
        let lines = text.Split("\n")
        
        fun () -> lines.[r.Next lines.Length]
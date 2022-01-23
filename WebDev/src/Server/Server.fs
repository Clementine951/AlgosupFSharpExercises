module EBuyrZ.Server

open System.IO
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.DependencyInjection
open Giraffe

open Fable.Remoting.Server
open Fable.Remoting.Giraffe

open EBuyrZ
open EBuyrZ.Shared

let webApiApp =
    Remoting.createApi ()
    |> Remoting.withRouteBuilder Route.builder
    |> Remoting.fromValue RemotingApi.api
    |> Remoting.buildHttpHandler

let webHtmlApp =
    choose [
        GET >=>
            choose [
                route "/views/html-demo" >=> htmlView (HtmlViews.index ())
                route "/views/json-demo" >=> json (Items.itemList)
            ]
        webApiApp ]

let configureApp (app : IApplicationBuilder) =
    let env = app.ApplicationServices.GetService<IWebHostEnvironment>()
    (match env.IsDevelopment() with
    | true  ->
        app.UseDeveloperExceptionPage()
    | false -> app)
        .UseStaticFiles()
        .UseGiraffe(webHtmlApp)

let configureServices (services : IServiceCollection) =
    services.AddGiraffe() |> ignore

[<EntryPoint>]
let main args =
    let contentRoot = Directory.GetCurrentDirectory()
    let webRoot     = Path.Combine(contentRoot, "WebRoot")
    Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(
            fun webHostBuilder ->
                webHostBuilder
                    .UseUrls("http://localhost:8085")
                    .UseContentRoot(contentRoot)
                    .UseWebRoot(webRoot)
                    .Configure(configureApp)
                    .ConfigureServices(configureServices)
                    |> ignore)
        .Build()
        .Run()
    0

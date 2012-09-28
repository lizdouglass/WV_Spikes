using System;
using System.Collections.Generic;
using System.Linq;
using Nancy;
using Nancy.ModelBinding;
using Nancy.Responses;
using NancyWeb.Model;

namespace NancyWeb
{
    /// <summary>
    /// Needs to be a web application
    /// </summary>
    public class JokeWebService : NancyModule
    {
        private static IList<Joke> jokes = new List<Joke>();

        static JokeWebService()  {
            jokes.Add(new Joke { Id = 1, OneLiner = "Joke 1" }); 
            jokes.Add(new Joke { Id = 2, OneLiner = "Joke 2" }); 
            jokes.Add(new Joke { Id = 3, OneLiner = "Joke 3" }); 

        }

    public JokeWebService()
        {
            Get["/"] = parameters => "This is the Jokes Service, using a HTTP handler";

            //Get["/jokes"] = parameter => new JsonResponse(jokes, new DefaultJsonSerializer());
            Get["/jokes"] = parameter => Response.AsJson(jokes);

            Get["/jokes/{id}"] = parameter =>  Response.AsJson(jokes.ToList().Find(x => x.Id == parameter.id));

            Post["jokes"] = parameter =>
                                {
                                    System.Diagnostics.Debug.WriteLine("Receiving a joke");
                                    var joke = this.Bind<Joke>();
                                    System.Diagnostics.Debug.WriteLine("joke is " + joke.OneLiner);
                                    jokes.Add(joke);
                                    var url = String.Format("{0}/{1}", this.Context.Request.Url, jokes.Count());
                                    return new Response
                                               {
                                                   StatusCode = HttpStatusCode.Accepted
                                               }.WithHeader("Location", url);
                                };


            //update (normally)
            //Put["jokes/1"]
        }

        
    }
}

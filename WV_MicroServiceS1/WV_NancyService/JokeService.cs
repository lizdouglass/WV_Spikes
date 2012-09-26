using System;
using System.Collections.Generic;
using System.Linq;
using Nancy;

namespace WVNancyService
{
    public class JokeService : NancyModule
    {
        public JokeService()
        {
            Get["/"] = parameters => "This is the Jokes Service";

            
        }
    }
}

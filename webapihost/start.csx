#load "webapiconfig.csx"
#load "testcontroller.csx"

using System.Reflection;
using System.Web.Http;
using System.Web.Http.SelfHost;
using System.Web.Http.Dispatcher;

new HttpSelfHostServer(config).OpenAsync().Wait();
Console.WriteLine("Listening...");
Console.ReadKey();

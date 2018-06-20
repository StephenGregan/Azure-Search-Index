using Microsoft.Azure.Search;
using Microsoft.Azure.Search.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace AzureSearchIndex
{
    class Program
    {
        static string searchServiceName = ConfigurationManager.AppSettings["StephenSearchName"];
        static string searchServiceAdminKey = ConfigurationManager.AppSettings["StephenSearchServiceAdminKey"];
        //static string searchServiceQueryKey = ConfigurationManager.AppSettings["StephenSearchServiceQueryKey"];

        static void Main(string[] args)
        {
            SearchServiceClient serviceClient = new SearchServiceClient
                (searchServiceName, new SearchCredentials(searchServiceAdminKey));

            if (serviceClient.Indexes.Exists("accounts"))
            {
                serviceClient.Indexes.Delete("accounts");
            }

            var accountIndexDefinition = new Index()
            {
                Name = "accounts",
                Fields = FieldBuilder.BuildForType<Account>()
            };

            serviceClient.Indexes.Create(accountIndexDefinition);

            ISearchIndexClient indexClient = serviceClient.Indexes.GetClient("accounts");

            ImportDocuments(indexClient);
        }

        private static void ImportDocuments(ISearchIndexClient indexClient)
        {
            var actions = new List<IndexAction<Account>>();

            string line;

            //JObject o1 = JObject.Parse(File.ReadAllText("accounts.json"));

            //// read JSON directly from a file
            //using (StreamReader file = File.OpenText("accounts.json"))
            //using (JsonTextReader reader = new JsonTextReader(file))
            //{
            //    JObject o2 = (JObject)JToken.ReadFrom(reader);
            //    Account account = o2.ToObject<Account>();
            //    actions.Add(IndexAction.Upload(account));
            //}

            using (System.IO.StreamReader file = new System.IO.StreamReader("accounts.json"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    JObject json = JObject.Parse(line);
                    Account account = json.ToObject<Account>();
                    actions.Add(IndexAction.Upload(account));
                }
                file.Close();
            }

            var batch = IndexBatch.New(actions);
            Console.WriteLine("Indexed......");
            try
            {
                indexClient.Documents.Index(batch);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

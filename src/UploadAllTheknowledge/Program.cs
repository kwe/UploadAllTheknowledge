using System;
using Nest;

namespace UploadAllTheknowledge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello kwe");

            var local = new Uri("http://docker:9200");
            var setting = new ConnectionSettings(local).DefaultIndex("default-index");
            var client = new ElasticClient(setting);

            var res = client.ClusterHealth();

            Console.WriteLine(res.Status);

            var item = new Item
            {
                Id = "1",
                Title = "Sample Document",
                Summary = "A lovely test document to add to the Elasticsearch collection"
            };

            var index = client.Index(item);


            // http://docker:9200/default-index/_search to view what's happened.

        }
    }
}
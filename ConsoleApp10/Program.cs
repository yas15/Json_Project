using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            // read the json file as a string
            string inputJson = File.ReadAllText(@"C:\Users\Windows 10 Pro\Desktop\Helix\input_BNF_ertapenem.json");

            //Console.WriteLine(inputJson);


            // JsonConvert.DeserializeObject<T>(String)
            // Deserializes a JSON string into a .NET object of type <T>, You will need to define the class <T>.
            // We are getting the following error: Cannot deserialize the current JSON array(e.g. [1, 2, 3])
            // This is because 'inputJson' is an array of JSON objects e.g. [{JSON_object_1},{JSON_object_2},{JSON_object_3},...]
            var input_json = JsonConvert.DeserializeObject<Input>(inputJson);


            Console.WriteLine(input_json.drugs[0].name);
            Console.WriteLine(input_json.drugs[0].indicationsDose.potName);
            Console.WriteLine(input_json.drugs[0].indicationsDose.indicationAndDoseGroups[0].therapeuticIndications[0].indication);


            OutputDrug outputDrug = new OutputDrug();

            outputDrug.name = "test";
            outputDrug.suggestedDose = null;


            Output output = new Output();



            output.drugs[0] = outputDrug;



//            output.drugs[0].name = input_json.drugs[0].name;

            Console.WriteLine(output.drugs[0].name);

            output.drugs[0].suggestedDose[0].indications[0] = input_json.drugs[0].indicationsDose.indicationAndDoseGroups[0].therapeuticIndications[0].indication;
            output.drugs[0].suggestedDose[0].indications[1] = input_json.drugs[0].indicationsDose.indicationAndDoseGroups[0].therapeuticIndications[1].indication;
            output.drugs[0].suggestedDose[0].indications[2] = input_json.drugs[0].indicationsDose.indicationAndDoseGroups[0].therapeuticIndications[2].indication;

            //as

            Console.WriteLine("About to serialize");


            //suggestedDose = input_json.drugs[0].name;


            //Name = "Apple";
            //product.Expiry = new DateTime(2008, 12, 28);
            //product.Price = 3.99M;
            //product.Sizes = new string[] { "Small", "Medium", "Large" };

            string json = JsonConvert.SerializeObject(output);


            Console.WriteLine("Stopped");

            Console.ReadKey();


        }
    }
}

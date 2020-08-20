using System;
using MachineLearningAppML.Model;
namespace MachineLearningApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new ModelInput();
            input.SentimentText = "That is rude.";
            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine($"Text:{input.SentimentText}\nIs Toxic:{result.Prediction}");
            var inp = new ModelInput();
            inp.SentimentText = "this is kind.";
            ModelOutput res = ConsumeModel.Predict(inp);
            Console.WriteLine($"text:{inp.SentimentText}\nIs Toxic:{res.Prediction}");
        }
    }
}

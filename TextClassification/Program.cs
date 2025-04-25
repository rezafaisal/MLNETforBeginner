// See https://aka.ms/new-console-template for more information
using TextClassification;

Console.WriteLine("Klasifikasi Teks");

//Load sample data
var sampleData = new AnalisisSentimen.ModelInput()
{
    Text = @"Film king Arthur ini film paling jelek dari seluruh cerita King Arthur",
};

//Load model and predict output
var result = AnalisisSentimen.Predict(sampleData);


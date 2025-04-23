using HelloMLNET;

Console.WriteLine("Hello ML.NET!");

//Load sample data
var sampleData = new IrisModel.ModelInput()
{
    Sepal_length = 48F,
    Sepal_width = 34F,
    Petal_length = 16F,
    Petal_width = 2F,
};

//Load model and predict output
var result = IrisModel.Predict(sampleData);
if (result.PredictedLabel.Equals(0))
{
    Console.WriteLine("Prediksi: Iris Setosa");
}
else if (result.PredictedLabel.Equals(1))
{
    Console.WriteLine("Prediksi: Iris Versicolor");
}
else if (result.PredictedLabel.Equals(2))
{
    Console.WriteLine("Prediksi: Iris Virginica");
}
else
{
    Console.WriteLine("Prediksi: Tidak diketahui");
}

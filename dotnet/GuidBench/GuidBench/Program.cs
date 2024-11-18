var size = 1_000_000_000;
// var watch1 = System.Diagnostics.Stopwatch.StartNew();
// Parallel.For(0, size, i =>
// {
//     var guid = Guid.NewGuid();
// });
// watch1.Stop();
// Console.WriteLine($"Parallel.For Guids: {watch1.Elapsed}");

// var watch2 = System.Diagnostics.Stopwatch.StartNew();
// for (int i = 0; i < size; i++)
// {
//     var guid = Guid.NewGuid();
// }
// watch2.Stop();
// Console.WriteLine($"For Guids: {watch2.Elapsed}");

var watch3 = System.Diagnostics.Stopwatch.StartNew();
Parallel.For(0, size, i =>
{
    var number = i + 0.5;
    Math.Abs(number);
    Math.Acos(number);
    Math.Acosh(number);
    Math.Asin(number);
    Math.Asinh(number);
    Math.Atan(number);
    Math.Atanh(number);
    Math.BitDecrement(number);
    Math.BitIncrement(number);
    Math.Cbrt(number);
    Math.Ceiling(number);
    Math.Cos(number);
    Math.Cosh(number);
    Math.Exp(number);
    Math.Floor(number);
    Math.ILogB(number);
    Math.Log(number);
    Math.Log10(number);
    Math.Log2(number);
    Math.ReciprocalEstimate(number);
    Math.ReciprocalSqrtEstimate(number);
    Math.Round(number);
    Math.Sign(number);
    Math.Sin(number);
    Math.SinCos(number);
    Math.Sinh(number);
    Math.Sqrt(number);
    Math.Tan(number);
    Math.Tanh(number);
    Math.Truncate(number);

    // var x = Math.Sqrt(i);
    // var y = Math.Pow(i, 2);
    // var z = Math.Log(i);
});
watch3.Stop();
Console.WriteLine($"Parallel.For Math: {watch3.Elapsed}");

var watch4 = System.Diagnostics.Stopwatch.StartNew();
for (int i = 0; i < size; i++)
{
    var number = i + 0.5;
    Math.Abs(number);
    Math.Acos(number);
    Math.Acosh(number);
    Math.Asin(number);
    Math.Asinh(number);
    Math.Atan(number);
    Math.Atanh(number);
    Math.BitDecrement(number);
    Math.BitIncrement(number);
    Math.Cbrt(number);
    Math.Ceiling(number);
    Math.Cos(number);
    Math.Cosh(number);
    Math.Exp(number);
    Math.Floor(number);
    Math.ILogB(number);
    Math.Log(number);
    Math.Log10(number);
    Math.Log2(number);
    Math.ReciprocalEstimate(number);
    Math.ReciprocalSqrtEstimate(number);
    Math.Round(number);
    Math.Sign(number);
    Math.Sin(number);
    Math.SinCos(number);
    Math.Sinh(number);
    Math.Sqrt(number);
    Math.Tan(number);
    Math.Tanh(number);
    Math.Truncate(number);

    // var x = Math.Sqrt(i);
    // var y = Math.Pow(i, 2);
    // var z = Math.Log(i);
}
watch4.Stop();
Console.WriteLine($"For Math: {watch4.Elapsed}");
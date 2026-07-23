string name = "Eric";
string fromCity = "Chennai";
string toCity = "Banglore";
string viaCity = "Vellore";

double distanceFromCtoV = 156.6;
double timeFromCtoV = 4 * 60 + 4;
double distanceFromVtoB = 211.8;
double timeFromVtoB = 4 * 60 + 25;


Console.WriteLine($"Displaying\nTotal Distance:\t{distanceFromCtoV + distanceFromVtoB}\nTotal Time:\t{timeFromCtoV + timeFromVtoB}");

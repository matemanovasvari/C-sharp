using IOLibrary;
using PaymentCalculator;

string workerName = ExtendedConsole.ReadString("Please type in your name!: ");
double workHours = ExtendedConsole.ReadDouble("How many hours did you work this week?: ");

double overtimePayment = Payment.PaymentCalculator(1500, workHours-40);
double normalPayment = Payment.PaymentCalculator(1000);

double payment = overtimePayment + normalPayment;

Console.WriteLine($"{workerName} your payment is: {payment}Ft");
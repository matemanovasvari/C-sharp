using IOLibrary;
using PaymentCalculator;

const int BASE_WORKING_HOURS = 40;

string workerName = ExtendedConsole.ReadString("Please type in your name!: ");
double workHours = ExtendedConsole.ReadDouble("How many hours did you work this week?: ");

double overtimePayment = workHours > BASE_WORKING_HOURS ?
                         Payment.PaymentCalculator(workHours - BASE_WORKING_HOURS, 1500) :
                         0;

double normalPayment = Payment.PaymentCalculator(BASE_WORKING_HOURS);

double payment = overtimePayment + normalPayment;

Console.WriteLine($"{workerName} your payment is: {payment}Ft");
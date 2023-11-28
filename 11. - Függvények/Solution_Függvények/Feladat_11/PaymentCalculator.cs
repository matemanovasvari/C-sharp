namespace PaymentCalculator;

public static class Payment
{
    public static double PaymentCalculator(double hoursInWeek, int wage = 1000)
    {
        return hoursInWeek * wage;
    }
}
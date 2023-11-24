namespace PaymentCalculator;

public static class Payment
{
    public static double PaymentCalculator(int wage, double hoursInWeek = 40)
    {
        return hoursInWeek * wage;
    }
}
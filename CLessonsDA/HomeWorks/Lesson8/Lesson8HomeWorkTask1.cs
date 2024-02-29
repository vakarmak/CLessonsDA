namespace CLessonsDA.HomeWorks.Lesson8;

public class Lesson8HomeWorkTask1
{
    // Представьте, что вы реализуете программу для банка, которая помогает определить, погасил ли клиент
    // кредит или нет. Допустим, ежемесячная сумма платежа должна составлять 100 грн. Клиент должен
    // выполнить 7 платежей, но может платить реже большими суммами. Т.е., может двумя платежами по
    // 300 и 400 грн. Закрыть весь долг.
    // Создайте метод, который будет в качестве аргумента принимать сумму платежа, введенную
    // экономистом банка. Метод выводит на экран информацию о состоянии кредита (сумма задолженности,
    // сумма переплаты, сообщение об отсутствии долга).

    public static void CreditCheck()
    {
        int creditSize = 700;
        CalculateCredit(creditSize);
    }

    static void CalculateCredit(int creditCalculation)
        // При первом запуске метода CalculateCredit(), creditCalculation = creditSize
        // результат вычитания сохраняется в переменную newCreditCalculation
        // таким образом если есть остаток по задолженности то мы проваливаемся в блок else
        // где метод вызывает сам себя, но принимает не creditSize, а уже newCreditCalculation
        // и метод отрабатывает с уже измененным кредитным долгом.
        
        // Принцип рекурсии - метод вызывает сам себя не из начального состояния, а из текущего, т.е.
        // были произведены расчеты, в конце выполнения метода мы передали значение с учетом результата вычисления
        // и из этого состояния метод вызвал сам себя еще раз.
    {
        Console.WriteLine("Введите сумму платежа!");
        int creditPayment = int.Parse(Console.ReadLine());
        int newCreditCalculation = creditCalculation - creditPayment;

        if (newCreditCalculation <= 0) // Долг погашен или переплата
        {
            if (newCreditCalculation == 0)
            {
                Console.WriteLine("Ваш долг погашен!");
            }
            else
            {
                Console.WriteLine("Ваш долг погашен!");
                Console.WriteLine($"Переплата составляет {Math.Abs(newCreditCalculation)}.");
            }
        }
        else // Есть остаток долга
        {
            Console.WriteLine($"Сумма задолженности: {newCreditCalculation}");
            CalculateCredit(newCreditCalculation);
        }
    }
}

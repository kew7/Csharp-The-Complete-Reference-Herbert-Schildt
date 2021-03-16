public interface ISeries
{
    int getNext(); // Возвращает следующее число ряда.
    void reset(); // Выполняет перезапуск.
    void setStart(int x); // Устанавливает начальное
                          // значение.
}
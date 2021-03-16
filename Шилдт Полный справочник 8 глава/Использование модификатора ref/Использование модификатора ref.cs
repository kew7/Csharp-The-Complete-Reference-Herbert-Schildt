// Использование модификатора ref для передачи
// значения нессылочного типа по ссылке.
using System;
class RefTest {
/* Этот метод изменяет свои аргументы.
Обратите внимание на использование модификатора ref. */
    public void sqr(ref int i) {
     i = i * i;
    }
}

class RefDemo {
    public static void Main() {
    RefTest ob = new RefTest();
    int a = 10;
    Console.WriteLine("а перед вызовом: " + a);
    ob.sqr(ref a);  // Обратите внимание
                    //на использование модификатора ref.
    Console.WriteLine("а после вызова: " + a);
    }
}


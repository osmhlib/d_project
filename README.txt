Програма для ведення обліку заявок на ремонт та обслуговування комп'ютерної техніки. Поставляється з попередньо створеною демонстраційною базою даних на 15 записів. Базу даних можна очистити через меню Файл-Очистити (при цьому нові записи будуть далі записуватися зі зростанням порядкових номерів). Поточні та виконані зявлення очищаються окремо. Щоб почати нові записи з початку необхідно видалити файл \d_project\bin\Release\Orders.db та перезапустити програму. 
Додавання запису відбувається на першій сторінці з обов’язковим заповненням всіх полів. На другій сторінці реалізовано перегляд даних з файлу та пошук по збігу. Можливе сортування записів за алфавітом (для полів Модель, ПІБ та Послуга) та спаданням або зростанням (для полів № та Вартість). Для цього необхідно клацнути по заголовку відповідного стовпчика.
На третій сторінці відбувається редагування бази даних безпосередньо в таблиці зі збереженням змін, є можливість видалити заявку та позначити її як виконану. Відмітка про виконання відбувається як перенесення з поточних заявок до виконаних. Перемикання між поточними і виконаними заявками відбувається через меню Перегляд. Також є можливість скасувати останню дію користувача (лише одну).
У меню Файл також є можливість окремо експортувати поточні та виконані заявки у файли формату .xlsx (\d_project\bin\Release\Export\), створити резервну копію (\d_project\bin\Release\) та відкрити файл бази даних (підтримуються лише файли створені у цій програмі).


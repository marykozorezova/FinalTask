# **Итоговая проверочная работa**

 Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равнa 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

 ## Решение

1. Пользователь вводит массив строк с клавиатуры
2. Считываем данные, введенные пользователем
3. Преобразуем введенную строку в массив подстрок
4. Вызываем метод Solution
5. Создаем пустой массив, в который будут добавляться строки, удовлетворяющие условию задачи
6. Пробегаем по всем элементам массива
7. Если подстрока пустая или нулевая, то пропускаем этот элемент
8. Если длина подстроки <= 3, добавляем данную подстроку в новый массив, вызвав метод AddToArray
9. Возвращаем полученный массив
10. Выводим пользователю, полученный массив

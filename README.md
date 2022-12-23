# Контрольная работа #
## Задача ##
    Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. Первоначальный массив можно внести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### Содержание ###
* [Составление алгоритма](#составление-алгоритма)
* [Составление блок схемы](#составление-блок-схемы)
* [Описание методов](#описание-методов)

_______


### Составление алгоритма ###
1. Определение размера массива строк
2. Создание нового массива
3. Определение строк у которых количество символов <=3
4. Наполнение нового массива
5. Вывод нового массива

_______


### Составление блок схемы ###
![Блок схема](Block.png)

_______

### Описание методов ###

1. Метод создания массива по данным пользователя 

        string[] FillArray(int size)
        {
            string[] array = new string[size];
            for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"Введите значения {i} индекса массива -> ");
                    array[i] = Console.ReadLine();
                }
            return array;
        }

2. Метод вывода массива 

        void PrintArray(string[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1) Console.Write($"‟{array[i]}‟,");
                else Console.Write($"‟{array[i]}‟");
            }
            Console.Write("]");
        }

3. Метод фильтрации и создания нового массива

        string[] FilterArray(string[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3) count++;
            }

            string[] newArray = new string[count];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    newArray[k] = array[i];
                    k++;
                }
        }
            return newArray;
        }



﻿# ЗАДАНИЕ  ПО ПРОМЕЖУТОЧНОЙ АТТЕСТАЦИИ ПО ПРЕДМЕТУ ИСКЛЮЧЕНИЯ В ЯЗЫКЕ ПРОГРАММИРОВАНИЯ

## Напишите приложение, которое будет запрашивать у пользователя следующие данные, разделенные пробелом:

* ***Фамилия Имя Отчество дата _ рождения номер _ телефона пол***

### *Форматы данных:*

* дата _ рождения - строка формата dd.mm.yyyy
* номер _ телефона - целое беззнаковое число без форматирования
* пол - символ латиницей f или m.

## Приложение должно проверить введенные данные по количеству. Если количество не совпадает, вернуть код ошибки, обработать его и показать пользователю сообщение, что он ввел меньше и больше данных, чем требуется.

## Приложение должно распарсить полученную строку и выделить из них требуемые значения. Если форматы данных не совпадают, нужно бросить исключение, соответствующее типу проблемы. Можно использовать встроенные типы java и создать свои. Исключение должно быть корректно обработано, пользователю выведено сообщение с информацией, что именно неверно.

## Если всё введено и обработано верно, должен создаться файл с названием, равным фамилии, в него в одну строку должны записаться полученные данные, вида
* ***<Фамилия> <Имя> <Отчество> <дата _ рождения> <номер _ телефона> <пол>***

### Однофамильцы должны записаться в один и тот же файл, в отдельные строки.
### Не забудьте закрыть соединение с файлом.
### При возникновении проблемы с чтением-записью в файл, исключение должно быть корректно обработано, пользователь должен увидеть стектрейс ошибки.

# ВЫПОЛНЕННОЕ ЗАДАНИЕ

## 1. Задание выполнено на языке программирования C# в виде пользовательского приложения;
## 2. Для запуска программы можно открыть проект в Visual Studio, для этого необходимо открыть файл "Attestation Exceptions.sln" и нажать "Пуск" и программа соберет решение и появится окно с приложением, если происходят проблемы с таким запуском, либо отсутствует Visual Studio, есть уже собранное   приложение для Windows, которая находится по пути: "Здесь ваш диск и путь, где находится папка Attestation Exceptions\exeApp\Attestation Exceptions.exe"
## 3. В некоторых местах кодда присутствуют комментарии.
## 4. Перезапись файла будет происходит в том случае, если файл будет сохранен по пути: "C:\Users\Пользователь которого вы ввели в поле"

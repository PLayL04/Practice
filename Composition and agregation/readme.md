# Лабораторная работа №8. Композиция и агрегация
---
Студенты кафедры информатики и вычислительной техники разработали уникальное средство связи - смартфон, источником энергии для которого является нежное прикосновение владельца. Достаточно погладить ваше устройство, и оно снова включится.
В связи с большим спросом на данное изобретение, авторы обратились к вам с просьбой автоматизировать процесс учета
их продукции.
Описание информационной системы учета смартфонов, реагирующих на нежность:
- Информационная система должна вести учет продукции – собранные студентами ИВТ нежнолюбивые смартфоны – и контролировать очередь из желающих приобрести данное ноу-хау. 
- В разрабатываемой информационной системе важно учесть, что инновационный смартфон не предполагается продавать без
революционного датчика нежности. Он реагирует на нежность владельца, которая измеряется числовой шкалой при покупке.
- Чтобы датчик реагировал, нежность владельца должна быть ниже чувствительности
датчика не более чем в 1.5 раза. Но важно учесть и обратное. Излишне пылкие обладатели смартфонов
могут сломать слишком чувствительные датчики. По этой причине нежность владельцев не должна
превышать чувствительность датчика более чем в 2 раза.
Инновационное запатентованное устройство-трансформатор ТН-2м позволяет уменьшать или увеличивать нежность пользователя в 2 раза по сравнению с базовым значением. Применение данного устройства поможет пользователям, которые из-за своих показателей нежности не смогли подобрать устройство, пользоваться смартфоном наравне со всеми. Кроме того, любой произведенный смартфон изначально становится собственностью кафедры ИВТ ИКИТ СФУ. Люди, которые желают приобрести данное чудо техники, как-то жили и без этого изобретения, а, следовательно, они должны существовать вне зависимости от того, дождутся они своей очереди или нет.

Технические требования к информационной системе учета нежнолюбивых смартфонов.
- класс TactileSensor содержит такую характеристику как «чувствительность датчика»
(Sensitivity) и имеет ассоциацию, реализованную в виде композиции с классом
GentleSmartphone.
- класс GentleSmartphone, помимо включенного в него класса TactileSensor, имеет
порядковый номер произведенного устройства;
- класс Transformator, имеет серийный номер и показатель того, повышает он чувствительность
датчика или понижает (перечисление);
- класс Customer содержит ссылку на класс GentleSmartphone (между классами ассоциация в
виде агрегации), а также ФИО;
- класс Factory содержит коллекцию объектов Customer (между классами ассоциация в виде
агрегации) и коллекцию объектов GentleSmartphone (связь в виде композиции). В данном классе
реализовать метод SaleSmartphone(), который должен «пробежаться» по всем клиентам в
очереди на покупку и по возможности (при наличии) вручить каждому нежнолюбивый смартфон
При этом «врученный» смартфон удаляется из коллекции смартфонов предприятия кафедры ИВТ.
В случае, если всем желающим выдали устройство связи, но они все равно остались на складе,
происходит их ликвидация (очистка коллекции смартфонов).
Продемонстрируйте работу вашей системы. Создайте предприятие, добавьте несколько смартфонов, а
также людей, желающих приобрести данные устройства. Выведите информацию о смартфонах на складе
и людях до вызова метода SaleSmartphone() и после отработки данного метода
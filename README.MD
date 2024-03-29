[![jQuery](https://img.shields.io/badge/jquery-%230769AD.svg?style=for-the-badge&logo=jquery&logoColor=white)](https://jquery.com/)
[![SAAS](https://img.shields.io/badge/Sass-CC6699?style=for-the-badge&logo=sass&logoColor=white)](https://sass-lang.com/)
[![Gulp](https://img.shields.io/badge/GULP-%23CF4647.svg?style=for-the-badge&logo=gulp&logoColor=white)](https://gulpjs.com/)
[![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/en-us/)
[![Bootstrap](https://img.shields.io/badge/bootstrap-%238511FA.svg?style=for-the-badge&logo=bootstrap&logoColor=white)](https://getbootstrap.com/)

![image](https://github.com/Mark65537/ToDoList21/blob/master/Screenshots/screenshot1.png)
<h1>Описание</h1>
 Разработана система управления задачами. Система позволяет
редактировать иерархию задач, а также проводить некоторые вычисления по их полям данных.

<h2>Общее описание процесса</h2>

Стандартная схема работы с системой выглядит следующим образом:

1. Задачи заносятся в систему (создаются, редактируются, удаляются).
2. К любой задаче могут быть добавлены подзадачи.
3. При удалении задачи, удаление поддерева не требуется.
4. Структура задачи и подзадачи одинакова. Подзадача не может принадлежать более чем
одной задаче. Количество уровней подзадач не ограничено.
5. Поля «Плановая трудоёмкость задачи» и «Фактическое время выполнения» вычисляемые
и складываются из сумм подзадач, входящих в данную задачу, и самой задачи.

Каждая задача, отслеживаемая системой, характеризуется следующим набором атрибутов:
</p> Наименование задачи
</p> Описание задачи
</p> Список исполнителей (простое текстовое поле, ссылочность не нужна)
</p> Дата регистрации задачи в системе
</p> Статус задачи: Назначена, Выполняется, Приостановлена, Завершена (число статусов для
системы фиксировано и сами статусы неизменны).
</p> Плановая трудоёмкость задачи
</p> Фактическое время выполнения
</p> Дата завершения

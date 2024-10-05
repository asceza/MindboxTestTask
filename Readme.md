Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Проверку на то, является ли треугольник прямоугольным 


*В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, 
в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории».
Если у продукта нет категорий, то его имя все равно должно выводиться.*
```sql

CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(100) NOT NULL
);


CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(100) NOT NULL
);


-- Создание таблицы для связи между продуктами и категориями
-- Так как существует отношение многие-ко-многим используется дополнительная таблица
CREATE TABLE ProductCategories (
    ProductID INT,
    CategoryID INT,
    PRIMARY KEY (ProductID, CategoryID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);


INSERT INTO Products (ProductName) VALUES 
    ('Apple'),
    ('Banana'),
    ('Carrot'),
    ('Doughnut'),
    ('Cheese');


INSERT INTO Categories (CategoryName) VALUES 
    ('Fruits'),
    ('Vegetables'),
    ('Snacks'),
    ('Dairy'),
    ('Grains');


INSERT INTO ProductCategories (ProductID, CategoryID) VALUES 
    (1, 1), -- Apple belongs to Fruits
    (2, 1), -- Banana belongs to Fruits
    (2, 3), -- Banana belongs to Snacks
    (3, 2), -- Carrot belongs to Vegetables
    (4, 3), -- Doughnut belongs to Snacks
    (5, 4); -- Cheese belongs to Dairy


SELECT 
    p.ProductName, 
    c.CategoryName 
FROM 
    Products AS p
LEFT JOIN 
    ProductCategories AS pc ON p.ProductID = pc.ProductID
LEFT JOIN 
    Categories AS c ON pc.CategoryID = c.CategoryID;
```
- Таблица `Products` имеет `ProductID` как первичный ключ и `ProductName` для хранения названия продукта.
- Таблица `Categories` имеет `CategoryID` как первичный ключ и `CategoryName` для хранения названия категории.
- Таблица `ProductCategories` связывает продукты и категории, используя два внешних ключа: `ProductID` и `CategoryID`
- Используем `LEFT JOIN` между таблицами `Products` и `ProductCategories`, чтобы получить все продукты, даже если у них нет связанных категорий.
- Затем выполняем `LEFT JOIN` с таблицей `Categories`, чтобы получить название категории, при этом если категории нет, будет возвращено `NULL` вместо имени категории.



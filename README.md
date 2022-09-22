# ICS_Task
1)Заходим в свойства Employees_db.mdf, копируем полный путь.                            
2)Открываем обозреватель объектов, добавляем новое подключение.                                  
Источник данных - SQL Server                                  
Имя файла базы данных - наш скопироаванный путь                                
3)В обозревателе серверов Employees_db.mdf нажимаем на свойства, копируем строку подключения.                                
4)App.config меняе значение connectionString на наше.                               
5)В обозревателе объектов SQL Server(обновляем), заходим в нашу бд.                                                    
6)Создаем таблицу                            
CREATE TABLE [dbo].[Employees]                                  
(                     
  [Id] INT NOT NULL PRIMARY KEY IDENTITY,                                                     
    [Name] NVARCHAR(50) NULL,                           
    [SurName] NVARCHAR(50) NULL,                                   
    [Birthday] DATE NULL,                                  
    [Position] NVARCHAR(50) NULL,                                                                                               
    [Salary] INT NULL                                                    
7)Готова к запуску                                   

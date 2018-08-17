RESTORE FILELISTONLY
FROM DISK = 'C:\Users\1616696\AdventureWorks2016.bak'

RESTORE DATABASE AdventureWorks2016
FROM DISK = 'C:\Users\1616696\AdventureWorks2016.bak'

WITH MOVE 'AdventureWorks2016_data' TO 'C:\Users\1616696\Source\Repos\Csharp2018Aulas\DB\AdventureWorks2016.mdf',
MOVE 'AdventureWorks2016_log' TO 'C:\Users\1616696\Source\Repos\Csharp2018Aulas\DB\AdventureWorks2016.ldf',
REPLACE;
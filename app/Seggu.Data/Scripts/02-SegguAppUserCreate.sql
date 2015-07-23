USE [master]
GO
CREATE LOGIN [seggu] WITH PASSWORD=N'seggu', DEFAULT_DATABASE=[Seggu], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
USE [Seggu]
GO
CREATE USER [seggu] FOR LOGIN [seggu]
GO
USE [Seggu]
GO
ALTER USER [seggu] WITH DEFAULT_SCHEMA=[dbo]
GO
USE [Seggu]
GO
ALTER ROLE [db_owner] ADD MEMBER [seggu]
GO

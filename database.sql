create database API_DB_CONNECTION_TOMFOOLERY
GO

use API_DB_CONNECTION_TOMFOOLERY
Go

create table API_DB_CONN_USERS(
    uuid NVARCHAR(100) PRIMARY KEY,
    Username NVARCHAR(20),
    YearOfBirth int,
    [password] NVARCHAR(200)
)

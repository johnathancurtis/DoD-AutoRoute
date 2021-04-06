CREATE TABLE Request
( 
[UIC] VARCHAR(10) NOT NULL
, [Serial] VARCHAR (8)
, [Special Type] BIT
, [Regular Type] BIT
, [DATE IN] date Null,
PRIMARY KEY CLUSTERED (UIC ASC) 
)
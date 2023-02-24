create database crud
default character set utf8mb4
default collate utf8mb4_general_ci;

use crud;

create table if not exists crud (

	id int not null auto_increment primary key,
    nome varchar(100) not null,
    email varchar(100) not null,
    cpf varchar(11) not null,
    usuario varchar(12) not null,
    senha varchar(15) not null
    
) default char set utf8mb4;

select * from crud;

delete from crud 
where nome = 'Nome';

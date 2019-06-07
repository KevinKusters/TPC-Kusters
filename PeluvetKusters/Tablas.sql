--drop database peluvet

create database peluvet
go
use peluvet
go

SET DATEFORMAT dmy

go

create table clientes(
id int not null primary key identity(1,1),
nombre varchar(50) not null,
apellido varchar (50) not null,
contacto varchar(50) not null,
localidad int not null,
estado bit not null,
)
go
create table puestos(
id int not null primary key identity(1,1),
descripcion varchar(50) not null,
)
go
create table empleados(
id int not null primary key identity(1,1),
nombre varchar(50) not null,
apellido varchar(50) not null,
contacto varchar(50) not null,
puesto int not null foreign key references puestos(id),
rubro varchar(50) not null,
estado bit not null,
)
go
create table razas(
id int not null primary key identity(1,1),
nombre varchar(50) not null,
estado bit not null,
)
go
create table animales(
id int not null primary key identity(1,1),
idraza int not null foreign key references razas(id),
idcliente int not null foreign key references clientes(id),
nombre varchar(50) not null,
apellido varchar(50) not null,
especie varchar (50) not null,
estado bit not null,
)
go
create table servicios(
id int not null primary key identity(1,1),
descripcion varchar(50) not null,
precio money not null,
estado bit not null
)
go
create table turnos(
id int not null primary key identity(1,1),
idcliente int not null foreign key references clientes (id),
idmascota int not null foreign key references animales (id),
idservicio int not null foreign key references servicios (id),
idempleado int not null foreign key references empleados(id),
fecha date not null,
hora time not null, 
estado bit not null,
)
go
create table productos(
id int not null primary key identity(1,1 ),
descripcion varchar(50) not null,
stock int not null,
precio money not null,
precioVenta money not null,
porcentajeganancia int not null,
marca varchar(50) not null,
estado bit not null,
)
go
create table localidades (
idlocalidad int not null primary key identity (1,1),
nombre varchar(50) not null,
)
go
create table personasJuridicas(
idperjuridica int not null primary key identity (1,1),
Razonsocial varchar(50) not null,
cuit bigint not null,
estado bit not null,
)
go
create table proveedores (
idproveedor int not null primary key identity(1,1),
Nombre varchar(50) not null,
idperjuridica int not null foreign key references personasJuridicas (idperjuridica),
email varchar(50) null,
telefono varchar(50) not null,
estado bit not null,
)
go
create table ProductosXproveedores (
idproveedor int not null foreign key references proveedores (idproveedor),
idproducto int not null foreign key references productos (id),
primary key(idproveedor, idproducto)
)
go
create table animalesxCliente(
idanimal int foreign key references animales (id),
idcliente int foreign key references clientes(id),
primary key(idanimal,idcliente)
)
go
create table proveedoresXempresa (
idproveedor int not null foreign key references proveedores (idproveedor),
idperjuridica int not null foreign key references personasjuridicas(idperjuridica),
primary key(idproveedor,idperjuridica)
)

go

create procedure sp_listar_proveedores
as
begin
select p.idproveedor,p.nombre,p.email,p.telefono,pj.Razonsocial,pj.cuit as cuit_empresa,pj.idperjuridica from proveedores as p
inner join personasJuridicas as pj on pj.idperjuridica = p.idperjuridica
end 

go

CREATE PROCEDURE sp_cargar_cbo_proveedores
as 
begin
select idproveedor,nombre from proveedores
end

go

create procedure sp_listar_clientes
as
begin
select c.id,c.nombre, c.apellido, c.contacto,l.idlocalidad as IDlocalidad,l.nombre as localidad from clientes as c
inner join localidades as l on c.localidad = l.idlocalidad
where c.estado = 1;
end

go

create procedure sp_listar_mascotas
as
begin
select a.nombre,a.apellido,a.especie,a.idraza,r.nombre as RazaNombre from animales as a
inner join razas as r on r.id = a.idraza
end

go

create procedure sp_listar_empleados
as
begin
select e.id, e.nombre, e.apellido, e.contacto,e.rubro, p.descripcion as puesto, p.id as idpuesto from empleados as e
inner join puestos as p on p.id = e.puesto
where e.estado like 1
end

go

create procedure sp_listar_turnos
as
begin 
select t.id as IdTurno,t.fecha as Fecha,t.hora as Hora, c.nombre as Nombre,c.apellido as Apellido,a.nombre as Mascota,r.nombre as Raza,s.descripcion as Servicio,s.precio as Precio,e.nombre as NombreEmpleado ,e.apellido as ApellidoEmpleado from turnos as t
inner join clientes as c on c.id = t.idcliente
inner join animales as a on a.id = t.id
inner join razas as r on r.id = a.idraza
inner join servicios as s on s.id = t.idservicio
inner join empleados as e on e.id = t.idempleado
where t.estado like 1 
end

create procedure sp_listar_turnos_hoy
as
begin 
select t.id as IdTurno,t.fecha as Fecha,t.hora as Hora, c.nombre as Nombre,c.apellido as Apellido,a.nombre as Mascota,r.nombre as Raza,s.descripcion as Servicio,s.precio as Precio,e.nombre as NombreEmpleado ,e.apellido as ApellidoEmpleado from turnos as t
inner join clientes as c on c.id = t.idcliente
inner join animales as a on a.id = t.id
inner join razas as r on r.id = a.idraza
inner join servicios as s on s.id = t.idservicio
inner join empleados as e on e.id = t.idempleado
where t.estado like 1 and DATEPART(year ,t.fecha) like DATEPART(year,GETDATE()) and DATEPART(MONTH ,t.fecha) like DATEPART(MONTH,GETDATE()) and DATEPART(DAY ,t.fecha) like DATEPART(DAY,GETDATE())
end

select * from turnos

--drop procedure sp_listar_turnos
--drop procedure sp_listar_empleados

/*
insert into clientes (nombres,apellidos,contacto,localidad)
values ('pepe','gonzales','pepegonzales@gmail.com','sanjusto')

insert into razas (nombre)
values('Breton')
insert into razas (nombre)
values('Coli')

insert into productos (descripcion, stock,  precio, marca)
values ('Shampoo','5','150','pepito')

insert into productos (descripcion, stock,  precio, marca)
values ('Crema','15','100','Pepote')

insert into localidades (nombre)
values ('Pacheco')
insert into localidades (nombre)
values ('San Fernando')
insert into localidades (nombre)
values ('Tigre')
insert into localidades (nombre)
values ('Carupa')

insert into personasJuridicas (Razonsocial,cuit)
values('Otra SRL','2365612057')
insert into personasJuridicas (Razonsocial,cuit)
values ('Marubel SA','2360915557')

insert into proveedores (idperjuridica, email,telefono,nombre)
values ('1','Alguien@Algo.com','47321855','Alguien')
insert into proveedores (idperjuridica, email,telefono,nombre)
values ('2','Alguienmas@Algomas.com','47462218','Alguienmas')

--update PRODUCTOS set DESCRIPCION = 'Shampoo pulgas' , STOCK = '20', PRECIO ='150', MARCA ='Montoto'  Where Id = 3

select * from localidades

select * from empleados

select * from clientes

select * from localidades

select * from animales

select * from servicios

insert into animalesxCliente (idanimal,idcliente)
values ('1','2')

select * from animalesxCliente


select distinct a.nombre,a.apellido,a.especie,r.nombre as Raza from animales as a inner join razas as r on r.id = a.idraza inner join clientes as cli on cli.id = a.idcliente inner join animalesxCliente as axc on axc.idcliente = cli.id


UPDATE SERVICIOS SET DESCRIPCION = Corte higienico, @PRECIO = @precio WHERE ID = @ID

*/
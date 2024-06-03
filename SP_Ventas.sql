select * from Empleados
create proc SP_REGISTRARUSUARIO(
@ID_Rol int,
@Usuario varchar(50),
@Clave varchar(50),
@NombreCompleto varchar(100),
@ID_Cargo int,
@Telefono varchar(50),
@Correo varchar(150),
@Direccion varchar(150),
@Cedula varchar(100),
@Estado bit,
@ID_EmpleadoResultado int output,
@Mensaje varchar(500) output
)
as
begin
	set @ID_EmpleadoResultado = 0
	set @Mensaje = ''

	if not exists(select * from Empleados where Usuario = @Usuario)
	begin
		insert into Empleados(ID_Rol, Usuario, Clave, NombreCompleto, ID_Cargo, Telefono, Correo, Direccion, Cedula, Estado) values
		(@ID_Rol, @Usuario, @Clave, @NombreCompleto, @ID_Cargo, @Telefono, @Correo, @Direccion, @Cedula, @Estado)

		set @ID_EmpleadoResultado = SCOPE_IDENTITY()

	end
	else
		set @Mensaje = 'Este nombre de usuario ya existe'

end

create proc SP_EDITARUSUARIO(
@ID_Empleado int,
@ID_Rol int,
@Usuario varchar(50),
@Clave varchar(50),
@NombreCompleto varchar(100),
@ID_Cargo int,
@Telefono varchar(50),
@Correo varchar(150),
@Direccion varchar(150),
@Cedula varchar(100),
@Estado bit,
@Respuesta  bit output,
@Mensaje varchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''

	if not exists(select * from Empleados where Usuario = @Usuario and ID_Empleado != @ID_Empleado)
	begin
		update Empleados set
		ID_Rol = @ID_Rol,
		Usuario = @Usuario,
		Clave = @Clave,
		NombreCompleto = @NombreCompleto,
		ID_Cargo = @ID_Cargo,
		Telefono = @Telefono,
		Correo = @Correo,
		Direccion = @Direccion,
		Cedula = @Cedula,
		Estado = @Estado
		where ID_Empleado = @ID_Empleado

		set @Respuesta = 1

	end
	else
		set @Mensaje = 'Este nombre de usuario ya existe'

end


create proc SP_ELIMINARUSUARIO(
@ID_Empleado int,
@Respuesta  bit output,
@Mensaje varchar(500) output
)
as
begin
	declare @pasoreglas bit = 1
	set @Respuesta = 0
	set @Mensaje = ''


	if exists(SELECT * from Compras c 
	inner join Empleados e on e.ID_Empleado = c.ID_Empleado
	where e.ID_Empleado = @ID_Empleado
	)
	begin
			set @pasoreglas = 0
			set @Respuesta = 0
			set @Mensaje = 'No se puede eliminar porque el usuario se encuentra relacionado a una COMPRA\n'

	end

	if exists(SELECT * from Ventas v 
	inner join Empleados e on e.ID_Empleado = v.ID_Empleado
	where e.ID_Empleado = @ID_Empleado
	)
	begin
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = 'No se puede eliminar porque el usuario se encuentra relacionado a una VENTA\n'

	end

	if (@pasoreglas = 1) 
	begin
		delete from Empleados where ID_Empleado = @ID_Empleado
		set @Respuesta = 1
	end

	end
	
		





declare @Respuesta bit

declare @mensaje varchar(500)

exec SP_EDITARUSUARIO 1002, 1, '111', 'smash', 'Idaulin Polanco Lopez', 1, '809-123-4212', 'Id@Gmail.com', 'C. Marivladdys', '402-123456-2', 1,@Respuesta output,@mensaje output

select @Respuesta

select @mensaje

select * from Empleados


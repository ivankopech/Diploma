create proc DashboardDatos
@nEspecialidades int out,
@nMedicos int out
as
set @nEspecialidades=(select count (id) as cantEspecialidades from Especialidads)
set @nMedicos=(select count (id) as cantMedicos from Usuarios where Discriminator = 'Medico')
go

create proc DashboardDataTurnos
@nTurnoes int out,
@nMedicos int out
as
set @nTurnoes = (select count (id) as cantTurnos from Turnoes)
set @nMedicos = (select count (id) as cantMedicos from Usuarios where Discriminator = 'Medico')
go






select * from Usuarios

select * from Turnoes

--cantidad de medicos por especialidad
create proc medicosPorEspecialidad
AS
select Tipo, count (Tipo) as cantidadMedicos
from Especialidads
group by Tipo
order by count (2)
go

-- cantidad de medicos por turnos 
create proc medicoTurnos
as
select NombreUsuario,  count (NombreUsuario) as cantidadTurnos
from Turnoes 
inner join Usuarios on Turnoes.UsuarioMedico_id = Usuarios.id
group by UsuarioMedico_id, NombreUsuario
order by count (2)
go

-- cantidad de pacientes por turnos
create proc pacienteTurnos
as
select NombreUsuario,  count (NombreUsuario) as cantidadTurnos
from Turnoes 
inner join Usuarios on Turnoes.UsuarioPaciente_id = Usuarios.id
group by UsuarioPaciente_id, NombreUsuario
order by count (2)
go


select * from Turnoes
select * from Usuarios

-- ejemplo mauri con 3 columnas
create proc medicoTurno
AS
select UsuarioMedico_id, NombreUsuario,  count (UsuarioMedico_id) as cantidadMedicos
from Turnoes 
inner join Usuarios on Turnoes.UsuarioMedico_id = Usuarios.id
group by UsuarioMedico_id, NombreUsuario
order by count (2)
go

-- resetear

delete from UsuarioAuditorias
delete from PlanAuditorias;
delete from ObraSocialAuditorias;
delete from GrupoAuditorias;
delete from EspecialidadAuditorias;
delete from TurnoAuditorias;

delete from Sesions;
delete from Plans;
delete from ObraSocials;
delete from Especialidads;
delete from Usuarios;
delete from Grupoes;
delete from Permisoes;
delete from Turnoes;

select * from Especialidads
select * from Turnoes
select * from Usuarios
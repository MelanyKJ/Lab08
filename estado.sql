ALTER TABLE [dbo].[clientes]
ADD estado BIT;

UPDATE [dbo].[clientes]
SET estado = 1;

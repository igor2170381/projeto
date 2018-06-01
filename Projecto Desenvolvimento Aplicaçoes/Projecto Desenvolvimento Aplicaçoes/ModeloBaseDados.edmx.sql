
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/30/2018 09:20:28
-- Generated from EDMX file: D:\Escola\Segundo Semestere\Desenvolvimento de Aplicações\Projecto\Projecto Desenvolvimento Aplicaçoes\Projecto Desenvolvimento Aplicaçoes\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MinhaOficinaDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clientes'
CREATE TABLE [dbo].[Clientes] (
    [IdCliente] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [NIF] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Contacto] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Arrendamentos'
CREATE TABLE [dbo].[Arrendamentos] (
    [IdArrendamento] int IDENTITY(1,1) NOT NULL,
    [InicioContacto] nvarchar(max)  NOT NULL,
    [DuracaoMeses] nvarchar(max)  NOT NULL,
    [Renovavel] nvarchar(max)  NOT NULL,
    [CasaArrendavel_IdCasa] int  NULL,
    [Cliente_IdCliente] int  NOT NULL
);
GO

-- Creating table 'Casas'
CREATE TABLE [dbo].[Casas] (
    [IdCasa] int IDENTITY(1,1) NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL,
    [Rua] nvarchar(max)  NOT NULL,
    [Numero] nvarchar(max)  NOT NULL,
    [Andar] nvarchar(max)  NOT NULL,
    [Area] nvarchar(max)  NOT NULL,
    [NumeroAssoalhadas] nvarchar(max)  NOT NULL,
    [NumeroWC] nvarchar(max)  NOT NULL,
    [NumeroPisos] nvarchar(max)  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [Cliente_IdCliente] int  NOT NULL
);
GO

-- Creating table 'Limpezas'
CREATE TABLE [dbo].[Limpezas] (
    [IdLimpeza] int IDENTITY(1,1) NOT NULL,
    [Data] nvarchar(max)  NOT NULL,
    [Casa_IdCasa] int  NULL
);
GO

-- Creating table 'Servicos'
CREATE TABLE [dbo].[Servicos] (
    [IdServico] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Valor] nvarchar(max)  NOT NULL,
    [Unidades] nvarchar(max)  NOT NULL,
    [Limpeza_IdLimpeza] int  NOT NULL
);
GO

-- Creating table 'Vendas'
CREATE TABLE [dbo].[Vendas] (
    [IdVenda] int IDENTITY(1,1) NOT NULL,
    [DataVenda] nvarchar(max)  NOT NULL,
    [ValorNegociado] nvarchar(max)  NOT NULL,
    [ComissaoNegociada] nvarchar(max)  NOT NULL,
    [CasaVendavel_IdCasa] int  NOT NULL,
    [Cliente_IdCliente] int  NOT NULL
);
GO

-- Creating table 'Casas_CasaVendavel'
CREATE TABLE [dbo].[Casas_CasaVendavel] (
    [ValorBaseVenda] nvarchar(max)  NOT NULL,
    [ValorComissao] nvarchar(max)  NOT NULL,
    [IdCasa] int  NOT NULL
);
GO

-- Creating table 'Casas_CasaArrendavel'
CREATE TABLE [dbo].[Casas_CasaArrendavel] (
    [ValorBaseMes] nvarchar(max)  NOT NULL,
    [Comissao] nvarchar(max)  NOT NULL,
    [IdCasa] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdCliente] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [PK_Clientes]
    PRIMARY KEY CLUSTERED ([IdCliente] ASC);
GO

-- Creating primary key on [IdArrendamento] in table 'Arrendamentos'
ALTER TABLE [dbo].[Arrendamentos]
ADD CONSTRAINT [PK_Arrendamentos]
    PRIMARY KEY CLUSTERED ([IdArrendamento] ASC);
GO

-- Creating primary key on [IdCasa] in table 'Casas'
ALTER TABLE [dbo].[Casas]
ADD CONSTRAINT [PK_Casas]
    PRIMARY KEY CLUSTERED ([IdCasa] ASC);
GO

-- Creating primary key on [IdLimpeza] in table 'Limpezas'
ALTER TABLE [dbo].[Limpezas]
ADD CONSTRAINT [PK_Limpezas]
    PRIMARY KEY CLUSTERED ([IdLimpeza] ASC);
GO

-- Creating primary key on [IdServico] in table 'Servicos'
ALTER TABLE [dbo].[Servicos]
ADD CONSTRAINT [PK_Servicos]
    PRIMARY KEY CLUSTERED ([IdServico] ASC);
GO

-- Creating primary key on [IdVenda] in table 'Vendas'
ALTER TABLE [dbo].[Vendas]
ADD CONSTRAINT [PK_Vendas]
    PRIMARY KEY CLUSTERED ([IdVenda] ASC);
GO

-- Creating primary key on [IdCasa] in table 'Casas_CasaVendavel'
ALTER TABLE [dbo].[Casas_CasaVendavel]
ADD CONSTRAINT [PK_Casas_CasaVendavel]
    PRIMARY KEY CLUSTERED ([IdCasa] ASC);
GO

-- Creating primary key on [IdCasa] in table 'Casas_CasaArrendavel'
ALTER TABLE [dbo].[Casas_CasaArrendavel]
ADD CONSTRAINT [PK_Casas_CasaArrendavel]
    PRIMARY KEY CLUSTERED ([IdCasa] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CasaVendavel_IdCasa] in table 'Vendas'
ALTER TABLE [dbo].[Vendas]
ADD CONSTRAINT [FK_VendaCasaVendavel]
    FOREIGN KEY ([CasaVendavel_IdCasa])
    REFERENCES [dbo].[Casas_CasaVendavel]
        ([IdCasa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VendaCasaVendavel'
CREATE INDEX [IX_FK_VendaCasaVendavel]
ON [dbo].[Vendas]
    ([CasaVendavel_IdCasa]);
GO

-- Creating foreign key on [CasaArrendavel_IdCasa] in table 'Arrendamentos'
ALTER TABLE [dbo].[Arrendamentos]
ADD CONSTRAINT [FK_CasaArrendavelArrendamento]
    FOREIGN KEY ([CasaArrendavel_IdCasa])
    REFERENCES [dbo].[Casas_CasaArrendavel]
        ([IdCasa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CasaArrendavelArrendamento'
CREATE INDEX [IX_FK_CasaArrendavelArrendamento]
ON [dbo].[Arrendamentos]
    ([CasaArrendavel_IdCasa]);
GO

-- Creating foreign key on [Casa_IdCasa] in table 'Limpezas'
ALTER TABLE [dbo].[Limpezas]
ADD CONSTRAINT [FK_CasaLimpeza]
    FOREIGN KEY ([Casa_IdCasa])
    REFERENCES [dbo].[Casas]
        ([IdCasa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CasaLimpeza'
CREATE INDEX [IX_FK_CasaLimpeza]
ON [dbo].[Limpezas]
    ([Casa_IdCasa]);
GO

-- Creating foreign key on [Cliente_IdCliente] in table 'Vendas'
ALTER TABLE [dbo].[Vendas]
ADD CONSTRAINT [FK_ClienteVenda]
    FOREIGN KEY ([Cliente_IdCliente])
    REFERENCES [dbo].[Clientes]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteVenda'
CREATE INDEX [IX_FK_ClienteVenda]
ON [dbo].[Vendas]
    ([Cliente_IdCliente]);
GO

-- Creating foreign key on [Cliente_IdCliente] in table 'Arrendamentos'
ALTER TABLE [dbo].[Arrendamentos]
ADD CONSTRAINT [FK_ClienteArrendamento]
    FOREIGN KEY ([Cliente_IdCliente])
    REFERENCES [dbo].[Clientes]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteArrendamento'
CREATE INDEX [IX_FK_ClienteArrendamento]
ON [dbo].[Arrendamentos]
    ([Cliente_IdCliente]);
GO

-- Creating foreign key on [Cliente_IdCliente] in table 'Casas'
ALTER TABLE [dbo].[Casas]
ADD CONSTRAINT [FK_ClienteCasa]
    FOREIGN KEY ([Cliente_IdCliente])
    REFERENCES [dbo].[Clientes]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteCasa'
CREATE INDEX [IX_FK_ClienteCasa]
ON [dbo].[Casas]
    ([Cliente_IdCliente]);
GO

-- Creating foreign key on [Limpeza_IdLimpeza] in table 'Servicos'
ALTER TABLE [dbo].[Servicos]
ADD CONSTRAINT [FK_LimpezaServico]
    FOREIGN KEY ([Limpeza_IdLimpeza])
    REFERENCES [dbo].[Limpezas]
        ([IdLimpeza])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LimpezaServico'
CREATE INDEX [IX_FK_LimpezaServico]
ON [dbo].[Servicos]
    ([Limpeza_IdLimpeza]);
GO

-- Creating foreign key on [IdCasa] in table 'Casas_CasaVendavel'
ALTER TABLE [dbo].[Casas_CasaVendavel]
ADD CONSTRAINT [FK_CasaVendavel_inherits_Casa]
    FOREIGN KEY ([IdCasa])
    REFERENCES [dbo].[Casas]
        ([IdCasa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCasa] in table 'Casas_CasaArrendavel'
ALTER TABLE [dbo].[Casas_CasaArrendavel]
ADD CONSTRAINT [FK_CasaArrendavel_inherits_Casa]
    FOREIGN KEY ([IdCasa])
    REFERENCES [dbo].[Casas]
        ([IdCasa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
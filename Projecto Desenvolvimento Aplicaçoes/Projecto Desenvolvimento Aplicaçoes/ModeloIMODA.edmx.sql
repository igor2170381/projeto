
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/04/2018 11:36:05
-- Generated from EDMX file: D:\IPL - ESTG\1º Ano\2º Semestre\Desenvolvimento de Aplicações\Projecto Desenvolvimento Aplicaçoes\Projecto Desenvolvimento Aplicaçoes\ModeloIMODA.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [IMODATABASE];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CasaLimpeza]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Limpezas] DROP CONSTRAINT [FK_CasaLimpeza];
GO
IF OBJECT_ID(N'[dbo].[FK_LimpezaServico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Servicos] DROP CONSTRAINT [FK_LimpezaServico];
GO
IF OBJECT_ID(N'[dbo].[FK_VendaCasaVendavel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vendas] DROP CONSTRAINT [FK_VendaCasaVendavel];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vendas] DROP CONSTRAINT [FK_ClienteVenda];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteArrendamento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Arrendamentos] DROP CONSTRAINT [FK_ClienteArrendamento];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteCasa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Casas] DROP CONSTRAINT [FK_ClienteCasa];
GO
IF OBJECT_ID(N'[dbo].[FK_CasaArrendavelArrendamento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Arrendamentos] DROP CONSTRAINT [FK_CasaArrendavelArrendamento];
GO
IF OBJECT_ID(N'[dbo].[FK_CasaVendavel_inherits_Casa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Casas_CasaVendavel] DROP CONSTRAINT [FK_CasaVendavel_inherits_Casa];
GO
IF OBJECT_ID(N'[dbo].[FK_CasaArrendavel_inherits_Casa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Casas_CasaArrendavel] DROP CONSTRAINT [FK_CasaArrendavel_inherits_Casa];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Limpezas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Limpezas];
GO
IF OBJECT_ID(N'[dbo].[Vendas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vendas];
GO
IF OBJECT_ID(N'[dbo].[Clientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clientes];
GO
IF OBJECT_ID(N'[dbo].[Arrendamentos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Arrendamentos];
GO
IF OBJECT_ID(N'[dbo].[Casas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Casas];
GO
IF OBJECT_ID(N'[dbo].[Servicos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Servicos];
GO
IF OBJECT_ID(N'[dbo].[Casas_CasaVendavel]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Casas_CasaVendavel];
GO
IF OBJECT_ID(N'[dbo].[Casas_CasaArrendavel]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Casas_CasaArrendavel];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Limpezas'
CREATE TABLE [dbo].[Limpezas] (
    [IdLimpeza] int IDENTITY(1,1) NOT NULL,
    [Data] datetime  NOT NULL,
    [Casa_IdCasa] int  NULL
);
GO

-- Creating table 'Vendas'
CREATE TABLE [dbo].[Vendas] (
    [IdVenda] int IDENTITY(1,1) NOT NULL,
    [DataVenda] datetime  NOT NULL,
    [ValorNegociado] decimal(18,0)  NOT NULL,
    [ComissaoNegociada] decimal(18,0)  NOT NULL,
    [CasaVendavel_IdCasa] int  NOT NULL,
    [Comprador_IdCliente] int  NOT NULL
);
GO

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
    [InicioContrato] datetime  NOT NULL,
    [DuracaoMeses] int  NOT NULL,
    [Renovavel] bit  NOT NULL,
    [Arrendatario_IdCliente] int  NOT NULL,
    [CasaArrendavel_IdCasa] int  NULL
);
GO

-- Creating table 'Casas'
CREATE TABLE [dbo].[Casas] (
    [IdCasa] int IDENTITY(1,1) NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL,
    [Rua] nvarchar(max)  NOT NULL,
    [Numero] int  NOT NULL,
    [Andar] int  NOT NULL,
    [Area] decimal(18,0)  NOT NULL,
    [NumeroAssoalhadas] int  NOT NULL,
    [NumeroWC] int  NOT NULL,
    [NumeroPisos] int  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [Proprietario_IdCliente] int  NOT NULL
);
GO

-- Creating table 'Servicos'
CREATE TABLE [dbo].[Servicos] (
    [IdServico] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [Unidades] int  NOT NULL,
    [Limpeza_IdLimpeza] int  NULL
);
GO

-- Creating table 'Casas_CasaVendavel'
CREATE TABLE [dbo].[Casas_CasaVendavel] (
    [ValorBaseVenda] decimal(18,0)  NOT NULL,
    [ValorComissao] decimal(18,0)  NOT NULL,
    [IdCasa] int  NOT NULL
);
GO

-- Creating table 'Casas_CasaArrendavel'
CREATE TABLE [dbo].[Casas_CasaArrendavel] (
    [ValorBaseMes] decimal(18,0)  NOT NULL,
    [Comissao] decimal(18,0)  NOT NULL,
    [IdCasa] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdLimpeza] in table 'Limpezas'
ALTER TABLE [dbo].[Limpezas]
ADD CONSTRAINT [PK_Limpezas]
    PRIMARY KEY CLUSTERED ([IdLimpeza] ASC);
GO

-- Creating primary key on [IdVenda] in table 'Vendas'
ALTER TABLE [dbo].[Vendas]
ADD CONSTRAINT [PK_Vendas]
    PRIMARY KEY CLUSTERED ([IdVenda] ASC);
GO

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

-- Creating primary key on [IdServico] in table 'Servicos'
ALTER TABLE [dbo].[Servicos]
ADD CONSTRAINT [PK_Servicos]
    PRIMARY KEY CLUSTERED ([IdServico] ASC);
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

-- Creating foreign key on [Comprador_IdCliente] in table 'Vendas'
ALTER TABLE [dbo].[Vendas]
ADD CONSTRAINT [FK_ClienteVenda]
    FOREIGN KEY ([Comprador_IdCliente])
    REFERENCES [dbo].[Clientes]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteVenda'
CREATE INDEX [IX_FK_ClienteVenda]
ON [dbo].[Vendas]
    ([Comprador_IdCliente]);
GO

-- Creating foreign key on [Arrendatario_IdCliente] in table 'Arrendamentos'
ALTER TABLE [dbo].[Arrendamentos]
ADD CONSTRAINT [FK_ClienteArrendamento]
    FOREIGN KEY ([Arrendatario_IdCliente])
    REFERENCES [dbo].[Clientes]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteArrendamento'
CREATE INDEX [IX_FK_ClienteArrendamento]
ON [dbo].[Arrendamentos]
    ([Arrendatario_IdCliente]);
GO

-- Creating foreign key on [Proprietario_IdCliente] in table 'Casas'
ALTER TABLE [dbo].[Casas]
ADD CONSTRAINT [FK_ClienteCasa]
    FOREIGN KEY ([Proprietario_IdCliente])
    REFERENCES [dbo].[Clientes]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteCasa'
CREATE INDEX [IX_FK_ClienteCasa]
ON [dbo].[Casas]
    ([Proprietario_IdCliente]);
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
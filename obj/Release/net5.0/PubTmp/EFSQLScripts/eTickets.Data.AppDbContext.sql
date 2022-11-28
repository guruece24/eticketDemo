IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221116100447_Initial')
BEGIN
    CREATE TABLE [Actors] (
        [Id] int NOT NULL IDENTITY,
        [ProfilePictureURL] nvarchar(max) NULL,
        [FullName] nvarchar(max) NULL,
        [Bio] nvarchar(max) NULL,
        CONSTRAINT [PK_Actors] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221116100447_Initial')
BEGIN
    CREATE TABLE [Cinemas] (
        [Id] int NOT NULL IDENTITY,
        [Logo] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        CONSTRAINT [PK_Cinemas] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221116100447_Initial')
BEGIN
    CREATE TABLE [Producers] (
        [Id] int NOT NULL IDENTITY,
        [ProfilePictureURL] nvarchar(max) NULL,
        [FullName] nvarchar(max) NULL,
        [Bio] nvarchar(max) NULL,
        CONSTRAINT [PK_Producers] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221116100447_Initial')
BEGIN
    CREATE TABLE [Movies] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [Price] float NOT NULL,
        [ImageURL] nvarchar(max) NULL,
        [StartDate] datetime2 NOT NULL,
        [EndDate] datetime2 NOT NULL,
        [MovieCategory] int NOT NULL,
        [CinemaId] int NOT NULL,
        [ProducerId] int NOT NULL,
        CONSTRAINT [PK_Movies] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Movies_Cinemas_CinemaId] FOREIGN KEY ([CinemaId]) REFERENCES [Cinemas] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Movies_Producers_ProducerId] FOREIGN KEY ([ProducerId]) REFERENCES [Producers] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221116100447_Initial')
BEGIN
    CREATE TABLE [Actors_Movies] (
        [MovieId] int NOT NULL,
        [ActorId] int NOT NULL,
        CONSTRAINT [PK_Actors_Movies] PRIMARY KEY ([ActorId], [MovieId]),
        CONSTRAINT [FK_Actors_Movies_Actors_ActorId] FOREIGN KEY ([ActorId]) REFERENCES [Actors] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Actors_Movies_Movies_MovieId] FOREIGN KEY ([MovieId]) REFERENCES [Movies] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221116100447_Initial')
BEGIN
    CREATE INDEX [IX_Actors_Movies_MovieId] ON [Actors_Movies] ([MovieId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221116100447_Initial')
BEGIN
    CREATE INDEX [IX_Movies_CinemaId] ON [Movies] ([CinemaId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221116100447_Initial')
BEGIN
    CREATE INDEX [IX_Movies_ProducerId] ON [Movies] ([ProducerId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221116100447_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221116100447_Initial', N'5.0.0');
END;
GO

COMMIT;
GO


﻿using Umbraco.Cms.Core.Events;
using Umbraco.Cms.Core.Models;

using uSync.Migrations.Handlers.Seven;
using uSync.Migrations.Services;

namespace uSync.Migrations.Handlers.Seven;

[SyncMigrationHandler(BackOfficeConstants.Groups.Settings, uSyncMigrations.Priorities.MediaTypes, 7,
    SourceFolderName = "MediaType",
    TargetFolderName = "MediaTypes")]
internal class MediaTypeMigrationHandler : ContentTypeBaseMigrationHandler<MediaType>, ISyncMigrationHandler
{
    public MediaTypeMigrationHandler(
        IEventAggregator eventAggregator,
        ISyncMigrationFileService migrationFileService)
        : base(eventAggregator, migrationFileService)
    { }
}

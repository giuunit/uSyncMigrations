﻿using Umbraco.Cms.Core.PropertyEditors;

namespace uSync.Migrations.Migrators;

[SyncMigrator(UmbConstants.PropertyEditors.Aliases.DateTime, typeof(DateTimeConfiguration), IsDefaultAlias = true)]
[SyncMigrator("Umbraco.Date")]
public class DatePickerMigrator : SyncPropertyMigratorBase
{ }

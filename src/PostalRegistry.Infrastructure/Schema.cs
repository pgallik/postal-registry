namespace PostalRegistry.Infrastructure
{
    public static class Schema
    {
        public const string Default = "PostalRegistry";

        public const string Import = "PostalRegistryImport";
        public const string Legacy = "PostalRegistryLegacy";
        public const string Extract = "PostalRegistryExtract";
        public const string Syndication = "PostalRegistrySyndication";
    }

    public static class MigrationTables
    {
        public const string Legacy = "__EFMigrationsHistoryLegacy";
        public const string Extract = "__EFMigrationsHistoryExtract";
        public const string RedisDataMigration = "__EFMigrationsHistoryDataMigration";
        public const string Syndication = "__EFMigrationsHistorySyndication";
    }
}

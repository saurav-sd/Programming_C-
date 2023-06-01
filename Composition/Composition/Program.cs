using System;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbmigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbmigrator.Migrator();
            installer.Install();
        }
    }
}

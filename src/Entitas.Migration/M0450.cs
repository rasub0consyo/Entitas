﻿namespace Entitas.Migration
{
    public class M0450 : IMigration
    {
        public string version => "0.45.0";
        public string workingDirectory => "project root";
        public string description => "Updates Entitas.properties to use renamed keys";

        public MigrationFile[] Migrate(string path)
        {
            var properties = MigrationUtils.GetFiles(path, "Entitas.properties");

            for (var i = 0; i < properties.Length; i++)
            {
                var file = properties[i];
                
                file.fileContent = file.fileContent.Replace("Entitas.CodeGeneration.CodeGenerator.SearchPaths", "CodeGenerator.SearchPaths");
                file.fileContent = file.fileContent.Replace("Entitas.CodeGeneration.CodeGenerator.Plugins", "CodeGenerator.Plugins");

                file.fileContent = file.fileContent.Replace("Entitas.CodeGeneration.CodeGenerator.DataProviders", "CodeGenerator.DataProviders");
                file.fileContent = file.fileContent.Replace("Entitas.CodeGeneration.CodeGenerator.CodeGenerators", "CodeGenerator.CodeGenerators");
                file.fileContent = file.fileContent.Replace("Entitas.CodeGeneration.CodeGenerator.PostProcessors", "CodeGenerator.PostProcessors");

                file.fileContent = file.fileContent.Replace("Entitas.CodeGeneration.CodeGenerator.CLI.Ignore.UnusedKeys", "CodeGenerator.CLI.Ignore.UnusedKeys");
            }

            return properties;
        }
    }
}

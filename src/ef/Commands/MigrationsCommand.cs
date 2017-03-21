// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.Tools.Properties;
using Microsoft.Extensions.CommandLineUtils;

namespace Microsoft.EntityFrameworkCore.Tools.Commands
{
    internal class MigrationsCommand : HelpCommandBase
    {
        public override void Configure(CommandLineApplication command)
        {
            command.Description = Resources.MigrationsDescription;

            command.Command("add", new MigrationsAddCommand().Configure);
            command.Command("list", new MigrationsListCommand().Configure);
            command.Command("remove", new MigrationsRemoveCommand().Configure);
            command.Command("script", new MigrationsScriptCommand().Configure);

            base.Configure(command);
        }
    }
}

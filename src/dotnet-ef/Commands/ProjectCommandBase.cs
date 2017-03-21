// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Extensions.CommandLineUtils;

namespace Microsoft.EntityFrameworkCore.Tools.Commands
{
    internal class ProjectCommandBase : EnvironmentCommandBase
    {
        public override void Configure(CommandLineApplication command)
        {
            new ProjectOptions().Configure(command);

            base.Configure(command);
        }
    }
}

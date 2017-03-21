// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.Tools.Properties;
using Microsoft.Extensions.CommandLineUtils;

namespace Microsoft.EntityFrameworkCore.Tools.Commands
{
    internal class ContextCommandBase : ProjectCommandBase
    {
        private CommandOption _context;

        protected CommandOption Context
            => _context;

        public override void Configure(CommandLineApplication command)
        {
            _context = command.Option("-c|--context <DBCONTEXT>", Resources.ContextDescription);

            base.Configure(command);
        }
    }
}

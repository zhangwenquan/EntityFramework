// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.Tools.Properties;
using Microsoft.Extensions.CommandLineUtils;

namespace Microsoft.EntityFrameworkCore.Tools
{
    internal static class Json
    {
        public static CommandOption ConfigureOption(CommandLineApplication command)
            => command.Option("--json", Resources.JsonDescription);

        public static string Escape(string text)
            => text.Replace("\\", "\\\\").Replace("\"", "\\\"");
    }
}

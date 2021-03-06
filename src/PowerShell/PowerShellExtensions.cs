//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

using System.Collections.ObjectModel;

namespace Microsoft.Azure.Functions.PowerShellWorker.PowerShell
{
    using System.Management.Automation;

    internal static class PowerShellExtensions
    {
        public static void InvokeAndClearCommands(this PowerShell pwsh)
        {
            pwsh.Invoke();
            pwsh.Commands.Clear();
        }

        public static Collection<T> InvokeAndClearCommands<T>(this PowerShell pwsh)
        {
            var result = pwsh.Invoke<T>();
            pwsh.Commands.Clear();
            return result;
        }
    }
}

// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.Data.Entity.Infrastructure;

namespace Microsoft.Data.Entity.Relational.Update
{
    public interface IModificationCommandBatchFactory
    {
        ModificationCommandBatch Create([NotNull] IDbContextOptions options);

        bool AddCommand(
            [NotNull] ModificationCommandBatch modificationCommandBatch,
            [NotNull] ModificationCommand modificationCommand);
    }
}

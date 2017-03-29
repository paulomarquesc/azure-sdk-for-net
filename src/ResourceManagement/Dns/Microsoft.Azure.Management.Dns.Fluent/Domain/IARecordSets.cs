// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Dns.Fluent
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions;
    using ResourceManager.Fluent.Core;

    /// <summary>
    /// Entry point to A record sets in a DNS zone.
    /// </summary>
    public interface IARecordSets  :
        ISupportsListing<Microsoft.Azure.Management.Dns.Fluent.IARecordSet>,
        ISupportsGettingByName<Microsoft.Azure.Management.Dns.Fluent.IARecordSet>,
        IHasParent<IDnsZone>
    {
    }
}
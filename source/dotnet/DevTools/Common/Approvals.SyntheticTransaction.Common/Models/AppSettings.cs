﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.


namespace Microsoft.CFS.Approvals.SyntheticTransaction.Common.Models;

/// <summary>
/// The AppSettings class
/// </summary>
public class AppSettings
{
    public string StorageAccountName { get; set; }
    public string StorageAccountKey { get; set; }
    public string PayloadReceiverServiceURL { get; set; }
    public string PayloadReceiverServiceAppKey { get; set; }
    public string PayloadReceiverServiceClientId { get; set; }
    public string ResourceURL { get; set; }
}
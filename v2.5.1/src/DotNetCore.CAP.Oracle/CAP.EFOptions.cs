﻿// Copyright (c) .NET Core Community. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;

// ReSharper disable once CheckNamespace
namespace DotNetCore.CAP
{
    public class EFOptions
    {
        public const string DefaultSchema = "CAP";

        /// <summary>
        /// Gets or sets the table name prefix to use when creating database objects.
        /// </summary>
        public string TableNamePrefix { get; set; } = DefaultSchema;

        /// <summary>
        /// EF db context type.
        /// </summary>
        internal Type DbContextType { get; set; }

        /// <summary>
        /// Data version
        /// </summary>
        internal string Version { get; set; } = "v1";

        /// <summary>
        /// Get Published Table Name
        /// </summary>
        /// <returns></returns>
        public string GetPublishedTableName()
        {
            return $"{TableNamePrefix}_PUBLISHED";
        }

        /// <summary>
        /// Get Received Table Name
        /// </summary>
        /// <returns></returns>
        public string GetReceivedTableName()
        {
            return $"{TableNamePrefix}_RECEIVED";
        }
    }
}
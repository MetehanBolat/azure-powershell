﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------


namespace Microsoft.Azure.PowerShell.Cmdlets.DataBoxEdge.Common.Cmdlets.Share
{
    internal class HelpMessageShare
    {
        internal const string StorageAccountCredentialHelpMessage =
            "Provide existing StorageAccountCredential's Resource Name";

        internal const string AccessProtocolHelpMessage = "AccessProtocol in the case of creating Share";

        internal const string SetUserAccessRightsHelpMessage =
            @"provide access right along with existing usernames to access SMB Share types, For ex: " +
            "@(" +
            "@{\"Username\"=\"user-name-1\";\"AccessRight\"=\"Read\"}, " +
            "@{\"Username\"=\"user-name-2\";\"AccessRight\"=\"Read\"}, " +
            "@{\"Username\"=\"user-name-3\";\"AccessRight\"=\"Custom\"}" +
            ")";

        internal const string SetClientAccessRightsHelpMessage = @"Read/Write Access for clientIds, For ex:" +
                                                                 "@(" +
                                                                 "@{\"ClientId\"=\"192.168.10.10\";\"AccessRight\"=\"NoAccess\"}, " +
                                                                 "@{\"ClientId\"=\"192.168.10.11\";\"AccessRight\"=\"ReadOnly\"}" +
                                                                 ")";

        internal const string NameHelpMessage = "Name of the Share";
        internal const string DataFormatHelpMessage = "Set Data Format ex: PageBlob, BlobBlob";
        internal const string ObjectName = "Share";

        internal const string LocalShareException =
            "StorageAccountCredential cannot be empty while creating Cloud Share. " +
            "\nIf you are trying to create local share please use switch parameter -";

        internal const string BothUseException =
            "StorageAccountCredential cannot be empty while creating Cloud Share. " +
            "\nIf you are trying to create local share please use switch parameter -";

        internal const string ContainerName =
            "If provided, will use the same container name in the storage account, " +
            "if container is not present it will create a new one";


    }
}
// --------------------------------------------------------------------------
// <copyright file="OdbcAccessAppSettings.cs" company="Devart">
//
// Copyright (c) Devart. ALL RIGHTS RESERVED
// Use of the source code is permitted under the license.
// </copyright>
// --------------------------------------------------------------------------

namespace Devart.AI.McpServer.Odbc.Access
{
  internal sealed class OdbcAccessAppSettings : McpAppSettings
  {
    public override string ServerName => $"Devart {Properties.ProductInfo.ProductFullName}";

    public override string SourceName => "Microsoft Access";

    public override bool OnPremise => true;
  }
}

// --------------------------------------------------------------------------
// <copyright file="OdbcAccessTools.cs" company="Devart">
//
// Copyright (c) Devart. ALL RIGHTS RESERVED
// Use of the source code is permitted under the license.
// </copyright>
// --------------------------------------------------------------------------

using System.Collections.Generic;
using ModelContextProtocol.Server;
using Devart.AI.McpServer.Odbc.Access.Tools;

namespace Devart.AI.McpServer.Odbc.Access
{
  internal static class OdbcAccessTools
  {
    public static List<McpServerTool> CreateTools(McpConfiguration configuration)
      => OdbcTools.CreateBuilder(configuration)
        .Add(new OdbcAccessPrimaryKeysTool(configuration))
        .Add(new OdbcAccessForeignKeysTool(configuration))
        .Build();
  }
}

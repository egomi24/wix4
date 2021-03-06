// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using WixToolset;
using WixToolset.Extensions;

[assembly: AssemblyTitle("WiX Toolset Validator Example Extension")]
[assembly: AssemblyDescription("WiX Toolset Validator Example Extension")]
[assembly: AssemblyCulture("")]
[assembly: CLSCompliant(true)]
[assembly: ComVisible(false)]
[assembly: AssemblyDefaultWixExtension(typeof(ValidatorExampleExtension))]

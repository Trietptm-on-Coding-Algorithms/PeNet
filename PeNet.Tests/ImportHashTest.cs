using System.Collections.Generic;
using PeNet;
// <copyright file="ImportHashTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeNet.ImpHash;

namespace PeNet.ImpHash.Tests
{
    [TestClass]
    [PexClass(typeof(ImportHash))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ImportHashTest
    {

        [PexMethod]
        public ImportHash Constructor(ICollection<ImportFunction> importedFunctions)
        {
            ImportHash target = new ImportHash(importedFunctions);
            return target;
            // TODO: add assertions to method ImportHashTest.Constructor(ICollection`1<ImportFunction>)
        }
    }
}

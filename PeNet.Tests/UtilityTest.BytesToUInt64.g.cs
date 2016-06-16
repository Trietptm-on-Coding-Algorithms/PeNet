using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="UtilityTest.BytesToUInt64.g.cs">Copyright ©  2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace PeNet.Tests
{
    public partial class UtilityTest
    {

[TestMethod]
[PexGeneratedBy(typeof(UtilityTest))]
[PexRaisedException(typeof(NullReferenceException))]
        [ExpectedException(typeof(NullReferenceException))]
        public void BytesToUInt64ThrowsNullReferenceException106()
{
    ulong l;
    l = this.BytesToUInt64((byte[])null, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(UtilityTest))]
[PexRaisedException(typeof(IndexOutOfRangeException))]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void BytesToUInt64ThrowsIndexOutOfRangeException965()
{
    ulong l;
    byte[] bs = new byte[0];
    l = this.BytesToUInt64(bs, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(UtilityTest))]
[PexRaisedException(typeof(IndexOutOfRangeException))]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void BytesToUInt64ThrowsIndexOutOfRangeException839()
{
    ulong l;
    byte[] bs = new byte[1];
    l = this.BytesToUInt64(bs, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(UtilityTest))]
[PexRaisedException(typeof(IndexOutOfRangeException))]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void BytesToUInt64ThrowsIndexOutOfRangeException382()
{
    ulong l;
    byte[] bs = new byte[2];
    l = this.BytesToUInt64(bs, 0uL);
}

[TestMethod]
[PexGeneratedBy(typeof(UtilityTest))]
public void BytesToUInt64800()
{
    ulong l;
    byte[] bs = new byte[15];
    l = this.BytesToUInt64(bs, 2uL);
    Assert.AreEqual<ulong>(0uL, l);
}

[TestMethod]
[PexGeneratedBy(typeof(UtilityTest))]
[PexRaisedException(typeof(IndexOutOfRangeException))]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void BytesToUInt64ThrowsIndexOutOfRangeException938()
{
    ulong l;
    byte[] bs = new byte[5];
    l = this.BytesToUInt64(bs, 1uL);
}
    }
}

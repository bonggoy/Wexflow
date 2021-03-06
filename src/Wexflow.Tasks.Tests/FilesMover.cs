﻿using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Wexflow.Tasks.Tests
{
    [TestClass]
    public class FilesMover
    {
        private static readonly string Src = @"C:\WexflowTesting\file10.txt";
        private static readonly string Dest = @"C:\WexflowTesting\FilesMover\file10.txt";

        [TestInitialize]
        public void TestInitialize()
        {
            if (File.Exists(Dest)) File.Move(Dest, Src);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            if(File.Exists(Dest)) File.Move(Dest, Src);
        }

        [TestMethod]
        public void Run()
        {
            Helper.StartWorkflow(4);
            Assert.AreEqual(true, File.Exists(Dest));
        }
    }
}

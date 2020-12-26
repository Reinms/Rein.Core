namespace Rein.Core.RegistrySystem._Tests
{
    using System;
    using System.Collections.Generic;

    using Microsoft.CodeAnalysis.CSharp.Syntax;

    using Xunit;
    using Xunit.Abstractions;
    using Xunit.Sdk;

    public class RegOrderer : ITestCaseOrderer
    {
        public IEnumerable<TTestCase> OrderTestCases<TTestCase>(IEnumerable<TTestCase> testCases) 
            where TTestCase : ITestCase
        {

        }
    }

    public class RegTests
    {
        
        public void Test1()
        {
            
        }
    }


    public struct TestDef : TestRegistry1.IRegistryDef
    {
        public TestDef(String name) => (this.guid, this.regToken) = (name, null);
        public String guid { get; }
        public TestRegistry1.RegistrationToken? regToken { get; set; }
    }


    public sealed class TestRegistry1 : Registry<TestRegistry1, TestDef>
    {

    }
}

using System;
using Logistics.Domain.Shared;
using Logistics.Domain.Subjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class SubjectCodeTests
{
    [TestMethod]
    public void CreateCode(){
        SubjectCode code = new SubjectCode("LAPR1");
        Assert.IsNotNull(code);
    }

    [TestMethod]
    public void EmptyCode()
    {
        try
        {
            SubjectCode code = new SubjectCode("");
            Assert.Fail("An exception should be thrown.");
        }
        catch (BusinessRuleValidationException ex)
        {
            string expected = "ERROR: Subjects Code is a ' 5 ' letter code.";
            Assert.AreEqual(expected, ex.Message);
        }
    }

    [TestMethod]
    public void NullCode()
    {
        try
        {
            SubjectCode code = new SubjectCode(null);
            Assert.Fail("An exception should be thrown.");
        }
        catch (BusinessRuleValidationException ex)
        {
            string expected = "ERROR: Subject Code cannot be null.";
            Assert.AreEqual(expected, ex.Message);
        }
    }

    [TestMethod]
    public void LongCode()
    {
        try
        {
            SubjectCode code = new SubjectCode("123456");
            Assert.Fail("An exception should be thrown.");
        }
        catch (BusinessRuleValidationException ex)
        {
            string expected = "ERROR: Subjects Code is a ' 5 ' letter code.";
            Assert.AreEqual(expected, ex.Message);
        }
    }

    [TestMethod]
    public void ShortCode()
    {
        try
        {
            SubjectCode code = new SubjectCode("1234");
            Assert.Fail("An exception should be thrown.");
        }
        catch (BusinessRuleValidationException ex)
        {
            string expected = "ERROR: Subjects Code is a ' 5 ' letter code.";
            Assert.AreEqual(expected, ex.Message);
        }
    }

    [TestMethod]
    public void CodeEquals(){
        SubjectCode code1 = new SubjectCode("12345");
        SubjectCode code2 = new SubjectCode("12345");
        Assert.IsTrue(code1.Equals(code2));
        Assert.IsTrue(code2.Equals(code1));

        SubjectCode code3 = new SubjectCode("56789");
        Assert.IsFalse(code1.Equals(code3));

        string code4 = "12345";
        Assert.IsFalse(code1.Equals(code4));
    }
}
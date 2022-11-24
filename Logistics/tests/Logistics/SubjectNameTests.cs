using System;
using Logistics.Domain.Shared;
using Logistics.Domain.Subjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class SubjectNameTests
{

    [TestMethod]
    public void CreateName()
    {
        SubjectName name = new SubjectName("Laboratory");
        Assert.IsNotNull(name);
    }

    [TestMethod]
    public void NameEmpty()
    {
        try
        {
            new SubjectName("");
            Assert.Fail("An exception should have been thrown.");
        }
        catch (BusinessRuleValidationException ex)
        {
            string expected = "ERROR: Subject name cannot be empty.";
            Assert.AreEqual(expected, ex.Message);
        }
    }

    [TestMethod]
    public void NameNull()
    {
        try
        {
            new SubjectName(null);
            Assert.Fail("An exception should have been thrown.");
        }
        catch (BusinessRuleValidationException ex)
        {
            string expected = "ERROR: Subject name cannot be empty.";
            Assert.AreEqual(expected, ex.Message);

        }
    }

    [TestMethod]
    public void LongName()
    {
        try
        {
            new SubjectName("123456789012345678901");
            Assert.Fail("An exception should have been thrown.");
        }
        catch (BusinessRuleValidationException ex)
        {
            string expected = "ERROR: Subject name cannot be longer than ' 20 ' chars.";
            Assert.AreEqual(expected, ex.Message);

        }
    }

    [TestMethod]
    public void NameEquals(){
        SubjectName name1 = new SubjectName("Test Name 1");
        SubjectName name2 = new SubjectName("Test Name 1");
        Assert.IsTrue(name1.Equals(name2));
        Assert.IsTrue(name2.Equals(name1));

        string name3 ="Test Name 1";
        Assert.IsFalse(name1.Equals(name3));

        SubjectName name4 = new SubjectName("Test Name 2");
        Assert.IsFalse(name1.Equals(name4));
    }
}